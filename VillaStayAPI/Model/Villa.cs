using System.ComponentModel.DataAnnotations;

namespace VillaStayAPI.Model
{
    public class Villa
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
