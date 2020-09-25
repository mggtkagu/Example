using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInspection.Core
{
    public static class Singleton<T>where T:new()
    {
        public static T _instance;
        public static T Instance()
        {
            if (_instance == null)
            {
                _instance = new T();
                return _instance;
            }
            else return _instance;
        }
    }
}
