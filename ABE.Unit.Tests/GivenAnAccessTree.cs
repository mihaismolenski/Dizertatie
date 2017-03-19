using System.Collections.Generic;
using ABE.Models;
using ABE.Models.Gates;
using NUnit.Framework;

namespace ABE.Unit.Tests
{
    [TestFixture]
    public class GivenAnAccessTree
    {
        protected AccessTree AccessTree;

        [OneTimeSetUp]
        public void SetUp()
        {
            AccessTree = new AccessTree
            {
                RootNode = new OrGate
                {
                    ChildNodes = new List<INode>
                    {
                        new AndGate
                        {
                            ChildNodes = new List<INode>
                            {
                                new Attribute
                                {
                                    Value = "Computer Science"
                                },
                                new Attribute
                                {
                                    Value = "Admission-committee"
                                }
                            }
                        },
                        new Attribute
                        {
                            Value = "Dean"
                        },
                        new SubsetGate
                        {
                            ChildNodes = new List<INode>
                            {
                                new Attribute
                                {
                                    Value = "Computer Science"
                                },
                                new Attribute
                                {
                                    Value = "Admission-committee"
                                },
                                new Attribute
                                {
                                    Value = "Faculty"
                                }
                            }
                        }
                    }
                }
            };
        }

        [Test]
        public void Then_should_have_root_node()
        {
            Assert.IsTrue(AccessTree.RootNode is OrGate);
        }

        [Test]
        public void Then_should_have_child_nodes_of_rank_one()
        {
            Assert.IsTrue(AccessTree.RootNode.ChildNodes[0] is AndGate);
            Assert.IsTrue(AccessTree.RootNode.ChildNodes[1] is Attribute);
            Assert.IsTrue(AccessTree.RootNode.ChildNodes[2] is SubsetGate);

            Assert.AreEqual("Dean", ((Attribute)AccessTree.RootNode.ChildNodes[1]).Value);
        }

        [Test]
        public void Then_should_have_child_nodes_of_rank_two()
        {
            Assert.IsTrue(((AndGate)AccessTree.RootNode.ChildNodes[0]).ChildNodes[0] is Attribute);
            Assert.IsTrue(((AndGate)AccessTree.RootNode.ChildNodes[0]).ChildNodes[1] is Attribute);

            Assert.AreEqual("Computer Science", ((Attribute)((AndGate)AccessTree.RootNode.ChildNodes[0]).ChildNodes[0]).Value);
            Assert.AreEqual("Admission-committee", ((Attribute)((AndGate)AccessTree.RootNode.ChildNodes[0]).ChildNodes[1]).Value);
            Assert.AreEqual("Computer Science", ((Attribute)((SubsetGate)AccessTree.RootNode.ChildNodes[2]).ChildNodes[0]).Value);
            Assert.AreEqual("Admission-committee", ((Attribute)((SubsetGate)AccessTree.RootNode.ChildNodes[2]).ChildNodes[1]).Value);
            Assert.AreEqual("Faculty", ((Attribute)((SubsetGate)AccessTree.RootNode.ChildNodes[2]).ChildNodes[2]).Value);
        }
    }
}
