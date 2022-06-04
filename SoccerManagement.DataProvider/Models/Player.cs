namespace SoccerManagement.DataProvider.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int GoalsNumber { get; set; }
        public Team Team { get; set; }
    }
}