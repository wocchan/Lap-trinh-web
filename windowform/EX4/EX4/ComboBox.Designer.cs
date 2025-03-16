namespace EX4
{
    partial class ComboBox
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
            lb_doimau = new Label();
            label2 = new Label();
            cbo_color = new System.Windows.Forms.ComboBox();
            btnDoiMau = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lb_doimau
            // 
            lb_doimau.AutoSize = true;
            lb_doimau.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_doimau.Location = new Point(117, 34);
            lb_doimau.Name = "lb_doimau";
            lb_doimau.Size = new Size(298, 22);
            lb_doimau.TabIndex = 0;
            lb_doimau.Text = "Chao mung ban den voi ComboBox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 82);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Chon mau";
            // 
            // cbo_color
            // 
            cbo_color.FormattingEnabled = true;
            cbo_color.Items.AddRange(new object[] { "Yellow", "Red", "Blue", "Black" });
            cbo_color.Location = new Point(259, 82);
            cbo_color.Name = "cbo_color";
            cbo_color.Size = new Size(85, 23);
            cbo_color.TabIndex = 2;
            // 
            // btnDoiMau
            // 
            btnDoiMau.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoiMau.Location = new Point(160, 139);
            btnDoiMau.Name = "btnDoiMau";
            btnDoiMau.Size = new Size(75, 31);
            btnDoiMau.TabIndex = 3;
            btnDoiMau.Text = "Doi mau";
            btnDoiMau.UseVisualStyleBackColor = true;
            btnDoiMau.Click += btn_doimau_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(301, 139);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 3;
            button2.Text = "Thoat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_thoat_Click;
            // 
            // ComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 237);
            Controls.Add(button2);
            Controls.Add(btnDoiMau);
            Controls.Add(cbo_color);
            Controls.Add(label2);
            Controls.Add(lb_doimau);
            Name = "ComboBox";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_doimau;
        private Label label2;
        private System.Windows.Forms.ComboBox cbo_color;
        private Button btnDoiMau;
        private Button button2;
    }
}
