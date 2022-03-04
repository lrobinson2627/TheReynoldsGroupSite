using System.ComponentModel.DataAnnotations;

namespace TheReynoldsGroupSite.Data
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        public string ClientFirstName { get; set; }

        public string ClientLastName { get; set; }



        public string AssignedTo { get; set; }

    }
}
