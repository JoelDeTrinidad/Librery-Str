using Microsoft.Extensions.Configuration;

namespace Librery_Str.Helper.Interfaces
{
    public interface IEncryptionHelper
    {
        string SHA1HashStringForUTF8String(string s);
    }
}