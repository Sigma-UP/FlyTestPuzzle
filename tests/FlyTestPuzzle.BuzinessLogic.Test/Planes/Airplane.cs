using Xunit;
using FlyTestPuzzle.BusinessLogic.Planes;

namespace FlyTestPuzzle.Tests
{
    public class AirplaneTest
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            var airplane = new Airplane();
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetSpeed()
        {
            var airplane = new Airplane();
            airplane.SetSpeed(200);
            int speed = airplane.GetSpeed();

            Assert.Equal(200, speed);
        }

        [Fact]
        public void ShouldHaveMultiplierEquals1ByDefault()
        {
            var airplane = new Airplane();

            Assert.Equal(1, Airplane.Multiplier);
        }

    }
}
