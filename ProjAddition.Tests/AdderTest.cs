
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
        sum = objectAdder.Sum(2, 2);
        //assert
        Assert.Equal(4, sum);

    }
     [Fact]
    public void CheckIfFourPlusFourEqualsEightTest()
    {
        //arrange
        int sum;
        Adder objectAdder = new Adder();
        //act
        sum = objectAdder.Sum(4, 4);
        //assert
        Assert.Equal(8, sum);

    }
    [Fact]
    public void CheckIfEightPlusFiveEqualsThirteenTest()
    {
        //arrange
        int sum;
        Adder objectAdder = new Adder();
        //act
        sum = objectAdder.Sum(8, 5);
        //assert
        Assert.Equal(13, sum);

    }
    
}