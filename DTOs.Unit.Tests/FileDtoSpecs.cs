using System;
using DTOs.Files;
using NUnit.Framework;

namespace DTOs.Unit.Tests
{
    [TestFixture]
    public class FileDtoSpecs
    {
        protected FileDto Dto;

        [OneTimeSetUp]
        public void SetUp()
        {
            Dto = new FileDto
            {
                Name = "File1.txt",
                Id = 2,
                CreatedDate = new DateTime(2017,3,3)
            };
        }

        [Test]
        public void Should_set_file_name()
        {
            Assert.AreEqual("File1.txt", Dto.Name);
        }

        [Test]
        public void Should_set_file_id()
        {
            Assert.AreEqual(2, Dto.Id);
        }

        [Test]
        public void Should_set_created_date()
        {
            Assert.AreEqual(new DateTime(2017, 3, 3), Dto.CreatedDate);
        }
    }
}
