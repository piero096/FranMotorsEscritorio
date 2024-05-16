namespace Common.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? LoginName { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? Email { get; set; }
        public bool? Estado { get; set; }
    }
}
