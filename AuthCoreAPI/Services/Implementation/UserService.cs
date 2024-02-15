using AuthCoreAPI.Model;
using AuthCoreAPI.Repository.Interface;
using AuthCoreAPI.Services.Interface;
using AutoMapper;

namespace AuthCoreAPI.Services.Implementation
{
    //Class for business rule
    public class UserService : IUserService
    {

        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserDTO> Create(UserDTO userDTO)
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
