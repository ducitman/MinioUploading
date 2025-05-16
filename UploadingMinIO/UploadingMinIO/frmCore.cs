using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minio;
using Minio.DataModel;
using Minio.Exceptions;
using System.Reactive.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using Minio.DataModel.Args;
using Minio.ApiEndpoints;
using System.Reactive.Threading.Tasks;

namespace UploadingMinIO
{
    public partial class frmCore : Form
    {
        public string endPoint = "api.truyenhub.cloud";
        public string accessKey = "p2AeorPsoPsLJnduzQvw";
        public string secretKey = "WdZZ8NhM0YE6UdcR77l3L22qGbLpHCTkdfkhXibc";
        public string myBucket = "test-bucket";
        public string myConnectionString = "";
        public string folderPosterName = "";
        public bool isUploaded = false;
        public IMinioClient minioClient;
        private IMongoDatabase _database;
        private IMongoCollection<BsonDocument> _collection;
        public frmCore()
        {
            InitializeComponent();
            panelDragandDrop.AllowDrop = true;

            panelDragandDrop.DragEnter += PanelDragandDrop_DragEnter;
            panelDragandDrop.DragDrop += PanelDragandDrop_DragDrop;
        }   

        private void PanelDragandDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string filePath = files[0]; // Lấy file đầu tiên
                txtFilename.Text = filePath;
                //Path.GetFileName(filePath);

