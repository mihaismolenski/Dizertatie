using System.Collections.Generic;

namespace ABE.Models.CPABE
{
    public class CiphertextPolicyAttributeBasedEncryption : AttributeBasedEncryption
    {
        public IList<CiphertextPolicyEncryptedFile> EncryptedFiles;
    }
}
