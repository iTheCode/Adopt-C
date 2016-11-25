using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Adopt_CSharp
{
    class encriptar
    {
        string key = "mi key";
        public string encripta(string texto)
        {
            byte[] keyArray;
            byte[] arreglo_a_cifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform ctransform = tdes.CreateEncryptor();
            byte[] Arrayresultado = ctransform.TransformFinalBlock(arreglo_a_cifrar, 0, arreglo_a_cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(Arrayresultado, 0, Arrayresultado.Length);
        }





    }
}
