using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We can not create instance of SingleTon
            SingleTon singleTon = new SingleTon();
            */
            var singleTon = SingleTon.Instanse;
        }
    }
}
