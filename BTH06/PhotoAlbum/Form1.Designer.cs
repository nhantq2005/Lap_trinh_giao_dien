namespace PhotoAlbum
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.Img = new System.Windows.Forms.PictureBox();
            this.listImg = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // treeFolder
            // 
            this.treeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeFolder.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treeFolder.ImageIndex = 0;
            this.treeFolder.ImageList = this.imageList1;
            this.treeFolder.Location = new System.Drawing.Point(2, -1);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.SelectedImageIndex = 0;
            this.treeFolder.Size = new System.Drawing.Size(229, 451);
            this.treeFolder.TabIndex = 0;
            this.treeFolder.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeCollapse);
            this.treeFolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeFolder_BeforeExpand);
            // 
            // Img
            // 
            this.Img.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Img.Location = new System.Drawing.Point(237, -1);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(562, 326);
            this.Img.TabIndex = 1;
            this.Img.TabStop = false;
            // 
            // listImg
            // 
            this.listImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listImg.Location = new System.Drawing.Point(237, 331);
            this.listImg.Name = "listImg";
            this.listImg.Size = new System.Drawing.Size(562, 119);
            this.listImg.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "open-folder.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listImg);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.treeFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.FlowLayoutPanel listImg;
        private System.Windows.Forms.ImageList imageList1;
    }
}

