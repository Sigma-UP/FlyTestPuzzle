namespace FlyTestPuzzle.BusinessLogic.Planes
{
	public class Airplane
	{
		public static int Multiplier = 1;
		private int _speed;

		public int GetSpeed() => _speed;
		public virtual void SetSpeed(int speed)
		{
			_speed = speed;
		}
	}
}