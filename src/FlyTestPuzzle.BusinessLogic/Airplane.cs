namespace FlyTestPuzzle.BusinessLogic
{
	public class Airplane
	{
		private int _speed;

		public int GetSpeed() => _speed;
		public virtual void SetSpeed(int speed)
		{
			_speed = speed;
		}
	}
}
