using System.Security.Cryptography;
using System.Text;

public static class RandomStringHelper
{
    public static string GenerateRandomUniqueString(int length)
    {
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        StringBuilder sb = new StringBuilder();
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            byte[] uintBuffer = new byte[sizeof(uint)];
            while (length-- > 0)
            {
                rng.GetBytes(uintBuffer);
                uint num = BitConverter.ToUInt32(uintBuffer, 0);
                sb.Append(valid[(int)(num % (uint)valid.Length)]);
            }
        }
        return sb.ToString();
    }
}