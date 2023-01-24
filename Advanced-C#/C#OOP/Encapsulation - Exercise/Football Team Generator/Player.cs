namespace Football_Team_Generator
{
    using System;

    public class Player
    {
		private string name;

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			this.Name = name;

			this.Stats = new Stats(endurance, sprint, dribble, passing, shooting);
		}

		public string Name
		{
			get { return this.name; }
			private set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException(ExceptionMessages.NAME_CANNOT_BE_NULL_OR_WHITE_SPACE);
				
				
				this.name = value; 
			}
		}

		public Stats Stats { get; private set; }

		public double OverallRating =>
			(this.Stats.Endurance + this.Stats.Sprint + this.Stats.Dribble + this.Stats.Passing + this.Stats.Shooting) / 5.0;
	}
}