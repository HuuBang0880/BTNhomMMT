using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class User
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();
       
        public void Users(string userName, string passWord)
        {
            _users.Add(userName, passWord);
            
        }
        public bool checkUser(string userName, string passWord)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (String.Compare(_users.ElementAt(i).Key, userName) == 0)
                {
                    if (_users.ElementAt(i).Value == passWord)
                    {
                        return false;

                    }
                }
            }

            return true;
        }
    }
}
