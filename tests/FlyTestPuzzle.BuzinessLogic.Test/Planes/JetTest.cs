﻿using Xunit;
using FlyTestPuzzle.BusinessLogic.Planes;

namespace FlyTestPuzzle.Tests
{
    public class JetTest
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            var jet = new Jet();
        }

        [Fact]
        public void ShouldBeAbleToSetAndGetSpeed()
        {
            var jet = new Jet();
            jet.SetSpeed(200);
            int speed = jet.GetSpeed();

            Assert.Equal(400, speed);
        }

        [Fact]
        public void ShouldHaveMultiplierEquals2ByDefault()
        {
            var jet = new Jet();

            Assert.Equal(2, Jet.Multiplier);
        }

        [Fact]
        public void ShouldBeAbleToAccelerate()
        {
            var jet = new Jet();
            jet.SetSpeed(200);

            Assert.Equal(400, jet.GetSpeed());

            jet.Accelerate();

            Assert.Equal(800, jet.GetSpeed());
        }
    }
}
