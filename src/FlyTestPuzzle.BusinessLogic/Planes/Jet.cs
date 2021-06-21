namespace FlyTestPuzzle.BusinessLogic.Planes
{
	public class Jet : Airplane
	{
		public const int Multiplier = 2;

		public override void SetSpeed(int speed)
		{
			base.SetSpeed(speed * Multiplier);
		}
		public void Accelerate()
		{
			base.SetSpeed(GetSpeed() * Multiplier);
		}
	}
}