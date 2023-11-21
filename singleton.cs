using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }  // Private constructor to prevent instantiation outside the class

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

/// <summary>
///  example 2
/// </summary>
public class Singleton2
{
    private static Singleton2 instance = new Singleton2();

    private Singleton2() { }  // Private constructor to prevent instantiation outside the class

    public static Singleton2 GetInstance()
    {
        return instance;
    }
} 
  
