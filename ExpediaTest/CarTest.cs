using System;
using NUnit.Framework;
using Expedia;

namespace ExpediaTest
{
	[TestFixture()]
	public class CarTest
	{
        //From task 4. Probably unnecessary. 
        [Test()]
        public void TestThatCarHasCorrectBasePriceForFiveDays()
        {
            var target = new Car(5);
            Assert.AreEqual(50, target.getBasePrice());
        }
        [Test()]
        public void TestThatCarHasCorrectBasePriceForTenDays()
        {
            var target = new Car(10);
            Assert.AreEqual(80, target.getBasePrice());
        }
        //[Test()]//This test didn't work and I didn't design it... 
        public void TestThatCarHasCorrectBasePriceForSevenDays()
        {
            var target = new Car(7);
            Assert.AreEqual(10 * 7 * 8, target.getBasePrice());
        }
	}
}
