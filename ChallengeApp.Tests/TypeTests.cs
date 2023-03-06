namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]

        public void GetIntValues_ShouldReturnEquals()
        {
            int number1 = 1;
            int number2 = 1;

            Assert.AreEqual(number1, number2);
        }
        [Test]

        public void GetStringValues_ShouldReturnDifferent()
        {
            string name1 = "Radek";
            string name2 = "Radek";

            Assert.AreEqual(name1, name2);
        }
        [Test]

        public void GetFloatValues_ShouldReturnEquals()
        {
            float firstfloat = 4.5f;
            float secondfloat = 4.5f;
            Assert.AreEqual(firstfloat, secondfloat);
        }
    }

}
