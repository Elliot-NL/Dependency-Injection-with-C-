using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___DI
{
    class ServicePI : IServicePI
    {
        //Property Injection is used when a class has option dependencies or 
        //where the implementations may need to be swapped. Different 
        //logger implementations could be used this way.
        public void ServePI()
        {
           Console.WriteLine("The service has been calleds");   
        }
    }

    public class ClientPI
    {
        private IServicePI _servicepi;

        public IServicePI Service
        {
            set
            {
                this._servicepi = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("The service has started");
            this._servicepi.ServePI();
        }
    }
}
