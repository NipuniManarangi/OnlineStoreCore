using OnlineStore.Data.DataContext;
using OnlineStore.Data.Entities;
using OnlineStore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Functions
{
    public class UserFunctions : IUser
    {
        //Add a new user
        public async Task<User> Adduser(string firstname, string lastname, string email, string gender, string contatctno, string addressline1, string addressline2, string state, string postalcode, string password)
        {
            User newUser = new User
            {
                //UserId = 1,
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Gender = gender,
                ContatctNo = contatctno,
                Address_Line1 = addressline1,
                Address_Line2 = addressline2,
                State = state,
                PostalCode = postalcode,
                Password = password
            };
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                await context.Users.AddAsync(newUser);
                await context.SaveChangesAsync();
            }
            return newUser;
        }
    }
}
