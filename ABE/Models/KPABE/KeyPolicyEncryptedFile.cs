using System.Collections.Generic;
using ABE.Models.Interfaces;
using DTOs.Files;

namespace ABE.Models.KPABE
{
    public class KeyPolicyEncryptedFile : IEncryptedFile
    {
        public FileDto File;
        public IList<Attribute> Attributes;
    }
}
