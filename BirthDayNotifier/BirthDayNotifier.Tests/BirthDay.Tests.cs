namespace BirthDayNotifier.Tests;

public class BirthDayTests
{
    [Fact]
    public void Amghezi()
    {
        // birthDay1.Day = 16;
        // birthDay1.Month = 5;
        // birthDay1.Year = 1371;

        // Arrange for 2 person
        Person person1 = new Person();

        person1.FirstName = "Mohammad";
        person1.LastName = "Fallahi";
        person1.BirthDay = new BirthDay()
        {
            Day = 16,
            Month = 5,
            Year = 1371
        };

        // Act
        

        // Assert
    }
}
