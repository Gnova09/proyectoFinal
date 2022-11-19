namespace RYSE.WEB.Models
{
    public abstract class Person:BaseEnity
    {
        public int PersonId { get; set; }


        public string? FirstName { get; set; }


        public string? LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public string? Discreminator { get; set; }

    }
}
