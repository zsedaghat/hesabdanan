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
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(429, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(307, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Bank List";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(424, 294);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(312, 44);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Seller List";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UploadBank
            // 
            this.UploadBank.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UploadBank.Location = new System.Drawing.Point(931, 123);
            this.UploadBank.Margin = new System.Windows.Forms.Padding(6);
            this.UploadBank.Name = "UploadBank";
            this.UploadBank.Size = new System.Drawing.Size(172, 50);
            this.UploadBank.TabIndex = 2;
            this.UploadBank.Text = "Browse";
            this.UploadBank.UseVisualStyleBackColor = true;
            this.UploadBank.Click += new System.EventHandler(this.UploadBank_Click);
            // 
            // UploadSeller
            // 
            this.UploadSeller.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UploadSeller.Location = new System.Drawing.Point(931, 279);
            this.UploadSeller.Margin = new System.Windows.Forms.Padding(6);
            this.UploadSeller.Name = "UploadSeller";
            this.UploadSeller.Size = new System.Drawing.Size(172, 50);
            this.UploadSeller.TabIndex = 3;
            this.UploadSeller.Text = "Browse";
            this.UploadSeller.UseVisualStyleBackColor = true;
            this.UploadSeller.Click += new System.EventHandler(this.UploadSeller_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // calculation
            // 
            this.calculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calculation.Font = new System.Drawing.Font("Perpetua", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculation.Location = new System.Drawing.Point(605, 474);
            this.calculation.Margin = new System.Windows.Forms.Padding(6);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(398, 109);
            this.calculation.TabIndex = 4;
            this.calculation.Text = "calculation";
            this.calculation.UseVisualStyleBackColor = false;
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.UploadSeller);
            this.Controls.Add(this.UploadBank);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Hesabdanan";
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

