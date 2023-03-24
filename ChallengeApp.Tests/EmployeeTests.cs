namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void MinOfGrades_ShouldReturnCorrectMinResult()
        {
            //arrange
            var employee = new Employee("Radek", "Chojecki");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();
            

            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void MaxOfGrades_ShouldReturnCorrectMaxResult()
        {
            //arrange
            var employee = new Employee("Radek", "Chojecki");
            employee.AddGrade(8);
            employee.AddGrade(6);
            employee.AddGrade(7);

            //act
            var statistics = employee.GetStatistics();
            
            //assert
            Assert.AreEqual(8, statistics.Max);
           
        }
        [Test]
        public void AverageOfGrades_ShouldReturnCorrectAverageResult() 
        {
            // arrange
            var employee = new Employee("Radek", "Chojecki");
            employee.AddGrade(8);
            employee.AddGrade(6);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();
           

            // assert
            Assert.AreEqual(Math.Round(7.00, 2), Math.Round(statistics.Average, 2));
            
        }
        [Test]
        public void AddGradeChar()
        {
            var employee = new Employee("Radek", "Chojecki");
            employee.AddGrade('A');
            employee.AddGrade('c');

            var statistics = employee.GetStatistics();

            var average = employee.GetStatistics().AverageLetter;

            Assert.AreEqual('A', average);
        }
    }  
}
