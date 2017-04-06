using System.Collections.Generic;

namespace ABE.Models.CPABE
{
    public class CiphertextPolicyAttributeBasedEncryption : AttributeBasedEncryption
    {
        public PublicParameters Setup()
        {
            MasterKey = new MasterKey();
            return new PublicParameters();
        }

        public CiphertextPolicyEncryptedFile Encrypt(PublicParameters publicParameters, File file, AccessTree accessTree)
        {
            return new CiphertextPolicyEncryptedFile();
        }

        public CiphertextPolicySecretKey Keygen(IList<Attribute> attributes)
        {
            return new CiphertextPolicySecretKey();
        }

        public File Decrypt(PublicParameters publicParameters, CiphertextPolicyEncryptedFile encryptedFile, CiphertextPolicySecretKey secretKey)
        {
            return new File();
        }

        public CiphertextPolicySecretKey Delegate(CiphertextPolicySecretKey secretKey, IList<Attribute> attributes)
        {
            return Keygen(attributes);
        }
    }
}
