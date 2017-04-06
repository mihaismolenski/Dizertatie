using System.Collections.Generic;

namespace ABE.Models.KPABE
{
    public class KeyPolicyAttributeBasedEncryption : AttributeBasedEncryption
    {
        public PublicParameters Setup()
        {
            MasterKey = new MasterKey();
            return new PublicParameters();
        }

        public KeyPolicyEncryptedFile Encrypt(PublicParameters publicParameters, File file, IList<Attribute> attributes)
        {
            return new KeyPolicyEncryptedFile();
        }

        public KeyPolicySecretKey Keygen(AccessTree accessTree)
        {
            return new KeyPolicySecretKey();
        }

        public File Decrypt(PublicParameters publicParameters, KeyPolicyEncryptedFile encryptedFile, KeyPolicySecretKey secretKey)
        {
            return new File();
        }
    }
}
