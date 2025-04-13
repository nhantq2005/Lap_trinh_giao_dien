namespace DE_MAU_02
{
    partial class FrmDelay
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
            this.picL = new System.Windows.Forms.PictureBox();
            this.picR = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            this.SuspendLayout();
            // 
            // picL
            // 
            this.picL.Image = global::DE_MAU_02.Properties.Resources._2;
            this.picL.Location = new System.Drawing.Point(0, 12);
            this.picL.Name = "picL";
            this.picL.Size = new System.Drawing.Size(202, 182);
            this.picL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picL.TabIndex = 0;
            this.picL.TabStop = false;
            // 
            // picR
            // 
            this.picR.Image = global::DE_MAU_02.Properties.Resources._5;
            this.picR.Location = new System.Drawing.Point(940, 12);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(202, 182);
            this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picR.TabIndex = 0;
            this.picR.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDelay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 205);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.picL);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDelay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDelay";
            ((System.ComponentModel.ISupportInitialize)(this.picL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picL;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.Timer timer1;
    }
}