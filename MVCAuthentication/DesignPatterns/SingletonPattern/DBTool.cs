using MVCAuthentication.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        static MyContext _dbInstance;

        DBTool()
        {

        }

        public static MyContext DBInstance 
        {
            get
            {
                if (_dbInstance is null) _dbInstance = new MyContext();
                return _dbInstance;
            } 
        }
    }
}