using System.ComponentModel.DataAnnotations;

namespace StaffPortal.Models
{
    public class Staff
    {
        [Key]
        public string IndexNumber { get; set; }

        [Required]
        public string FullNames { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string CurrentLocation { get; set; }

        public string HighestLevelOfEducation { get; set; }

        public string DutyStation { get; set; }

        public bool AvailabilityForRemoteWork { get; set; }

        public string SoftwareExpertise { get; set; }

        public string SoftwareExpertiseLevel { get; set; }

        public string Language { get; set; }

        public string LevelOfResponsibility { get; set; }

    }
}
