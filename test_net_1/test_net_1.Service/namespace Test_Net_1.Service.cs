using Test_Net_1.DTO.Testing;
using Test_Net_1.DataAccess;
using System.Collections.Generic;

namespace Test_Net_1.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService() 
        {
            _userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUser(int id) 
        {
            return _userRepository.GetUser(id);
        }

        public void AddUser(User user) 
        {
            _userRepository.AddUser(user);
        }

        public void UpdateUser(User user) 
        {
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id) 
        {
            _userRepository.DeleteUser(id);
        }
    }
}