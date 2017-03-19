using ABE.Models.Interfaces;
using DTOs.Files;

namespace ABE.Models.CPABE
{
    public class CiphertextPolicyEncryptedFile : IEncryptedFile
    {
        public FileDto File;
        public AccessTree AccessTree;
    }
}
