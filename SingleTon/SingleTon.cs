using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    // Sealed is used to privent calling constractor from inner classes
    public sealed class SingleTon
    {
        private static SingleTon instanse;
        public static SingleTon Instanse
        {
            // If instance is already available return the instance otherwise return new one
            get
            {
                if (instanse == null)
                    return new SingleTon();
                return instanse;
            }
        }
        // Constractor is private so it is not possible 
        // to create a new instance of the object
        private SingleTon() { }
    }
}
