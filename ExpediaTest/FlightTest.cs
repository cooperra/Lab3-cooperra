using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
        //TODO Task 7 items go here
        private readonly DateTime StartDate = new DateTime(2011, 03, 14);
        private readonly DateTime EndDate = new DateTime(2011, 06, 28);
        private readonly int Miles = 5;
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(StartDate, EndDate, Miles);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDayTrip()
        {
            var target = new Flight(new DateTime(2011, 03, 14), new DateTime(2011, 03, 15), Miles);
            Assert.AreEqual(220, target.getBasePrice());
        }
        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDayTrip()
        {
            var target = new Flight(new DateTime(2011, 06, 28), new DateTime(2011, 06, 30), Miles);
            Assert.AreEqual(240, target.getBasePrice());
        }
        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDayTrip()
        {
            var target = new Flight(new DateTime(2011, 03, 14), new DateTime(2011, 03, 24), Miles);
            Assert.AreEqual(400, target.getBasePrice());
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadMiles()
        {
            new Flight(StartDate, EndDate, -Miles);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadDates()
        {
            new Flight(EndDate, StartDate, Miles);
        }
	}
}