                // Nếu bạn muốn lưu đường dẫn gốc để upload sau
                txtFilename.Tag = filePath;
            }
        }

        private void PanelDragandDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        
        private async void frmCore_Load(object sender, EventArgs e)
        {
            ConnectMongoDB();
            List<string> comboboxItems = await GetPosterDocument();
            cBFolerName.Items.Clear();
            foreach (string item in comboboxItems)
            {
                cBFolerName.Items.Add(item);
            }
            minioClient = await ConnectMinIO();
            if (minioClient != null)
            {
                //MessageBox.Show($"Kết nối tới MinIO server và bucket '{myBucket}' thành công!");
                lblMinIOAddress.Text = endPoint;
                lblBucketname.Text = myBucket;
            }
            else
            {
                MessageBox.Show("Kết nối thất bại. Vui lòng kiểm tra lại thông tin hoặc server.");
            }
        }

        private void ConnectMongoDB()
        {
            try
            {
                myConnectionString = "mongodb://" + Properties.Settings.Default.MongoUser + ":" + Properties.Settings.Default.MongoPass + "@" + Properties.Settings.Default.MongoIPServer
                + ":" + Properties.Settings.Default.MongoDBPort + "/" + Properties.Settings.Default.MongoDBName + "?authSource=admin";
                MongoClient client = new MongoClient(myConnectionString);
                _database = client.GetDatabase(Properties.Settings.Default.MongoDBName);
                _collection = _database.GetCollection<BsonDocument>("books");

                lblDatabase.Text = Properties.Settings.Default.MongoDBName;
                lblIPAddress.Text = Properties.Settings.Default.MongoIPServer+ ":" + Properties.Settings.Default.MongoDBPort;
                lblStatus.Text = "Connected";
            }
            catch (Exception ex) {
                MessageBox.Show("Message:" + ex.Message);
            }            
        }

        private async Task<List<string>> GetPosterDocument()
        {
            try
            {
                // Truy vấn các document không có key "poster"
                var filter = Builders<BsonDocument>.Filter.Empty;
                    //Exists("poster", false);
                var documents = await _collection.Find(filter).ToListAsync();

                // Lấy danh sách giá trị slug
                var result = new List<string>();
                foreach (var doc in documents)
                {
                    if (doc.Contains("slug") && !doc["slug"].IsBsonNull)
                    {
                        result.Add(doc["slug"].AsString);
                    }
                }
                result = result.OrderBy(s => s).ToList();
                return result;
            }
            catch (MongoException ex)
            {
                Console.WriteLine($"MongoDB Error: {ex.Message}");
                return new List<string>();
            }            
        }
        static async Task ListPublicBuckets(IMinioClient minioClient)
        {
            try
            {
                // Lấy danh sách tất cả bucket                
                var buckets = await minioClient.ListBucketsAsync();

                Console.WriteLine("Public Buckets:");
                bool hasPublicBucket = false;

                // Duyệt qua từng bucket
                foreach (Bucket bucket in buckets.Buckets)
                {
                    try
                    {
                        // Lấy chính sách của bucket
                        var getPolicyArgs = new GetPolicyArgs()
                            .WithBucket(bucket.Name);
                        string policyJson = await minioClient.GetPolicyAsync(getPolicyArgs);

                        // Kiểm tra nếu chính sách cho phép truy cập công khai
                        if (!string.IsNullOrEmpty(policyJson) &&
                            policyJson.Contains("\"Effect\":\"Allow\"") &&
                            policyJson.Contains("\"Principal\":\"*\""))
                        {
                            Console.WriteLine($"- {bucket.Name} (Created: {bucket.CreationDate})");
                            hasPublicBucket = true;
                        }
                    }
                    catch (Minio.Exceptions.MinioException ex)
                    {
                        // Nếu bucket không có policy, bỏ qua (không public)
                        if (ex.Message.Contains("NoSuchBucketPolicy"))
                        {
                            continue;
                        }
                        Console.WriteLine($"Error checking policy for bucket {bucket.Name}: {ex.Message}");
                    }
                }

                if (!hasPublicBucket)
                {
                    Console.WriteLine("No public buckets found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error listing buckets: {ex.Message}");
            }
        }
        private async Task<IMinioClient> ConnectMinIO()
        {
            try
            {
                minioClient = new MinioClient()
                .WithEndpoint(endPoint,9000)
                .WithCredentials(accessKey, secretKey)
                .WithSSL(false)
                .Build();

                // Gọi hàm liệt kê bucket public
                await ListPublicBuckets(minioClient);

                bool checkExistBucket = await minioClient.BucketExistsAsync(new BucketExistsArgs().WithBucket(myBucket));

                if (checkExistBucket)
                {
                    return minioClient;
                }
                else 
                {                     
                    await minioClient.MakeBucketAsync(new MakeBucketArgs().WithBucket(myBucket));
                    MessageBox.Show($"Bucket '{myBucket}' đã được tạo.");
                    return minioClient;
                }
            }
            catch (MinioException ex)
            {
                MessageBox.Show($"Lỗi MinIO: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}");
                throw;
            }
            finally
            {
                
            }
        }


        private async void btnSelectfile_Click(object sender, EventArgs e)
        {
            if(cBFolerName.Text != "")
            {
                string fileName = "";
                string objectName = "";
                if (txtFilename.Text == "")
                {
                    
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        txtFilename.Text = openFileDialog1.FileName;
                        fileName = Path.GetFileName(txtFilename.Text);
                    }
                    else
                    {
                        return;
                    }

                    objectName = "data/story/poster/" + folderPosterName + "/" + fileName;
                    await UploadFileAsync(minioClient, txtFilename.Text, objectName);

                    if (isUploaded)
                    {
                        var (isUpdatedMongoDB, updateMessage) = await UpdateMongoDB(cBFolerName.Text, fileName);
                        if (isUpdatedMongoDB)
                        {
                            string log = $"{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} : {updateMessage} \n";
                            rTxtBoxLog.Text += log;
                            txtFilename.Text = "";
                            cBFolerName.Text = "";
                        }
                    }
                }
                else
                {
                    fileName = Path.GetFileName(txtFilename.Text);
                    objectName = "data/story/poster/" + folderPosterName + "/" + fileName;
                    await UploadFileAsync(minioClient, txtFilename.Text, objectName);

                    if (isUploaded)
                    {
                        var (isUpdatedMongoDB, updateMessage) = await UpdateMongoDB(cBFolerName.Text, fileName);
                        if (isUpdatedMongoDB)
                        {
                            string log = $"{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} : {updateMessage} \n";
                            rTxtBoxLog.Text += log;
                            txtFilename.Text = "";
                            cBFolerName.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thư mục truyện trước!","Cảnh Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cBFolerName.Focus();
            }
                        
        }

        private async Task<(bool Success, string Message)> UpdateMongoDB(string slug, string fileName)
        {
            try
            {
                string posterPath = $"data/story/poster/{slug}/{fileName}";
                var filter = Builders<BsonDocument>.Filter.Eq("slug", slug);

                var update = Builders<BsonDocument>.Update.Set("poster", posterPath);
                var result = await _collection.UpdateOneAsync(filter, update);

                if(result.MatchedCount == 0)
                {
                    return (false, $"Lỗi ===> Không có document nào có slug: {slug}");
                }

                return (true, $"OK === Updated thông tin poster cho truyện {slug} thành: {posterPath} thành công!");
            }
            catch(MongoException mgex)
            {
                return (false, $"Lỗi MongoDB ==> {mgex.Message}");
            }
            catch(Exception ex)
            {
                return (false, $"Lỗi ===> {ex.Message}");
            }
        }

        private void cBFolerName_TextChanged(object sender, EventArgs e)
        {
            folderPosterName = cBFolerName.Text.Trim();
        }


        // Tạo folder trong bucket
        private async Task CreateFolderAsync(IMinioClient minioClient, string folderPath)
        {
            try
            {
                string objectName = folderPath.EndsWith("/") ? folderPath : folderPath + "/"; //test-bucket/data 

                await minioClient.PutObjectAsync(new PutObjectArgs()
                    .WithBucket(myBucket)
                    .WithObject(objectName)
                    .WithContentType("application/x-directory")
                    .WithStreamData(new MemoryStream(new byte[0]))
                    .WithObjectSize(0));

                MessageBox.Show($"Tạo folder '{folderPath}' thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo folder: {ex.Message}");
                throw;
            }
        }

        // Upload file lên bucket
        private async Task UploadFileAsync(IMinioClient minioClient, string filePath, string objectName)
        {
            try
            {
                // Kiểm tra file có tồn tại không
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"File '{filePath}' không tồn tại.");
                    return;
                }
                string contentType = "";

                if (filePath.Contains(".png"))
                {
                    contentType = "image/png";
                }
                else if(filePath.Contains(".jpg") || filePath.Contains(".jpeg"))
                {
                    contentType = "image/jpeg";
                }

                await minioClient.PutObjectAsync(new PutObjectArgs()
                    .WithBucket(myBucket)
                    .WithObject(objectName)
                    .WithFileName(filePath)
                    .WithContentType(contentType));

                StatObjectArgs statObjectArgs = new StatObjectArgs()
                    .WithBucket(myBucket)
                    .WithObject(objectName);
                ObjectStat objectStat = await minioClient.StatObjectAsync(statObjectArgs);
                
                if(objectStat != null)
                {
                    isUploaded = true;
                }
                else
                {
                    isUploaded = false;
                }
                //MessageBox.Show($"Upload file '{objectStat.ObjectName}' : '{objectStat.ETag}' : '{objectStat.VersionId}' thành công.");
                //MessageBox.Show($"Upload file '{objectName}' thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi upload file: {ex.Message}");
                throw;
            }
        }

        // Hàm thay thế Path.GetRelativePath
        private string GetRelativePath(string basePath, string fullPath)
        {
            basePath = Path.GetFullPath(basePath).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
            fullPath = Path.GetFullPath(fullPath);

            if (!fullPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException($"{fullPath} không nằm trong thư mục {basePath}");
            }

            string relativePath = fullPath.Substring(basePath.Length + 1);
            return relativePath.Replace("\\", "/");
        }

        // Upload toàn bộ folder lên bucket
        private async Task UploadFolderAsync(IMinioClient minioClient, string folderPath, string prefix)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show($"Thư mục '{folderPath}' không tồn tại.");
                    return;
                }

                // Lấy tất cả file trong folder và subfolder
                string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    // Tạo object name dựa trên đường dẫn tương đối
                    string relativePath = GetRelativePath(folderPath, file);
                    string objectName = string.IsNullOrEmpty(prefix) ? relativePath : $"{prefix}/{relativePath}";

                    await UploadFileAsync(minioClient, file, objectName);
                }

                MessageBox.Show($"Upload folder '{folderPath}' thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi upload folder: {ex.Message}");
                throw;
            }
        }

        private void frmCore_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
