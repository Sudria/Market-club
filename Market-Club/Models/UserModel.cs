using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Club.Models
{
    internal class UserModel
    {
        
        public int Id { get; set; }                
        public string Name { get; set; }  
        public string Surname { get; set; }
        public string Email { get; set; }          
        public string Password { get; set; }   
        public int RolId { get; set; }

    }

}

