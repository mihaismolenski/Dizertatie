using System.Collections.Generic;
using ABE.Models;
using ABE.Models.KPABE;
using DTOs.Files;
using NUnit.Framework;

namespace ABE.Unit.Tests
{
    [TestFixture]
    public class GivenAKeyPolicyAbe
    {
        protected KeyPolicyAttributeBasedEncryption Kpabe;
        protected PublicParameters PublicParameters;

        [OneTimeSetUp]
        public void Setup()
        {
            Kpabe = new KeyPolicyAttributeBasedEncryption();
            PublicParameters = Kpabe.Setup();
        }

        [Test]
        public void Should_return_setup_result()
        {
            Assert.IsNotNull(PublicParameters);
        }

        [Test]
        public void Should_generate_key()
        {
            var key = Kpabe.Keygen(new AccessTree());
            Assert.IsNotNull(key);
            Assert.IsTrue(key is KeyPolicySecretKey);
        }

        [Test]
        public void Should_encrypt_file()
        {
            var file = Kpabe.Encrypt(PublicParameters, new File(), new List<Attribute>());
            Assert.IsNotNull(file);
            Assert.IsTrue(file is KeyPolicyEncryptedFile);
        }

        [Test]
        public void Should_decrypt_file()
        {
            var file = Kpabe.Decrypt(PublicParameters, new KeyPolicyEncryptedFile(), new KeyPolicySecretKey());
            Assert.IsNotNull(file);
        }
    }
}
