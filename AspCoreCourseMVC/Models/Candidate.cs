namespace AspCoreCourseMVC.Models
{
    public class Candidate
    {
        public string? Email { get; set; } = String.Empty;
        public string? FirstName { get; set; } = String.Empty;
        public string? LastName { get; set; } = String.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelecetedCourse { get; set; } = String.Empty;
        public DateTime Apply { get; set; }

        public Candidate()
        {
            Apply = DateTime.Now;
        }
    }
}
