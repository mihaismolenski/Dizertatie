using System.Collections.Generic;

namespace ABE.Models.Gates
{
    public class Gate : INode
    {
        public IList<INode> ChildNodes;
    }
}
