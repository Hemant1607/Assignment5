using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventData
{
    public class MyDataOperation
    {
        dbEventEntities MydbEventEntities = new dbEventEntities();
         public void InsertEvent(Login logindata)
        {
            MydbEventEntities.Logins.Add(logindata);
            MydbEventEntities.SaveChanges();
        }
    }
}
