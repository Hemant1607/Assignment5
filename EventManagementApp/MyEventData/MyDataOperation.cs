using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEventData
{
    public class MyDataOperation
    {
        dbEventEntities MydbEventEntities = new dbEventEntities();

        public void InsertEvent(Login loginobj)
        {
            MydbEventEntities.Logins.Add(loginobj);
            MydbEventEntities.SaveChanges();
        }
    }
}
