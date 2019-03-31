using EncryptionAlgorithms;
using System;

namespace UnitTests
{
    public class VigenereTest
    {
        public void Vigenere_EncryptTest()
        {
            //Arrange
            SecurityAlgorithm target = new Vigenere("lemon");
            string plain = "attackatdawn";
            string cypher = "lxfopvefrnhr";

            //Act
            string actual = target.Encrypt(plain);

            //Assert
        }

        public void Vigenere_DecryptTest()
        {
            //Arrange
            SecurityAlgorithm target = new Vigenere("lemon");
            string plain = "attackatdawn";
            string cypher = "lxfopvefrnhr";

            //Act
            string actual = target.Decrypt(cypher);

            //Assert
        }
    }
}
