namespace MyFluentMaui
{
    public class Contact
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string FullName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Company { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Category { get; set; }
        public string? Notes { get; set; }
    }
}
