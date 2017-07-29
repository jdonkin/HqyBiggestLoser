using System.ComponentModel.DataAnnotations.Schema;

namespace BiggestLoserEF.Models
{
    public class TeamPoints
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeamPointsId { get; set; }
        public int TeamId { get; set; }
        public decimal Points { get; set; }
    }
}
