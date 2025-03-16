namespace EX2
{
    partial class CaculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSoThuNhat = new Label();
            txtSoThuHai = new Label();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            label1 = new Label();
            txt_result = new TextBox();
            SuspendLayout();
            // 
            // txtSoThuNhat
            // 
            txtSoThuNhat.AutoSize = true;
            txtSoThuNhat.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoThuNhat.Location = new Point(87, 74);
            txtSoThuNhat.Name = "txtSoThuNhat";
            txtSoThuNhat.Size = new Size(95, 21);
            txtSoThuNhat.TabIndex = 0;
            txtSoThuNhat.Text = "So thu nhat";
            // 
            // txtSoThuHai
            // 
            txtSoThuHai.AutoSize = true;
            txtSoThuHai.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoThuHai.Location = new Point(87, 116);
            txtSoThuHai.Name = "txtSoThuHai";
            txtSoThuHai.Size = new Size(85, 21);
            txtSoThuHai.TabIndex = 0;
            txtSoThuHai.Text = "So thu hai";
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(188, 72);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(275, 23);
            txt_num1.TabIndex = 1;
            txt_num1.TextChanged += textBox1_TextChanged;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(188, 114);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(275, 23);
            txt_num2.TabIndex = 1;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("TNH Xuong", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCong.Location = new Point(115, 173);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(32, 32);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btn_cong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("TNH Xuong", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTru.Location = new Point(176, 173);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(32, 32);
            btnTru.TabIndex = 2;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btn_tru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("TNH Xuong", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhan.Location = new Point(242, 173);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(32, 32);
            btnNhan.TabIndex = 2;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btn_nhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("TNH Xuong", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChia.Location = new Point(307, 173);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(32, 32);
            btnChia.TabIndex = 2;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btn_chia_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(365, 173);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 32);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Del";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btn_xoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 240);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Ket qua";
            // 
            // txt_result
            // 
            txt_result.Location = new Point(188, 240);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(275, 23);
            txt_result.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 337);
            Controls.Add(btnXoa);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txt_result);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(label1);
            Controls.Add(txtSoThuHai);
            Controls.Add(txtSoThuNhat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtSoThuNhat;
        private Label txtSoThuHai;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Label label1;
        private TextBox txt_result;
    }
}
