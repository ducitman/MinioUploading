namespace UploadingMinIO
{
    partial class frmCore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCore));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectfile = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBucketname = new System.Windows.Forms.Label();
            this.lblMinIOAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pBfolderStatus = new System.Windows.Forms.PictureBox();
            this.cBFolerName = new System.Windows.Forms.ComboBox();
            this.txtFilename = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDragandDrop = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rTxtBoxLog = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfolderStatus)).BeginInit();
            this.panelDragandDrop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 454);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSelectfile);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSelectfile
            // 
            this.btnSelectfile.Location = new System.Drawing.Point(6, 29);
            this.btnSelectfile.Name = "btnSelectfile";
            this.btnSelectfile.Size = new System.Drawing.Size(92, 32);
            this.btnSelectfile.TabIndex = 0;
            this.btnSelectfile.Text = "Tải file";
            this.btnSelectfile.UseVisualStyleBackColor = true;
            this.btnSelectfile.Click += new System.EventHandler(this.btnSelectfile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBucketname);
            this.groupBox4.Controls.Add(this.lblMinIOAddress);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 82);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin MinIO Server";
            // 
            // lblBucketname
            // 
            this.lblBucketname.AutoSize = true;
            this.lblBucketname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucketname.Location = new System.Drawing.Point(99, 49);
            this.lblBucketname.Name = "lblBucketname";
            this.lblBucketname.Size = new System.Drawing.Size(41, 16);
            this.lblBucketname.TabIndex = 0;
            this.lblBucketname.Text = "label3";
            // 
            // lblMinIOAddress
            // 
            this.lblMinIOAddress.AutoSize = true;
            this.lblMinIOAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinIOAddress.Location = new System.Drawing.Point(99, 27);
            this.lblMinIOAddress.Name = "lblMinIOAddress";
            this.lblMinIOAddress.Size = new System.Drawing.Size(41, 16);
            this.lblMinIOAddress.TabIndex = 0;
            this.lblMinIOAddress.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bucket :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "IP Address:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.lblDatabase);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblIPAddress);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 102);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin DB Server";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(99, 74);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "label3";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(99, 49);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(41, 16);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(99, 27);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(41, 16);
            this.lblIPAddress.TabIndex = 0;
            this.lblIPAddress.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBfolderStatus);
            this.groupBox1.Controls.Add(this.cBFolerName);
            this.groupBox1.Controls.Add(this.txtFilename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt thông tin";
            // 
            // pBfolderStatus
            // 
            this.pBfolderStatus.Location = new System.Drawing.Point(351, 41);
            this.pBfolderStatus.Name = "pBfolderStatus";
            this.pBfolderStatus.Size = new System.Drawing.Size(29, 24);
            this.pBfolderStatus.TabIndex = 3;
            this.pBfolderStatus.TabStop = false;
            // 
            // cBFolerName
            // 
            this.cBFolerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFolerName.FormattingEnabled = true;
            this.cBFolerName.Location = new System.Drawing.Point(9, 41);
            this.cBFolerName.Name = "cBFolerName";
            this.cBFolerName.Size = new System.Drawing.Size(336, 24);
            this.cBFolerName.TabIndex = 2;
            this.cBFolerName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cBFolerName_DrawItem);
            this.cBFolerName.DropDownClosed += new System.EventHandler(this.cBFolerName_DropDownClosed);
            this.cBFolerName.TextChanged += new System.EventHandler(this.cBFolerName_TextChanged);
            this.cBFolerName.MouseLeave += new System.EventHandler(this.cBFolerName_MouseLeave);
            this.cBFolerName.MouseHover += new System.EventHandler(this.cBFolerName_MouseHover);
            this.cBFolerName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cBFolerName_MouseMove);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(9, 102);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(371, 47);
            this.txtFilename.TabIndex = 1;
            this.txtFilename.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thư mục:";
            // 
            // panelDragandDrop
            // 
            this.panelDragandDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDragandDrop.BackgroundImage = global::UploadingMinIO.Properties.Resources.addfileinterfacesymbolofpapersheetwithtextlinesandplussign_79821;
            this.panelDragandDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDragandDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDragandDrop.Controls.Add(this.label6);
            this.panelDragandDrop.Location = new System.Drawing.Point(416, 12);
            this.panelDragandDrop.Name = "panelDragandDrop";
            this.panelDragandDrop.Size = new System.Drawing.Size(538, 454);
            this.panelDragandDrop.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kéo thả media vào đây";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(12, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 118);
            this.panel2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rTxtBoxLog);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(941, 118);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Logs";
            // 
            // rTxtBoxLog
            // 
            this.rTxtBoxLog.Location = new System.Drawing.Point(10, 18);
            this.rTxtBoxLog.Name = "rTxtBoxLog";
            this.rTxtBoxLog.ReadOnly = true;
            this.rTxtBoxLog.Size = new System.Drawing.Size(925, 94);
            this.rTxtBoxLog.TabIndex = 0;
            this.rTxtBoxLog.Text = "";
            // 
            // frmCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDragandDrop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCore";
            this.Text = "Tải ảnh lên MinIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCore_FormClosing);
            this.Load += new System.EventHandler(this.frmCore_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBfolderStatus)).EndInit();
            this.panelDragandDrop.ResumeLayout(false);
            this.panelDragandDrop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelDragandDrop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectfile;
        private System.Windows.Forms.RichTextBox txtFilename;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cBFolerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBucketname;
        private System.Windows.Forms.Label lblMinIOAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pBfolderStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rTxtBoxLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}