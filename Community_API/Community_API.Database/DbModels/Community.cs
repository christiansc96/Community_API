using System.ComponentModel.DataAnnotations;

namespace Community_API.Database.DbModels
{
    public class Community
    {
        [Key]
        public int CommunityId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(100, ErrorMessage = "Only 100 characters accepted")]
        public string CommunityName { get; set; }
    }
}