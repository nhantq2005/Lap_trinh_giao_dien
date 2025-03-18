namespace Xucxac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diceGuess = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.diceResult = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.thualb = new System.Windows.Forms.Label();
            this.thanglb = new System.Windows.Forms.Label();
            this.doanlb = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceGuess)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diceGuess);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(326, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đoán số";
            // 
            // diceGuess
            // 
            this.diceGuess.Image = global::Xucxac.Properties.Resources._1;
            this.diceGuess.Location = new System.Drawing.Point(86, 41);
            this.diceGuess.Name = "diceGuess";
            this.diceGuess.Size = new System.Drawing.Size(144, 117);
            this.diceGuess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceGuess.TabIndex = 1;
            this.diceGuess.TabStop = false;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(252, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 32);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(9, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(252, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 32);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(9, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(252, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(9, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 32);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetBtn);
            this.groupBox2.Controls.Add(this.randomBtn);
            this.groupBox2.Controls.Add(this.diceResult);
            this.groupBox2.Location = new System.Drawing.Point(15, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(367, 236);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Qauy số ngẫu nhiên";
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.Location = new System.Drawing.Point(194, 185);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(152, 32);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset (ESC)";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.AutoSize = true;
            this.randomBtn.Location = new System.Drawing.Point(9, 185);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(152, 32);
            this.randomBtn.TabIndex = 2;
            this.randomBtn.Text = "Quay số (Enter)";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // diceResult
            // 
            this.diceResult.Image = global::Xucxac.Properties.Resources._6;
            this.diceResult.Location = new System.Drawing.Point(86, 41);
            this.diceResult.Name = "diceResult";
            this.diceResult.Size = new System.Drawing.Size(144, 117);
            this.diceResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diceResult.TabIndex = 1;
            this.diceResult.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.thualb);
            this.groupBox3.Controls.Add(this.thanglb);
            this.groupBox3.Controls.Add(this.doanlb);
            this.groupBox3.Location = new System.Drawing.Point(15, 481);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 173);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // thualb
            // 
            this.thualb.AutoSize = true;
            this.thualb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.thualb.Location = new System.Drawing.Point(17, 125);
            this.thualb.Name = "thualb";
            this.thualb.Size = new System.Drawing.Size(147, 22);
            this.thualb.TabIndex = 0;
            this.thualb.Text = "Lần thua: 0 (0%)";
            // 
            // thanglb
            // 
            this.thanglb.AutoSize = true;
            this.thanglb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.thanglb.Location = new System.Drawing.Point(17, 85);
            this.thanglb.Name = "thanglb";
            this.thanglb.Size = new System.Drawing.Size(158, 22);
            this.thanglb.TabIndex = 0;
            this.thanglb.Text = "Lần thắng: 0 (0%)";
            // 
            // doanlb
            // 
            this.doanlb.AutoSize = true;
            this.doanlb.ForeColor = System.Drawing.Color.Blue;
            this.doanlb.Location = new System.Drawing.Point(17, 44);
            this.doanlb.Name = "doanlb";
            this.doanlb.Size = new System.Drawing.Size(109, 22);
            this.doanlb.TabIndex = 0;
            this.doanlb.Text = "Lần đoán: 0";
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 22;
            this.history.Location = new System.Drawing.Point(423, 33);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(414, 620);
            this.history.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 666);
            this.Controls.Add(this.history);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Xúc xắc";
         
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceGuess)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox diceGuess;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.PictureBox diceResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label thualb;
        private System.Windows.Forms.Label thanglb;
        private System.Windows.Forms.Label doanlb;
        private System.Windows.Forms.ListBox history;
    }
}

