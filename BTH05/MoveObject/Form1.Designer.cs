namespace MoveObject
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
            this.listImg = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // listImg
            // 
            this.listImg.AutoScroll = true;
            this.listImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.listImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listImg.Location = new System.Drawing.Point(898, 2);
            this.listImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listImg.Name = "listImg";
            this.listImg.Size = new System.Drawing.Size(203, 607);
            this.listImg.TabIndex = 0;
            this.listImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listImg_MouseDown);
            this.listImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listImg_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.listImg);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel listImg;
    }
}

