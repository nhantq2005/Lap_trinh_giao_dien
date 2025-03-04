namespace XuLyChuoi
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
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.s1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.s3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insBtn = new System.Windows.Forms.Button();
            this.posIns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getStrBtn = new System.Windows.Forms.Button();
            this.numChar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.posGet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rpBtn = new System.Windows.Forms.Button();
            this.revBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.convBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(-1, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1058, 48);
            this.title.TabIndex = 0;
            this.title.Text = "CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi s1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuỗi s2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chuỗi s3:";
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(132, 64);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(893, 35);
            this.s1.TabIndex = 2;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(132, 114);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(395, 35);
            this.s2.TabIndex = 2;
            // 
            // s3
            // 
            this.s3.Location = new System.Drawing.Point(652, 114);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(373, 35);
            this.s3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insBtn);
            this.groupBox1.Controls.Add(this.posIns);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn s2 vào s1";
            // 
            // insBtn
            // 
            this.insBtn.AutoSize = true;
            this.insBtn.Location = new System.Drawing.Point(231, 34);
            this.insBtn.Name = "insBtn";
            this.insBtn.Size = new System.Drawing.Size(83, 32);
            this.insBtn.TabIndex = 2;
            this.insBtn.Text = "Chèn";
            this.insBtn.UseVisualStyleBackColor = true;
            this.insBtn.Click += new System.EventHandler(this.insBtn_Click);
            // 
            // posIns
            // 
            this.posIns.Location = new System.Drawing.Point(112, 36);
            this.posIns.Name = "posIns";
            this.posIns.Size = new System.Drawing.Size(100, 29);
            this.posIns.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vị trí chèn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getStrBtn);
            this.groupBox2.Controls.Add(this.numChar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.posGet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // getStrBtn
            // 
            this.getStrBtn.AutoSize = true;
            this.getStrBtn.Location = new System.Drawing.Point(403, 28);
            this.getStrBtn.Name = "getStrBtn";
            this.getStrBtn.Size = new System.Drawing.Size(158, 37);
            this.getStrBtn.TabIndex = 2;
            this.getStrBtn.Text = "Lấy chuỗi con";
            this.getStrBtn.UseVisualStyleBackColor = true;
            this.getStrBtn.Click += new System.EventHandler(this.getStrBtn_Click);
            // 
            // numChar
            // 
            this.numChar.Location = new System.Drawing.Point(284, 36);
            this.numChar.Name = "numChar";
            this.numChar.Size = new System.Drawing.Size(100, 29);
            this.numChar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số ký tự:";
            // 
            // posGet
            // 
            this.posGet.Location = new System.Drawing.Point(92, 36);
            this.posGet.Name = "posGet";
            this.posGet.Size = new System.Drawing.Size(100, 29);
            this.posGet.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Từ vị trí:";
            // 
            // rpBtn
            // 
            this.rpBtn.AutoSize = true;
            this.rpBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpBtn.Location = new System.Drawing.Point(506, 181);
            this.rpBtn.Name = "rpBtn";
            this.rpBtn.Size = new System.Drawing.Size(231, 37);
            this.rpBtn.TabIndex = 2;
            this.rpBtn.Text = "Thay s2 bằng s3";
            this.rpBtn.UseVisualStyleBackColor = true;
            this.rpBtn.Click += new System.EventHandler(this.rpBtn_Click);
            // 
            // revBtn
            // 
            this.revBtn.AutoSize = true;
            this.revBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revBtn.Location = new System.Drawing.Point(794, 183);
            this.revBtn.Name = "revBtn";
            this.revBtn.Size = new System.Drawing.Size(231, 37);
            this.revBtn.TabIndex = 2;
            this.revBtn.Text = "Đảo từ trong s1";
            this.revBtn.UseVisualStyleBackColor = true;
            this.revBtn.Click += new System.EventHandler(this.revBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.AutoSize = true;
            this.delBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(506, 226);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(231, 37);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "Xóa s2 trong s1";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // convBtn
            // 
            this.convBtn.AutoSize = true;
            this.convBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convBtn.Location = new System.Drawing.Point(794, 228);
            this.convBtn.Name = "convBtn";
            this.convBtn.Size = new System.Drawing.Size(231, 37);
            this.convBtn.TabIndex = 2;
            this.convBtn.Text = "Chuẩn hóa chuỗi";
            this.convBtn.UseVisualStyleBackColor = true;
            this.convBtn.Click += new System.EventHandler(this.convBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(747, 317);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(171, 37);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Khôi phục";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 400);
            this.Controls.Add(this.convBtn);
            this.Controls.Add(this.revBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.rpBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox s3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insBtn;
        private System.Windows.Forms.TextBox posIns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getStrBtn;
        private System.Windows.Forms.TextBox numChar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox posGet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rpBtn;
        private System.Windows.Forms.Button revBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button convBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

