using MyApi_Manav.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi_Manav.Services
{
    public interface IAuthenticateService
    {
        Student Authenticate(String UserName, String Password);
    }

}
