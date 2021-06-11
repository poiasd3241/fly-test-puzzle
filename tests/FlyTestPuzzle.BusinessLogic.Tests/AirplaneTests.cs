using Xunit;

namespace FlyTestPuzzle.BusinessLogic.Tests
{
	public class AirplaneTests
	{
		[Fact]
		public void ShouldCreateAirplane()
		{
			var airplane = new Airplane();

			Assert.Equal(0, airplane.GetSpeed());
		}

		[Fact]
		public void ShouldSetSpeed()
		{
			var airplane = new Airplane();
			airplane.SetSpeed(222);

			Assert.Equal(222, airplane.GetSpeed());
		}
	}
}
