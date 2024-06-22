
 using ILakshya.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILakshya.Dal
{
    public class AuthenticationRepository : IAuthenticationRepository
    {

        private readonly WebPocHubDbContext _dbContext;
        public AuthenticationRepository(WebPocHubDbContext context)
        {
            _dbContext = context;
        }

        public User? CheckCredentials(User user)
        {
            var users = _dbContext.Users 
             .Include (u => u.Role) // modified 
             .Where(u => u.Email == user.Email || u.EnrollNo == user.EnrollNo)
             .ToList();


            if (users.Count > 1)
            {
                throw new InvalidOperationException("Multiple users found with the same Email or EnrollNo.");
            }
            //  return users.SingleOrDefault(); original 
            var foundUser = users.SingleOrDefault(); //Modified me  
            if (foundUser != null && BCrypt.Net.BCrypt.Verify(user.Password, foundUser.Password)) //Modified me
            {
                return foundUser;
            }
            return null; //Modified me
        }
        public string GetUserRole(int roleId)
        {
            return _dbContext.Roles.SingleOrDefault(role => role.RoleId == roleId).RoleName;
        }

        public int RegisterUser(User user)
        {
            var existingUser = _dbContext.Users
                .Any(u => u.Email == user.Email || u.EnrollNo == user.EnrollNo);

            if (existingUser)
            {
                throw new InvalidOperationException("A user with the same Email or EnrollNo already exists.");
            }
            _dbContext.Users.Add(user);
            return _dbContext.SaveChanges();
        }
    }
}

