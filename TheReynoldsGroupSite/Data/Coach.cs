using System.ComponentModel.DataAnnotations;

namespace TheReynoldsGroupSite.Data
{
    public class Coach
    {
        [Key]
        public int CoachId { get; set; }
        public string CoachFirstName { get; set; }
        public string CoachLastName { get; set; }
        public int CoachType { get; set; }
        public int Id { get; internal set; }


    }
}
