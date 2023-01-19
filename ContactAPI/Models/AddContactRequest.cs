namespace ContactAPI.Models
{
    public class AddContactRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public long Phone { get; set; }
        public string? Address { get; set; }
    }

    public class UpdateContactRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public long Phone { get; set; }
        public string? Address { get; set; }
    }
}
