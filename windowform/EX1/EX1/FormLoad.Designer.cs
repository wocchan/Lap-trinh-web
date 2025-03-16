namespace EX1
{
    partial class FormLoad
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
            txtHoTen = new Label();
            textBox1 = new TextBox();
            btnHienThi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.AutoSize = true;
            txtHoTen.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(72, 95);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(95, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.Text = "Ho va Ten";
            txtHoTen.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 1;
            // 
            // btnHienThi
            // 
            btnHienThi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHienThi.Location = new Point(208, 185);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(100, 40);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "Hien thi";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btn_hienthi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(370, 185);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 40);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btn_thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 317);
            Controls.Add(btnThoat);
            Controls.Add(btnHienThi);
            Controls.Add(textBox1);
            Controls.Add(txtHoTen);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtHoTen;
        private TextBox textBox1;
        private Button btnHienThi;
        private Button btnThoat;
    }
}
