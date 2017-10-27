using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BAL
{
    public class User
    {
        public UserInformation GetCurrentUser()
        {
            var user1 = new UserInformation(1)
            {
                FirstName = "Dima",
                LastName = "Bolyachin"
            };
            return user1;
        }
    }

    public class UserInformation
    {
        public int ID { get; protected set; } //private или protected для set
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserInformation(int ID) // параметризированный конструктор, т.к надо иметь контроль над созданием ID
        {
            this.ID = ID;
        }
    }
}
