using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace NetCoreCourse.CleanCodeDesignPatterns.Util
{

    //Avoid Mental Mapping
    public static class Manager
    {
        public static string GetHash(this string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static string GetCustomDecimalWithoutZero(this decimal amount)
        {
            var formatSpecifier = "N2";

            if ((amount % 1) == 0)
            {
                formatSpecifier = "N0";
            }

            return amount.ToString(formatSpecifier, new CultureInfo("es-AR"));
        }
    }
}
