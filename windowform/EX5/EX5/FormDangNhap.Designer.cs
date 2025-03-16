namespace EX5
{
    partial class FormDangNhap
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            chk_hienthi = new CheckBox();
            txt_matkhau = new TextBox();
            txt_tendangnhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            helpProvider1 = new HelpProvider();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(chk_hienthi);
            splitContainer1.Panel2.Controls.Add(txt_matkhau);
            splitContainer1.Panel2.Controls.Add(txt_tendangnhap);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 358);
            splitContainer1.SplitterDistance = 388;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avt1;
            pictureBox1.Location = new Point(-21, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 396);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 319);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 5;
            label4.Text = "Nhan F1 de duoc huong dan";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(224, 269);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 4;
            button2.Text = "Thoat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_thoat_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(93, 269);
            button1.Name = "button1";
            button1.Size = new Size(101, 33);
            button1.TabIndex = 4;
            button1.Text = "Dang nhap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_dangnhap_Click;
            // 
            // chk_hienthi
            // 
            chk_hienthi.AutoSize = true;
            chk_hienthi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_hienthi.Location = new Point(143, 230);
            chk_hienthi.Name = "chk_hienthi";
            chk_hienthi.Size = new Size(145, 24);
            chk_hienthi.TabIndex = 3;
            chk_hienthi.Text = "Hien thi mat khau";
            chk_hienthi.UseVisualStyleBackColor = true;
            chk_hienthi.Click += chk_hienthi_CheckedChanged;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(143, 180);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.Size = new Size(227, 23);
            txt_matkhau.TabIndex = 2;
            txt_matkhau.TextAlign = HorizontalAlignment.Center;
            txt_matkhau.KeyPress += txt_matkhau_KeyPress;
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Location = new Point(143, 120);
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(227, 23);
            txt_tendangnhap.TabIndex = 2;
            txt_tendangnhap.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 180);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Mat khau";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 120);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Ten dang nhap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 54);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Cua so dang nhap";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 358);
            Controls.Add(splitContainer1);
            Name = "FormDangNhap";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private TextBox txt_tendangnhap;
        private Label label2;
        private Label label1;
        private TextBox txt_matkhau;
        private Label label3;
        private Button button2;
        private Button button1;
        private CheckBox chk_hienthi;
        private Label label4;
        private ToolTip toolTip1;
        private HelpProvider helpProvider1;
        private ErrorProvider errorProvider1;
    }
}
