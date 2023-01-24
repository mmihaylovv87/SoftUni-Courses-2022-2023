namespace Football_Team_Generator
{
    public static class ExceptionMessages
    {
        public const string NAME_CANNOT_BE_NULL_OR_WHITE_SPACE = 
            "A name shouold not be empty.";
        public const string INVALID_STAT_MESSAGE =
            "{0} should be between 0 and 100.";
        public const string MISSING_PLAYER_MESSAGE =
            "Player {0} is not in {1} team.";
        public const string INEXISTING_TEAM_MESSAGE =
            "Team {0} does not exist.";
    }
}