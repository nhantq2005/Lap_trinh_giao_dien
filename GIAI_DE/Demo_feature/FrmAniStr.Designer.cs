namespace Demo_feature
{
    partial class FrmAniStr
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
            this.txt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.paintBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(2, 145);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(794, 59);
            this.txt.TabIndex = 0;
            this.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // paintBt
            // 
            this.paintBt.Location = new System.Drawing.Point(26, 357);
            this.paintBt.Name = "paintBt";
            this.paintBt.Size = new System.Drawing.Size(75, 23);
            this.paintBt.TabIndex = 1;
            this.paintBt.Text = "Paint";
            this.paintBt.UseVisualStyleBackColor = true;
            this.paintBt.Click += new System.EventHandler(this.paintBt_Click);
            // 
            // FrmAniStr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paintBt);
            this.Controls.Add(this.txt);
            this.DoubleBuffered = true;
            this.Name = "FrmAniStr";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAniStr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button paintBt;
    }
}

