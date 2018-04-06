using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___DI
{
    class ServiceMI : IServiceMI
    {

        //Inject the dependency into a single method, for use by that
        //method. Method Injection could be useful where the whole class
        //does not. need the dependency, just the one method. 
        public void Serve()
        {
            Console.WriteLine("Service has been called");
        }
    }

    public class ClientMI
    {
        private IServiceMI _serviceMI;

        public void Start(IServiceMI service)
        {
            this._serviceMI = service;
            Console.WriteLine("The service has started");
            this._serviceMI.Serve();
        }
    }
}
