namespace Encryption
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRSAEncrypt = new System.Windows.Forms.Button();
            this.btnRSADecrypt = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRSAEncrypt
            // 
            this.btnRSAEncrypt.Location = new System.Drawing.Point(50, 50);
            this.btnRSAEncrypt.Name = "btnRSAEncrypt";
            this.btnRSAEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnRSAEncrypt.TabIndex = 0;
            this.btnRSAEncrypt.Text = "RSA加密";
            this.btnRSAEncrypt.UseVisualStyleBackColor = true;
            this.btnRSAEncrypt.Click += new System.EventHandler(this.btnRSAEncrypt_Click);
            // 
            // btnRSADecrypt
            // 
            this.btnRSADecrypt.Location = new System.Drawing.Point(50, 100);
            this.btnRSADecrypt.Name = "btnRSADecrypt";
            this.btnRSADecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnRSADecrypt.TabIndex = 1;
            this.btnRSADecrypt.Text = "RSA解密";
            this.btnRSADecrypt.UseVisualStyleBackColor = true;
            this.btnRSADecrypt.Click += new System.EventHandler(this.btnRSADecrypt_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(400, 50);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(600, 300);
            this.txtText.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnRSADecrypt);
            this.Controls.Add(this.btnRSAEncrypt);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRSAEncrypt;
        private System.Windows.Forms.Button btnRSADecrypt;
        private System.Windows.Forms.TextBox txtText;
    }
}

