using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___DI
{
    class ServiceCI : IServiceCI
    {
        //Constructor Injection is done by supplying the dependency through 
        //the class's constructor when instantiating that class. Thus allowing
        //the dependency to be injected from outside the class.
        public void Serve()
        {
            Console.WriteLine("The service has been called");
        }

    }

    //Should be in seperate project to adhere to the stairway pattern:
    public class ClientCI
    {
        private IServiceCI _service;

        public ClientCI(IServiceCI service)
        {
            this._service = service;
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
        }
    }
}
