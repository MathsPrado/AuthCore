namespace AuthCoreAPI.Model
{
    public class UserDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string email { get; set; }
    }
}
