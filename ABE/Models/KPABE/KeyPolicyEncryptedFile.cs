using System.Collections.Generic;
using DTOs.Files;

namespace ABE.Models.KPABE
{
    public class KeyPolicyEncryptedFile
    {
        public FileDto File;
        public IList<Attribute> Attributes;
    }
}
