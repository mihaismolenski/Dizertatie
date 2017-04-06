using System;
using System.Collections.Generic;
using DTOs.Attributes;
using DTOs.Users;
using NUnit.Framework;

namespace DTOs.Unit.Tests
{
    [TestFixture]
    public class UserDtoSpecs
    {
        protected UserDto Dto;

        [OneTimeSetUp]
        public void SetUp()
        {
            Dto = new UserDto
            {
                FirstName = "Mihai",
                LastName = "Smolenschi",
                UserId = 1,
                UserAttributes = new List<UserAttributeDto>
                {
                    new UserAttributeDto
                    {
                        Id = 1,
                        Value = "1992,7,2"
                    },
                    new UserAttributeDto
                    {
                        Id = 1,
                        Value = "Romania"
                    }
                }
            };
        }

        [Test]
        public void Should_set_first_name()
        {
            Assert.AreEqual("Mihai", Dto.FirstName);
        }

        [Test]
        public void Should_set_last_name()
        {
            Assert.AreEqual("Smolenschi", Dto.LastName);
        }

        [Test]
        public void Should_set_id()
        {
            Assert.AreEqual(1, Dto.UserId);
        }

        [Test]
        public void Should_set_user_attributes()
        {
            Assert.AreEqual("1992,7,2", Dto.UserAttributes[0].Value);
            Assert.AreEqual("Romania", Dto.UserAttributes[1].Value);
        }
    }
}
