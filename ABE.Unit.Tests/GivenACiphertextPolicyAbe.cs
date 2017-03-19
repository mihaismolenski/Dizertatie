using System.Collections.Generic;
using ABE.Models;
using ABE.Models.CPABE;
using ABE.Models.KPABE;
using DTOs.Files;
using NUnit.Framework;

namespace ABE.Unit.Tests
{
    [TestFixture]
    public class GivenACiphertextPolicyAbe
    {
        protected CiphertextPolicyAttributeBasedEncryption Cpabe;
        protected SetupResult SetupResult;

        [OneTimeSetUp]
        public void Setup()
        {
            Cpabe = new CiphertextPolicyAttributeBasedEncryption();
            SetupResult = Cpabe.Setup();
        }

        [Test]
        public void Should_return_setup_result()
        {
            Assert.IsNotNull(SetupResult);
        }

        [Test]
        public void Should_generate_key()
        {
            var key = Cpabe.Keygen(SetupResult.MasterKey, new List<Attribute>());
            Assert.IsNotNull(key);
            Assert.IsTrue(key is CiphertextPolicySecretKey);
        }

        [Test]
        public void Should_encrypt_file()
        {
            var file = Cpabe.Encrypt(SetupResult.PublicParameters, new FileDto(), new AccessTree());
            Assert.IsNotNull(file);
            Assert.IsTrue(file is CiphertextPolicyEncryptedFile);
        }

        [Test]
        public void Should_decrypt_file()
        {
            var file = Cpabe.Decrypt(SetupResult.PublicParameters, new CiphertextPolicyEncryptedFile(), new CiphertextPolicySecretKey());
            Assert.IsNotNull(file);
        }
    }
}
