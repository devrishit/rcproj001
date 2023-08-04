
namespace ProjAddition.Tests;

public class AdderTest
{
    [Fact]
    public void CheckIfTwoPlusTwoEqualsFourTest()
    {
        //arrange
        int sum;
        Adder objectAdder = new Adder();
        //act
        sum = objectAdder.Sum();
        //assert
        Assert.Equal(4, sum);

    }
}