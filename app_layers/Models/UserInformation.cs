using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_layers.Models
{
    public class UserInformation
    {
        public int ID { get; protected set;} //private
        public string FirstName { get; set;}
        public string LastName { get;set;}

        public UserInformation( int ID) // параметризированный конструктор, т.к надо иметь контроль над созданием ID
        {
            this.ID = ID;
        }
    }
}