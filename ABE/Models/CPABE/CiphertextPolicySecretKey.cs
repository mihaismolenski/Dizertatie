using System.Collections.Generic;
using ABE.Models.Interfaces;

namespace ABE.Models.CPABE
{
    public class CiphertextPolicySecretKey : ISecretKey
    {
        public IList<Attribute> Attributes;
    }
}
