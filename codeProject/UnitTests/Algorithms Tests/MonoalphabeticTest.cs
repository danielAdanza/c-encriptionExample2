using EncryptionAlgorithms;
using System;

namespace UnitTests
{
    public class MonoalphabeticTest
    {
        readonly SecurityAlgorithm _target = new Monoalphabetic();

        public void Monoalphabetic_EncryptTest()
        {
            //Arrange
            string plain = "abcd";

            //Act
            string cypher = _target.Encrypt(plain);

            //Act
            string actual = _target.Decrypt(cypher);
        }
    }
}
