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
        private const string publicKey = "<RSAKeyValue><Modulus>oXdiLEawrn1pJ/kbhczsHJ9yATR5H9ppB39pjUVNPjWQhjLIZqaE1Jt5oOIrYV5Klz8PTUrjbXnRI6D9O3ClDeQo1hfUkTjf8c88Z+cIiIHP+1JJMspd66Ip05XtwQ2Y2bseoa35Iu4gtjfDDP/UFF/Rk7LQcQl1xX5WoPno640=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        private const string privateKey = "<RSAKeyValue><Modulus>oXdiLEawrn1pJ/kbhczsHJ9yATR5H9ppB39pjUVNPjWQhjLIZqaE1Jt5oOIrYV5Klz8PTUrjbXnRI6D9O3ClDeQo1hfUkTjf8c88Z+cIiIHP+1JJMspd66Ip05XtwQ2Y2bseoa35Iu4gtjfDDP/UFF/Rk7LQcQl1xX5WoPno640=</Modulus><Exponent>AQAB</Exponent><P>0KeLjx0+JkqI0bF4uvlrm+j0UyqYYhGExpPBY+wH6eR+/1getSkRsT+paH8IPdUnPgPnG+PKIsvqpN7D9i9LMw==</P><Q>xhq+b7mlbmCP1AAFcXphKD1sWLFL5cECQaE4D6rNsdSAes1jgpz1PEl9UHI4rdrWWzxUiqJ5tDNZmztTQjTuPw==</Q><DP>v13bDqAoXyAfCgt2Ci419qGabCh16APfPe1IAmf4/hhWLcTZLRgEpQcZTcCsg2Fag3M65IZv3qgdhabWHZVUpw==</DP><DQ>TrtGQCTp6Gob/0da4nSetF1k+ALOhSsl+GtYWnGpeilYPnXuPHSgyiry0Mv0VrQISQ47EzXrZICb9iOnvUJIBQ==</DQ><InverseQ>Wxmq6vzucu3oHjttr9Y32/aWj9nPvm9t7zJFqWswBBqzLKTzW8Lq/ecdsQkDI9iKoJTTD62hq7IwpkLMKCPqcg==</InverseQ><D>Ak0XQxZG0lXLN9ye/csr2kSTdVzwFPoh4Q95y5+fODG/O4phvMTGw9jrZNWUVLDpUzp811cn4pmH14Al28EBOSmpOnnos57Ref7Tkf0svXg4gJG6oRHPNsHS8YDnyDc5P30Jj985Xz7K6iqehtAKq6Bs1dpm/Dnp4nGmnzf40ik=</D></RSAKeyValue>";

        public RSAHelper()
        {
            //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //publicKey = rsa.ToXmlString(false);
            //privateKey = rsa.ToXmlString(true);
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Encrypt(string text)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            return Convert.ToBase64String(rsa.Encrypt(Encoding.ASCII.GetBytes(text), false));
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string Decrypt(string text)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);
            return Encoding.ASCII.GetString(rsa.Decrypt(Convert.FromBase64String(text), false));
        }
    }
}
