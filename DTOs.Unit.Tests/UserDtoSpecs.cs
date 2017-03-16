using System;
using System.Collections.Generic;
using DTOs.UserAttributes;
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
                UserAttributes = new List<IUserAttribute>
                {
                    new BirthdayAttribute
                    {
                        Name = "BirthDay",
                        Value = new DateTime(1992,7,2)
                    },
                    new CountryAttribute
                    {
                        Name = "Country",
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
            Assert.AreEqual(new DateTime(1992, 7, 2), Dto.UserAttributes[0].GetValue);
            Assert.AreEqual("Romania", Dto.UserAttributes[1].GetValue);
        }
    }
}
