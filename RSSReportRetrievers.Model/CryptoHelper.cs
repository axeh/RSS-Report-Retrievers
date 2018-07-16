using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace RSSReportRetrievers.Model
{
    internal class CryptoHelper
    {
        private static readonly byte[] entropy = Encoding.Unicode.GetBytes("RSS_Salt");

        public static string EncryptString(SecureString input)
        {
            return Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(ToInsecureString(input)),
                entropy, DataProtectionScope.CurrentUser));
        }

        public static SecureString DecryptString(string encryptedData)
        {
            return ToSecureString(Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy,
                    DataProtectionScope.CurrentUser)));
        }

        public static SecureString ToSecureString(string input)
        {
            var secureString = new SecureString();
            foreach (var c in input)
                secureString.AppendChar(c);
            secureString.MakeReadOnly();
            return secureString;
        }

        public static string ToInsecureString(SecureString input)
        {
            var str = string.Empty;
            var bstr = Marshal.SecureStringToBSTR(input);
            try
            {
                str = Marshal.PtrToStringBSTR(bstr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(bstr);
            }

            return str;
        }
    }
}