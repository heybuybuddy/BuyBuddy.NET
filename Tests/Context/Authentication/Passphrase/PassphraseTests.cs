using BuyBuddy.Context.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BuyBuddyTests.Context.Authentication {
    [TestClass]
    public class PassphraseTests {
        public static readonly int Id = 1837;
        public static readonly string Passkey = "u95OMxjDnbT4WisZP3D4Smwn6CpQhWMFZkXE98meN0ALh4xRIFNqnokruToTaww9RZg1TrZ6zh1EkOxRleqMuVk2";
        public static readonly string ShortPasskey = "short";
        public static readonly string LongPasskey = "u95OMxjDnbT4WisZP3D4Smwn6CpQhWMFZkXE98meN0ALh4xRIFNqnokruToTaww9RZg1TrZ6zh1EkOxRleqMuVk2long";
        public static readonly string IncorrectPasskey = "u95OMxjDnbT4WisZP3D4Smwn6CpQhWMFZkXE98meN0AL.4xRIFNqnokruToTaww9RZg1TrZ6zh1EkOxRleqMuVk2";

        [TestMethod]
        public void TestWithValidParameters() {
            var pass = new Passphrase(Id, Passkey, DateTime.Now, null);

            Assert.IsNotNull(pass);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter should be alphanumeric and exactly 88 characters long.")]
        public void TestFailsWithShortPasskey() {
            new Passphrase(Id, ShortPasskey, DateTime.Now, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter should be alphanumeric and exactly 88 characters long.")]
        public void TestFailsWithLongPasskey() {
            new Passphrase(Id, LongPasskey, DateTime.Now, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Parameter should be alphanumeric and exactly 88 characters long.")]
        public void TestFailsWithIncorrectPasskey() {
            new Passphrase(Id, IncorrectPasskey, DateTime.Now, null);
        }
    }
}
