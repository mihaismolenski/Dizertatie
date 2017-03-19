using System.Collections.Generic;
using ABE.Models.CPABE;
using ABE.Models.Interfaces;
using DTOs.Files;

namespace ABE.Models.KPABE
{
    public class KeyPolicyAttributeBasedEncryption : AttributeBasedEncryption
    {
        public IList<KeyPolicyEncryptedFile> EncryptedFiles;

        private SecurityParameter _securityParameter;
        private MasterKey _masterKey;

        public SetupResult Setup()
        {
            return new SetupResult();
        }

        public IEncryptedFile Encrypt(PublicParameters publicParameters, FileDto file, IList<Attribute> attributes)
        {
            return new KeyPolicyEncryptedFile();
        }

        public ISecretKey Keygen(MasterKey masterKey, AccessTree accessTree)
        {
            return new KeyPolicySecretKey();
        }

        public FileDto Decrypt(PublicParameters publicParameters, KeyPolicyEncryptedFile encryptedFile, KeyPolicySecretKey secretKey)
        {
            return new FileDto();
        }
    }
}
