using AuthCoreAPI.Model;

namespace AuthCoreAPI.Repository.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDTO> FindById(int id);
        Task<UserDTO> Create(UserDTO userDTO);
        Task Create(User user);
    }
}
