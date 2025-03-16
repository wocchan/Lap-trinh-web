namespace EX3
{
    partial class CheckedChanged
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
            btnSoThich = new Button();
            button2 = new Button();
            chkbox_nghenhac = new CheckBox();
            chkbox_xemphim = new CheckBox();
            chkbox_thethao = new CheckBox();
            chkbox_muasam = new CheckBox();
            chxbox_dulich = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rdbtn_tim = new RadioButton();
            rdbtn_hong = new RadioButton();
            rdbtn_vang = new RadioButton();
            rdbtn_trang = new RadioButton();
            rdbtn_do = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSoThich
            // 
            btnSoThich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoThich.Location = new Point(113, 292);
            btnSoThich.Name = "btnSoThich";
            btnSoThich.Size = new Size(179, 42);
            btnSoThich.TabIndex = 1;
            btnSoThich.Text = "So thich cua ban";
            btnSoThich.UseVisualStyleBackColor = true;
            btnSoThich.Click += btn_sothich_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(483, 292);
            button2.Name = "button2";
            button2.Size = new Size(179, 42);
            button2.TabIndex = 1;
            button2.Text = "Mau ban thich";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_mauthich_Click;
            // 
            // chkbox_nghenhac
            // 
            chkbox_nghenhac.AutoSize = true;
            chkbox_nghenhac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbox_nghenhac.Location = new Point(24, 49);
            chkbox_nghenhac.Name = "chkbox_nghenhac";
            chkbox_nghenhac.Size = new Size(104, 25);
            chkbox_nghenhac.TabIndex = 0;
            chkbox_nghenhac.Text = "Nghe nhac";
            chkbox_nghenhac.UseVisualStyleBackColor = true;
            // 
            // chkbox_xemphim
            // 
            chkbox_xemphim.AutoSize = true;
            chkbox_xemphim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbox_xemphim.Location = new Point(24, 80);
            chkbox_xemphim.Name = "chkbox_xemphim";
            chkbox_xemphim.Size = new Size(100, 25);
            chkbox_xemphim.TabIndex = 0;
            chkbox_xemphim.Text = "Xem phim";
            chkbox_xemphim.UseVisualStyleBackColor = true;
            chkbox_xemphim.CheckedChanged += btn_sothich_Click;
            // 
            // chkbox_thethao
            // 
            chkbox_thethao.AutoSize = true;
            chkbox_thethao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbox_thethao.Location = new Point(24, 111);
            chkbox_thethao.Name = "chkbox_thethao";
            chkbox_thethao.Size = new Size(122, 25);
            chkbox_thethao.TabIndex = 0;
            chkbox_thethao.Text = "Choi the thao";
            chkbox_thethao.UseVisualStyleBackColor = true;
            // 
            // chkbox_muasam
            // 
            chkbox_muasam.AutoSize = true;
            chkbox_muasam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkbox_muasam.Location = new Point(24, 142);
            chkbox_muasam.Name = "chkbox_muasam";
            chkbox_muasam.Size = new Size(112, 25);
            chkbox_muasam.TabIndex = 0;
            chkbox_muasam.Text = "Di mua sam";
            chkbox_muasam.UseVisualStyleBackColor = true;
            // 
            // chxbox_dulich
            // 
            chxbox_dulich.AutoSize = true;
            chxbox_dulich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chxbox_dulich.Location = new Point(24, 173);
            chxbox_dulich.Name = "chxbox_dulich";
            chxbox_dulich.Size = new Size(94, 25);
            chxbox_dulich.TabIndex = 0;
            chxbox_dulich.Text = "Di du lich";
            chxbox_dulich.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chxbox_dulich);
            groupBox1.Controls.Add(chkbox_xemphim);
            groupBox1.Controls.Add(chkbox_nghenhac);
            groupBox1.Controls.Add(chkbox_muasam);
            groupBox1.Controls.Add(chkbox_thethao);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(68, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "So thich cua ban";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbtn_tim);
            groupBox2.Controls.Add(rdbtn_hong);
            groupBox2.Controls.Add(rdbtn_vang);
            groupBox2.Controls.Add(rdbtn_trang);
            groupBox2.Controls.Add(rdbtn_do);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(431, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 225);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mau ban thich";
            groupBox2.Enter += groupBox1_Enter;
            // 
            // rdbtn_tim
            // 
            rdbtn_tim.AutoSize = true;
            rdbtn_tim.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtn_tim.Location = new Point(29, 172);
            rdbtn_tim.Name = "rdbtn_tim";
            rdbtn_tim.Size = new Size(52, 25);
            rdbtn_tim.TabIndex = 0;
            rdbtn_tim.TabStop = true;
            rdbtn_tim.Text = "Tim";
            rdbtn_tim.UseVisualStyleBackColor = true;
            // 
            // rdbtn_hong
            // 
            rdbtn_hong.AutoSize = true;
            rdbtn_hong.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtn_hong.Location = new Point(29, 141);
            rdbtn_hong.Name = "rdbtn_hong";
            rdbtn_hong.Size = new Size(66, 25);
            rdbtn_hong.TabIndex = 0;
            rdbtn_hong.TabStop = true;
            rdbtn_hong.Text = "Hong";
            rdbtn_hong.UseVisualStyleBackColor = true;
            // 
            // rdbtn_vang
            // 
            rdbtn_vang.AutoSize = true;
            rdbtn_vang.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtn_vang.Location = new Point(29, 110);
            rdbtn_vang.Name = "rdbtn_vang";
            rdbtn_vang.Size = new Size(62, 25);
            rdbtn_vang.TabIndex = 0;
            rdbtn_vang.TabStop = true;
            rdbtn_vang.Text = "Vang";
            rdbtn_vang.UseVisualStyleBackColor = true;
            // 
            // rdbtn_trang
            // 
            rdbtn_trang.AutoSize = true;
            rdbtn_trang.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtn_trang.Location = new Point(29, 79);
            rdbtn_trang.Name = "rdbtn_trang";
            rdbtn_trang.Size = new Size(65, 25);
            rdbtn_trang.TabIndex = 0;
            rdbtn_trang.TabStop = true;
            rdbtn_trang.Text = "Trang";
            rdbtn_trang.UseVisualStyleBackColor = true;
            // 
            // rdbtn_do
            // 
            rdbtn_do.AutoSize = true;
            rdbtn_do.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtn_do.Location = new Point(29, 49);
            rdbtn_do.Name = "rdbtn_do";
            rdbtn_do.Size = new Size(48, 25);
            rdbtn_do.TabIndex = 0;
            rdbtn_do.TabStop = true;
            rdbtn_do.Text = "Do";
            rdbtn_do.UseVisualStyleBackColor = true;
            // 
            // CheckedChanged
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnSoThich);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "CheckedChanged";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSoThich;
        private Button button2;
        private CheckBox chkbox_nghenhac;
        private CheckBox chkbox_xemphim;
        private CheckBox chkbox_thethao;
        private CheckBox chkbox_muasam;
        private CheckBox chxbox_dulich;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdbtn_tim;
        private RadioButton rdbtn_hong;
        private RadioButton rdbtn_vang;
        private RadioButton rdbtn_trang;
        private RadioButton rdbtn_do;
    }
}
