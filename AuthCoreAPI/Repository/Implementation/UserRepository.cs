using AuthCoreAPI.Model;
using AuthCoreAPI.Repository.Interface;

namespace AuthCoreAPI.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        public Task<UserDTO> Create(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
