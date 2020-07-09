using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Interfaces
{
    public interface IUser
    {
        Task<User> Adduser(string firstname, string lastname, string email, string gender, string contatctno, string addressline1, string addressline2, string state, string postalcode, string password);
    }
}
