using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.Entities.Interfaces;

namespace myApiProject.Entities.Dtos.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
