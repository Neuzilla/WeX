using System;
using System.Linq;
using System.Text;

namespace Neuzilla.Wex.Core
{
    public class CheckSignature
    {
        /// <summary>
        /// 在网站没有提供Token（或传入为null）的情况下的默认Token，建议在网站中进行配置。
        /// </summary>
        public const string Token = "weixin";

        /// <summary>
        /// 检查签名是否正确
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static bool Check(string signature, string timestamp, string nonce, string token = null)
        {
            return signature == GetSignature(timestamp, nonce, token);
        }
        /// <summary>
        /// from http://stackoverflow.com/questions/311165/how-do-you-convert-byte-array-to-hexadecimal-string-and-vice-versa
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static string ByteArrayToHex(byte[] bytes)
        {
            return String.Concat(Array.ConvertAll(bytes, x => x.ToString("x2"))); 
        }
        /// <summary>
        /// 返回正确的签名
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string GetSignature(string timestamp, string nonce, string token = null)
        {
            token = token ?? Token;
            var arr = new[] { token, timestamp, nonce }.OrderBy(z => z).ToArray();
            var arrString = string.Join("", arr);
             var sha1 = System.Security.Cryptography.SHA1.Create();
            var sha1Arr = sha1.ComputeHash(Encoding.UTF8.GetBytes(arrString));
            return ByteArrayToHex(sha1Arr);
        }
    }
}
