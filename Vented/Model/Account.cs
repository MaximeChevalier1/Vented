using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vented.Model
{
    public class Account
    {
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public string Email { get; set; }   
        public string Password { get; set; }    

        public Account(string firstName, string lastName, string email, string password)
        {
            this.FirstName= firstName;  
            this.LastName= lastName;    
            this.Email= email;  
            this.Password= password;    
        }
    }
}
