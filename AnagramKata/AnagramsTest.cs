using System.Collections.Generic;
using NUnit.Framework;

namespace Anagrams
{
    [TestFixture]
    public class AnagramTests
    {
        [Test]
        public void NoCharacters()
        {
            var expected = new List<string> { "" };
            Assert.That(Anagrams.Of(""), Is.EqualTo(expected));
        }
        [Test]
        public void OneCharacter()
        {
            var expected = new List<string> { "A" };
            Assert.That(Anagrams.Of("A"), Is.EqualTo(expected));
        }
        [Test]
        public void TwoCharacters()
        {
            var expected = new List<string> { "AB", "BA" };
            Assert.That(Anagrams.Of("AB"), Is.EqualTo(expected));
        }
        [Test]
        public void ThreeCharacters()
        {
            var expected = new List<string> { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
            Assert.That(Anagrams.Of("ABC"), Is.EqualTo(expected));
        }

        [Test]
        public void CountOfAnagramsOfFourCharacters()
        {
            Assert.That(Anagrams.Of("ABCD").Count, Is.EqualTo(24));
        }
    }
}