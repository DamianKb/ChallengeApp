using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {


        [Test]
        public void WhenUserCollectTwoScore_SholdCorrectReslt()
        {
            var user = new Employee("Damian", "Nowak", "27");

            user.AddScore(5);
            user.AddScore(6);

            var result = user.Result;

            Assert.AreEqual(11, result);

        }
        [Test]
        public void WhenUserCollectTwoScore_SholdCorrectReslt1()
        {
            var user = new Employee("Damian", "Nowak", "27");

            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-11);
            var result1 = user.Result;

            Assert.AreEqual(0, result1);

        }
        [Test]
        public void WhenUserCollectTwoScore_SholdCorrectReslt2()
        {
            var user = new Employee("Damian", "Nowak", "27");

            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-10);
            var result = user.Result;

            Assert.AreEqual(1, result);

        }
    }
}