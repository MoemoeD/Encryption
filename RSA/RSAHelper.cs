using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    public class RSAHelper
    {
        public struct key
        {
            public string publicKey { get; set; }

            public string privateKey { get; set; }
        }

        public key GetKey()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            return new key()
            {
                publicKey = rsa.ToXmlString(false),
                privateKey = rsa.ToXmlString(true)
            };
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Encrypt(string s, string key)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            return Convert.ToBase64String(rsa.Encrypt(Encoding.ASCII.GetBytes(s), false));
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Decrypt(string s, string key)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            return Encoding.ASCII.GetString(rsa.Decrypt(Convert.FromBase64String(s), false));
        }
    }
}
