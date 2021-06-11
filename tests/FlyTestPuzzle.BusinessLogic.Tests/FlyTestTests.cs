using FlyTestPuzzle.BusinessLogic.Tests.Logging;
using Xunit;
using static FlyTestPuzzle.BusinessLogic.Tests.Logging.TestConsole;

namespace FlyTestPuzzle.BusinessLogic.Tests
{
	public class FlyTestTests
	{
		[Theory]
		[ClassData(typeof(TestConsoleOrNull))]
		public void ShouldRun(TestConsole console)
		{
			var flyTest = new FlyTest(console);

			flyTest.Run();

			if (console is not null)
			{
				Assert.Equal("212\n844\n1688\n6752\n13504\n27008\n1696\n",
					console.CurrentOutput);
			}
		}
	}
}
