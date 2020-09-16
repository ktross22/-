using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFintess.BL.Model
{
    [Serializable]
    public class Exercise
    {
        public DateTime Start { get;}
        public DateTime Finish { get;}
        public Activity Activity { get;}
        public User User { get; }
        public DateTime Strart { get; }

        public Exercise(DateTime strart, DateTime finish, Activity activity, User user)
        {

            //Проверка

            Strart = strart;
            Finish = finish;
            Activity = activity;
            User = user;
        }
    }
}
