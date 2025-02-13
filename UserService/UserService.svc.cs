using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using UserService.Data;
using UserService.Models;

namespace UserService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class UserService : IUserService
    {
        public List<UserDto> GetUsers()
        {
            using (var db = new UserDbContext())
            {
                return db.Users.Select(u => new UserDto
                {
                    Id = u.Id,
                    FullName = u.FullName,
                    IdentificationNumber = u.IdentificationNumber,
                    Email = u.Email,
                    Phone = u.Phone,
                    CreatedAt = u.CreatedAt,
                    UpdatedAt = u.UpdatedAt
                }).ToList();
            }
        }

        public void AddUser(UserDto userDto)
        {
            using (var db = new UserDbContext())
            {
                var user = new User
                {
                    FullName = userDto.FullName,
                    IdentificationNumber = userDto.IdentificationNumber,
                    Email = userDto.Email,
                    Phone = userDto.Phone
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void UpdateUser(UserDto userDto)
        {
            using (var db = new UserDbContext())
            {
                var user = db.Users.Find(userDto.Id);
                if (user != null)
                {
                    user.FullName = userDto.FullName;
                    user.Email = userDto.Email;
                    user.Phone = userDto.Phone;
                    user.UpdatedAt = System.DateTime.Now;

                    db.SaveChanges();
                }
            }
        }
    }
}
