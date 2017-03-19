using System.Collections.Generic;
using ABE.Models.Interfaces;
using DTOs.Files;

namespace ABE.Models.CPABE
{
    public class CiphertextPolicyAttributeBasedEncryption : AttributeBasedEncryption
    {
        public IList<CiphertextPolicyEncryptedFile> EncryptedFiles;
        private SecurityParameter _securityParameter;
        private MasterKey _masterKey;

        public SetupResult Setup()
        {
            return new SetupResult();
        }

        public IEncryptedFile Encrypt(PublicParameters publicParameters, FileDto file, AccessTree accessTree)
        {
            return new CiphertextPolicyEncryptedFile();
        }

        public ISecretKey Keygen(MasterKey masterKey, IList<Attribute> attributes)
        {
            return new CiphertextPolicySecretKey();
        }

        public FileDto Decrypt(PublicParameters publicParameters, CiphertextPolicyEncryptedFile encryptedFile, CiphertextPolicySecretKey secretKey)
        {
            return new FileDto();
        }

        public ISecretKey Delegate(CiphertextPolicySecretKey secretKey, IList<Attribute> attributes)
        {
            return Keygen(_masterKey, attributes);
        }
    }
}
