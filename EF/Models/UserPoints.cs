using System.ComponentModel.DataAnnotations.Schema;

namespace BiggestLoserEF.Models
{
    public class UserPoints
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserPointsId { get; set; }
        public int UserId { get; set; }
        public decimal Points { get; set; }
    }
}
