using System.Collections.Generic;
using ABE.Models.BaseModels;

namespace ABE.Models.KPABE
{
    public class KeyPolicyEncryptedFile : BaseEncryptedFile
    {
        public File File;
        public IList<Attribute> Attributes;
    }
}
