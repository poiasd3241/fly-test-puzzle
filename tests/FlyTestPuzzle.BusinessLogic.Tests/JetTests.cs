using Xunit;

namespace FlyTestPuzzle.BusinessLogic.Tests
{
	public class JetTests
	{
		[Fact]
		public void ShouldCreateJet()
		{
			var jet = new Jet();

			Assert.Equal(0, jet.GetSpeed());
		}


		[Fact]
		public void ShouldSetSpeed()
		{
			var jet = new Jet();
			jet.SetSpeed(222);

			Assert.Equal(444, jet.GetSpeed());
		}

		[Fact]
		public void ShouldAccelerate()
		{
			var jet = new Jet();
			jet.SetSpeed(222);
			jet.Accelerate();

			Assert.Equal(888, jet.GetSpeed());
		}
	}
}
