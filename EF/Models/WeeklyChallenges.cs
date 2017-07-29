using System.ComponentModel.DataAnnotations.Schema;

namespace BiggestLoserEF.Models
{
    public class WeeklyChallenges
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string ChallengeName { get; set; }
        public int WeekId { get; set; }
    }
}
