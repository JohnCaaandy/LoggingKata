using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LoggingKata.Test
{
    [TestFixture]
    public class TacoParserTestFixture
    {
        [Test]
        public void ShouldReturnNullForEmptyString()
        {
            // Arrange
            const string line = "";
            var parser = new TacoParser();

            // Act
            var result = parser.Parse(line);

            // Assert
            Assert.IsNull(result);
        }
        [Test]
        public void ShouldReturnNullForNullString()
        {
            // Arrange
            const string line = null;
            var parser = new TacoParser();

            // Act
            var result = parser.Parse(line);

            // Assert
            Assert.IsNull(result);
        }
        [Test]
        public void ShouldParseString()
        {
            // Arrange
            const string line = "-86.889051, Testing";
            var parser = new TacoParser();

            // Act
            var result = parser.Parse(line);

            // Assert
            Assert.IsNull(result);
        }
    }
}
