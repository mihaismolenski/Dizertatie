using ABE.Models.BaseModels;

namespace ABE.Models.CPABE
{
    public class CiphertextPolicyEncryptedFile : BaseEncryptedFile
    {
        public File File;
        public AccessTree AccessTree;
    }
}
