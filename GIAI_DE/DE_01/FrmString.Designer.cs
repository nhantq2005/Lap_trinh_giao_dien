namespace DE_01
{
    partial class FrmString
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputStr = new System.Windows.Forms.TextBox();
            this.addLast = new System.Windows.Forms.RadioButton();
            this.addFirst = new System.Windows.Forms.RadioButton();
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.btSetFont = new System.Windows.Forms.Button();
            this.btSetTemplate = new System.Windows.Forms.Button();
            this.btDaoChuoi = new System.Windows.Forms.Button();
            this.btChuanHoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(458, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 498);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ĐỊnh dạng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập chuỗi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chuỗi định dạng";
            // 
            // inputStr
            // 
            this.inputStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputStr.Location = new System.Drawing.Point(16, 77);
            this.inputStr.Name = "inputStr";
            this.inputStr.Size = new System.Drawing.Size(424, 27);
            this.inputStr.TabIndex = 2;
            // 
            // addLast
            // 
            this.addLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addLast.AutoSize = true;
            this.addLast.Checked = true;
            this.addLast.Location = new System.Drawing.Point(25, 128);
            this.addLast.Name = "addLast";
            this.addLast.Size = new System.Drawing.Size(239, 24);
            this.addLast.TabIndex = 3;
            this.addLast.TabStop = true;
            this.addLast.Text = "Chèn vào cuối danh sách";
            this.addLast.UseVisualStyleBackColor = true;
            // 
            // addFirst
            // 
            this.addFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addFirst.AutoSize = true;
            this.addFirst.Location = new System.Drawing.Point(25, 170);
            this.addFirst.Name = "addFirst";
            this.addFirst.Size = new System.Drawing.Size(239, 24);
            this.addFirst.TabIndex = 3;
            this.addFirst.Text = "Chèn vào cuối danh sách";
            this.addFirst.UseVisualStyleBackColor = true;
            // 
            // list1
            // 
            this.list1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 20;
            this.list1.Location = new System.Drawing.Point(12, 213);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(440, 264);
            this.list1.TabIndex = 4;
            // 
            // list2
            // 
            this.list2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list2.FormattingEnabled = true;
            this.list2.ItemHeight = 20;
            this.list2.Location = new System.Drawing.Point(483, 77);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(440, 264);
            this.list2.TabIndex = 4;
            // 
            // btSetFont
            // 
            this.btSetFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetFont.AutoSize = true;
            this.btSetFont.Location = new System.Drawing.Point(507, 369);
            this.btSetFont.Name = "btSetFont";
            this.btSetFont.Size = new System.Drawing.Size(137, 30);
            this.btSetFont.TabIndex = 5;
            this.btSetFont.Text = "Định dạng font";
            this.btSetFont.UseVisualStyleBackColor = true;
            // 
            // btSetTemplate
            // 
            this.btSetTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSetTemplate.AutoSize = true;
            this.btSetTemplate.Location = new System.Drawing.Point(727, 369);
            this.btSetTemplate.Name = "btSetTemplate";
            this.btSetTemplate.Size = new System.Drawing.Size(137, 30);
            this.btSetTemplate.TabIndex = 5;
            this.btSetTemplate.Text = "Định dạng mẫu";
            this.btSetTemplate.UseVisualStyleBackColor = true;
            this.btSetTemplate.Click += new System.EventHandler(this.btSetTemplate_Click);
            // 
            // btDaoChuoi
            // 
            this.btDaoChuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDaoChuoi.AutoSize = true;
            this.btDaoChuoi.Location = new System.Drawing.Point(507, 425);
            this.btDaoChuoi.Name = "btDaoChuoi";
            this.btDaoChuoi.Size = new System.Drawing.Size(137, 30);
            this.btDaoChuoi.TabIndex = 5;
            this.btDaoChuoi.Text = "Đảo chuỗi";
            this.btDaoChuoi.UseVisualStyleBackColor = true;
            // 
            // btChuanHoa
            // 
            this.btChuanHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btChuanHoa.AutoSize = true;
            this.btChuanHoa.Location = new System.Drawing.Point(727, 425);
            this.btChuanHoa.Name = "btChuanHoa";
            this.btChuanHoa.Size = new System.Drawing.Size(137, 30);
            this.btChuanHoa.TabIndex = 5;
            this.btChuanHoa.Text = "Chuẩn hóa";
            this.btChuanHoa.UseVisualStyleBackColor = true;
            this.btChuanHoa.Click += new System.EventHandler(this.btSetTemplate_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Location = new System.Drawing.Point(303, 122);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(137, 30);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.Location = new System.Drawing.Point(303, 167);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(137, 30);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // FrmString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(931, 497);
            this.Controls.Add(this.btChuanHoa);
            this.Controls.Add(this.btSetTemplate);
            this.Controls.Add(this.btDaoChuoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSetFont);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.addFirst);
            this.Controls.Add(this.addLast);
            this.Controls.Add(this.inputStr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmString";
            this.Text = "Xử lý chuỗi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputStr;
        private System.Windows.Forms.RadioButton addLast;
        private System.Windows.Forms.RadioButton addFirst;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Button btSetFont;
        private System.Windows.Forms.Button btSetTemplate;
        private System.Windows.Forms.Button btDaoChuoi;
        private System.Windows.Forms.Button btChuanHoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
    }
}