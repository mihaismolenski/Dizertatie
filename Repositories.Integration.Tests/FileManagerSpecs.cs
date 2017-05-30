using DTOs.FileAccessTrees;
using NUnit.Framework;
using Repositories.Managers.CpAbe;

namespace Repositories.Integration.Tests
{
    [TestFixture]
    public class FileManagerSpecs : BaseSpecs
    {
        private FileAccessTreeDto _accessTree;

        [OneTimeSetUp]
        public void SetUp()
        {
            _accessTree = new FileManager().GetAccessTreeByFileId(1);
        }

        [Test]
        public void Should_load_file()
        {
            Assert.IsNotNull(_accessTree.File);
        }

        [Test]
        public void Should_load_root_gate()
        {
            Assert.IsNotNull(_accessTree.Gate);
        }

        [Test]
        public void Should_have_two_child_nodes()
        {
            Assert.AreEqual(2, _accessTree.Children.Count);
        }

        [Test]
        public void Should_have_two_child_nodes_for_first_child()
        {
            Assert.AreEqual(2, _accessTree.Children[0].Children.Count);
        }

        [Test]
        public void Should_have_no_child_nodes()
        {
            Assert.AreEqual(0, _accessTree.Children[1].Children.Count);
        }
    }
}
