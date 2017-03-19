using System.Collections.Generic;

namespace ABE.Models.KPABE
{
    public class KeyPolicyAttributeBasedEncryption : AttributeBasedEncryption
    {
        public IList<KeyPolicyEncryptedFile> EncryptedFiles;
    }
}
