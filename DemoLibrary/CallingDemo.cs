using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();
            demo.PublicMessage();
            demo.InternalMessage();
            demo.InternalProtectedMessage();

            InheritFromAccessDemo idemo = new InheritFromAccessDemo();
            idemo.PublicMessage();
            idemo.InternalMessage();
            idemo.InternalProtectedMessage();
        }
    }
}
