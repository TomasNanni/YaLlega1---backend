using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaLlega.Models;

namespace YaLlega.Interfaces
{
    internal interface IUserRepository
    {
        public void createUser(NewUserDataDTO dto);

    }
}
