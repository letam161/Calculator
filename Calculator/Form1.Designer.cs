namespace Calculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoa.Location = new System.Drawing.Point(178, 53);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(445, 39);
            this.txtSoa.TabIndex = 3;
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSob.Location = new System.Drawing.Point(178, 154);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(445, 39);
            this.txtSob.TabIndex = 4;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKetQua.Location = new System.Drawing.Point(178, 256);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(445, 39);
            this.txtKetQua.TabIndex = 5;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(251, 353);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(127, 60);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTru.Location = new System.Drawing.Point(465, 353);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(127, 60);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoa;
        private TextBox txtSob;
        private TextBox txtKetQua;
        private Button btCong;
        private Button btTru;
    }
}