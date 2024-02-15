using AuthCoreAPI.Model;

namespace AuthCoreAPI.Services.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserDTO> FindById(int id);
        Task<UserDTO> Create(UserDTO userDTO);
    }
}
