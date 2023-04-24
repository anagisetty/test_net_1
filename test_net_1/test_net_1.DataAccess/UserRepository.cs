using Test_Net_1.DTO.Testing;
using System.Collections.Generic;

namespace Test_Net_1
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            // SELECT * FROM Users
            List<User> users = new List<User>();
            // retrieve data from database
            return users;
        }

        public User GetUser(int id)
        {
            // SELECT * FROM Users WHERE Id = @id
            User user = new User();
            // retrieve data from database
            return user;
        }

        public void AddUser(User user)
        {
            // INSERT INTO Users (Username, Password, Email, Roles, Phone) VALUES (@Username, @Password, @Email, @Roles, @Phone)
            // execute query with user object
        }

        public void UpdateUser(User user)
        {
            // UPDATE Users SET Username = @Username, Password = @Password, Email = @Email, Roles = @Roles, Phone = @Phone WHERE Id = @Id
            // execute query with user object
        }

        public void DeleteUser(int id)
        {
            // DELETE FROM Users WHERE Id = @id
            // execute query with user object
        }
    }
}