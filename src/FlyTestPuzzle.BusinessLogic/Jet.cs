namespace FlyTestPuzzle.BusinessLogic
{
	public class Jet : Airplane
	{
		private const int _multiplier = 2;

		public override void SetSpeed(int speed)
		{
			base.SetSpeed(speed * _multiplier);
		}
		public void Accelerate()
		{
			base.SetSpeed(GetSpeed() * 2);
		}
	}
}
