using System.ComponentModel.DataAnnotations.Schema;

namespace BiggestLoserEF.Models
{
    public class WeeklyIndividualPoints
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int WeekId { get; set; }
        public int UserId { get; set; }
        public decimal TeamPoints { get; set; }
    }
}
