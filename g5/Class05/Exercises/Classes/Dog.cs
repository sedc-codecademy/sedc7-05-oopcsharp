namespace Exercises.Classes
{
    public class Dog
	{
		public string Name { get; set; }
		public string Race { get; set; }
		public string Color { get; set; }

		public string Eat()
		{
			return $"{Name} is eating";
		}

		public string Play()
		{
			return $"{Name} is playing";
		}

		public string ChaseTail()
		{
			return $"{Name} is now chasing it's tail";
		}
	}
}