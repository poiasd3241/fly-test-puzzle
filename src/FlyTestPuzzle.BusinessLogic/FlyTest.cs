using FlyTestPuzzle.BusinessLogic.Logging;

namespace FlyTestPuzzle.BusinessLogic
{
	public class FlyTest
	{
		private readonly IConsole _console;
		public FlyTest(IConsole console)
		{
			_console = console;
		}

		public void Run()
		{
			var biplane = new Airplane();
			biplane.SetSpeed(212);
			_console?.WriteLine(biplane.GetSpeed().ToString());

			var boeing = new Jet();
			boeing.SetSpeed(422);
			_console?.WriteLine(boeing.GetSpeed().ToString());

			int x = 0;
			while (x < 4)
			{
				boeing.Accelerate();
				_console?.WriteLine(boeing.GetSpeed().ToString());

				if (boeing.GetSpeed() > 5000)
				{
					biplane.SetSpeed(biplane.GetSpeed() * 2);
				}
				else
				{
					boeing.Accelerate();
				}

				x++;
			}
			_console?.WriteLine(biplane.GetSpeed().ToString());
		}
	}
}
