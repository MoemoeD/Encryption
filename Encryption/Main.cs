using RSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRSAEncrypt_Click(object sender, EventArgs e)
        {
            RSAHelper helper = new RSAHelper();
            string text = txtText.Text.Trim();
            txtText.Text = helper.Encrypt(text);
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRSADecrypt_Click(object sender, EventArgs e)
        {
            RSAHelper helper = new RSAHelper();
            string text = txtText.Text.Trim();
            txtText.Text = helper.Decrypt(text);
        }
    }
}
