namespace Hesabdanan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.UploadBank = new System.Windows.Forms.Button();
            this.UploadSeller = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.calculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(180, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Bank List";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(180, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Seller List";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseWaitCursor = true;
            // 
            // UploadBank
            // 
            this.UploadBank.Location = new System.Drawing.Point(400, 64);
            this.UploadBank.Name = "UploadBank";
            this.UploadBank.Size = new System.Drawing.Size(86, 26);
            this.UploadBank.TabIndex = 2;
            this.UploadBank.Text = "Browse";
            this.UploadBank.UseVisualStyleBackColor = true;
            this.UploadBank.UseWaitCursor = true;
            this.UploadBank.Click += new System.EventHandler(this.UploadBank_Click);
            // 
            // UploadSeller
            // 
            this.UploadSeller.Location = new System.Drawing.Point(400, 153);
            this.UploadSeller.Name = "UploadSeller";
            this.UploadSeller.Size = new System.Drawing.Size(86, 26);
            this.UploadSeller.TabIndex = 3;
            this.UploadSeller.Text = "Browse";
            this.UploadSeller.UseVisualStyleBackColor = true;
            this.UploadSeller.UseWaitCursor = true;
            this.UploadSeller.Click += new System.EventHandler(this.UploadSeller_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // calculation
            // 
            this.calculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calculation.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculation.Location = new System.Drawing.Point(300, 240);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(146, 49);
            this.calculation.TabIndex = 4;
            this.calculation.Text = "calculation";
            this.calculation.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.UploadSeller);
            this.Controls.Add(this.UploadBank);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Hesabdanan";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button UploadBank;
        private System.Windows.Forms.Button UploadSeller;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button calculation;
    }
}

