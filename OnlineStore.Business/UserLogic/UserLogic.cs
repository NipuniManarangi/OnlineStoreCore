using OnlineStore.Data.Functions;
using OnlineStore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Business.UserLogic
{
    public class UserLogic
    {
        private IUser _user = new UserFunctions();
        //add a new user
        public async Task<Boolean> CreateNewUser(string firstname, string lastname, string email, string gender, string contatctno, string addressline1, string addressline2, string state, string postalcode, string password)
        {
            try
            {
                var result = await _user.Adduser(firstname, lastname, email, gender, contatctno, addressline1, addressline2, state, postalcode, password);
                if (result.UserId > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception error)
            {
                return false;

            }
        }
    }
}
