namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinOfGrades_ShouldReturnCorrectMinResult()
        {
            //arrange
            var employee1 = new Employee("Jagoda", "Kot");
            employee1.AddGrade(2);
            employee1.AddGrade(4);
            employee1.AddGrade(6);

            //act
            var statistics = employee1.GetStatistics();
            

            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void MaxOfGrades_ShouldReturnCorrectMaxResult()
        {
            //arrange
            var employee2 = new Employee("Wiktor", "Pływak");
            employee2.AddGrade(8);
            employee2.AddGrade(6);
            employee2.AddGrade(7);

            //act
            var statistics = employee2.GetStatistics();
            
            //assert
            Assert.AreEqual(8, statistics.Max);
           
        }
        [Test]
        public void AverageOfGrades_ShouldReturnCorrectAverageResult() 
        {
            // arrange
            var employee2 = new Employee("Wiktor", "Pływak");
            employee2.AddGrade(8);
            employee2.AddGrade(6);
            employee2.AddGrade(7);

            // act
            var statistics = employee2.GetStatistics();
           

            // assert
            Assert.AreEqual(Math.Round(7.00, 2), Math.Round(statistics.Average, 2));
            
        }
    }
}
