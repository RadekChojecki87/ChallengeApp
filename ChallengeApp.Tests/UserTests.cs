using ChallengeApp;

namespace ChallengeAppTests;

public class Tests
{
    [Test]

    public void WhenScoresAdded_ShouldBeResult()
    {
        //Arrange
        var employee1 = new Employee("Wiktor", "Gracz", 13);
        employee1.AddScore(5);
        employee1.AddScore(4);
        employee1.AddScore(9);

        //Act
        var result = employee1.Result;

        //Assert
        Assert.AreEqual(18, result);

    }
}
    
