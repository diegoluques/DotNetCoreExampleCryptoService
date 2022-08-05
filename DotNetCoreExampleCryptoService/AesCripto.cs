using System;
using System.Security.Cryptography;
using System.Text;

namespace DotNetCoreExampleCryptoService
{
    public static class AesCripto
    {
        private static string KEY = "13245678901234567890123456789012";
        private static string IV = "0132456789012345";

        public static string Encript(string textToEncript)
        {
            var keyBytes = Encoding.UTF8.GetBytes(KEY);
            var vetor = Encoding.UTF8.GetBytes(IV);

            var bytesTextToEncript = Encoding.UTF8.GetBytes(textToEncript);

            using AesCryptoServiceProvider myAes = new();
            using ICryptoTransform enc = myAes.CreateEncryptor(keyBytes, vetor);
            var bytesEncripted = enc.TransformFinalBlock(bytesTextToEncript, 0, bytesTextToEncript.Length);

            return Convert.ToBase64String(bytesEncripted);
        }

        public static string Decript(string textBase64)
        {
            var keyBytes = Encoding.UTF8.GetBytes(KEY);
            var vetor = Encoding.UTF8.GetBytes(IV);

            // shjdjfvsd sdjfvsfvj jsvf 
            var bytesEncripted = Convert.FromBase64String(textBase64);


            using AesCryptoServiceProvider myAes = new();
            using ICryptoTransform enc = myAes.CreateDecryptor(keyBytes, vetor);
            var bytesDecripteds = enc.TransformFinalBlock(bytesEncripted, 0, bytesEncripted.Length);

            return Encoding.UTF8.GetString(bytesDecripteds);
        }
    }
}