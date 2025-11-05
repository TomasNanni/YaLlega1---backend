using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaLlega.Entities;
using YaLlega.Interfaces;
using YaLlega.Models;
using YaLlega1.Data;

namespace YaLlega.Repositories
{
    public class UserRepository : IUserRepository
    {
        private YaLlega1Context _context;

        public UserRepository(YaLlega1Context context)
        {
            _context = context;
        }
        public void createUser(NewUserDataDTO dto)
        {
            var user = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                EmailAdress = dto.EmailAdress,
                Password = dto.Password,
                Restaurant = dto.Restaurant,
                RestaurantId = dto.RestaurantId
            };
            _context.Users.Add(user);
            return;
        }
    }
}
