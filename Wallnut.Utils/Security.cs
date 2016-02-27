using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.BusinessLogic.Implementations;
using Wallnut.Domain.Models;

namespace Wallnut.Utils
{
    public static class Security
    {
        public static bool UserAutenticated(string login, string pass)
        {
            bool ret = true;
            using (var unitOfWork = new UnitOfWork(new WallnutProductionContext()))
            {
                var empPass = unitOfWork.EmployeeRepository.GetPasswordByLogin(login);

                if (empPass == null)
                    return false;
                string correctHash = empPass==null? "":string.Format("{0}:{1}:{2}"
                    , PasswordHash.PasswordHash.PBKDF2_ITERATIONS
                    , empPass.PasswordSalt
                    , empPass.PasswordHash);
               
               ret = PasswordHash.PasswordHash.ValidatePassword(pass, correctHash);
            }
            return ret;
        }
    }
}
