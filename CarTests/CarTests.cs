using Car;
namespace CarTests;

[TestClass]
public class CarTests
{
    [TestMethod]
    public void EmptyTest() => Assert.AreEqual(10, 10, .001);

    Car.Car test_car;

    [TestInitialize]
    public void CreateCarObject()
    {
        test_car = new Car.Car("Toyota", "Prius", 10, 50);
    }

    //TODO: constructor sets gasTankLevel properly
    [TestMethod]
    public void TestInitialGasTank()
    {
        Assert.AreEqual(10, test_car.GasTankLevel, .001);
    }

    //TODO: gasTankLevel is accurate after driving within tank range
    [TestMethod]
    public void TestGasTankAfterDriveWithinRange()
    {
        test_car.Drive(50);
        Assert.AreEqual(9, test_car.GasTankLevel, .001);
    }
    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    [TestMethod]
    public void TestAttemptDrivePastRange()
    {
        test_car.Drive(50000);
        Assert.AreEqual(0, test_car.GasTankLevel, .001);
        Assert.AreEqual(500, test_car.Odometer, .001);
    }
    //TODO: can't have more gas than tank size, expect an exception
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestGasOverfillException()
    {
        test_car.AddGas(50);
        Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank.");
    }
}
