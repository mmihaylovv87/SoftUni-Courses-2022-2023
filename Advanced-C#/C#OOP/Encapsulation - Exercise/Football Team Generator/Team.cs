namespace Football_Team_Generator
{
    using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml.Schema;

	public class Team
    {
		private string name;
		private List<Player> playerList;

		private Team()
		{
			this.playerList = new List<Player>();
		}

		public Team(string name) : this()
		{
			this.Name = name;
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

		public int Rating => this.playerList.Count > 0 ? (int)Math.Round(this.playerList.Average(p => p.OverallRating), 0) : 0;

		public void AddPlayer(Player player)
		{
			this.playerList.Add(player);
		}

		public void RemovePLayer(string playerName)
		{
			Player playerToRemove = this.playerList.FirstOrDefault(p => p.Name == playerName);
			if (playerToRemove == null)
				throw new InvalidOperationException(string.Format(ExceptionMessages.MISSING_PLAYER_MESSAGE, playerName, this.Name));

			this.playerList.Remove(playerToRemove);
		}

		public override string ToString()
		{
			return $"{this.Name} - {this.Rating}";
		} 
	}
}