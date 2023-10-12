using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{   
    public class AccessDemo
    {
        //public: fully accesible
        //internal: accessible within the same project
        //protected: accessible from inherited (sub) classes
        //protected internal: accesible with the same project
        //      and also from inherited (sub) classes
        //private: only accesible within the same file

        public void PublicMessage()
        {
            Console.WriteLine("Hello, you can see this from anywhere..");
        }

        private void PrivateMessage()
        {
            Console.WriteLine("This is a private message.");
        }

        internal void InternalMessage()
        {
            Console.WriteLine("Hello, maybe you are in the same project.");
        }

        protected void ProtectedMessage()
        {
            Console.WriteLine("Hello, you must a be a subclass from me.");
        }

        internal protected void InternalProtectedMessage()
        {
            Console.WriteLine("Hello, internal + protected access available.");
        }
    }
}
