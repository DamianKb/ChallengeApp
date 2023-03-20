namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void ComparisonOfIntNumbersValueType()
        {
            int number1 = 10;
            int number2 = 20;


            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void ComparisonOfFloatNumbersValueType()
        {
            float number1 = 1.2F;
            float number2 = 2.1F;


            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void NameComparisonValueType()
        {
            string user1 = "Damian";
            string user2 = "Damian";
                

            Assert.AreEqual(user1, user2);

        }

        [Test]
        public void ComparisonUserReferenceType()
        {
            var user1 = GetEmployee("Damian");
            var user2 = GetEmployee("Damian");



            Assert.AreEqual(user1.Name, user2.Name);

        }
        private Employee GetEmployee(string name)
        {
            return new Employee("Damian", "Nowak", "27");
        }
    }
}





