using System.ComponentModel.DataAnnotations.Schema;

namespace BiggestLoserEF.Models
{
    public class WeeklyTeamPoints
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int WeekId { get; set; }
        public int TeamId { get; set; }
        public decimal TeamPoints { get; set; }
    }
}
