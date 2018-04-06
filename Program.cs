using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_File___DI
{
    class Program
    {
        //Below shows all forms of Dependency Injection:

        static void Main(string[] args)
        {
            ClientCI ConstructorInjection = new ClientCI(new ServiceCI());
            ConstructorInjection.Start();
            Console.ReadLine();

            ClientPI PropertyInjection = new ClientPI();
            PropertyInjection.Service = new ServicePI();
            PropertyInjection.Start();
            Console.ReadLine();

            ClientMI MethodInjection = new ClientMI();
            MethodInjection.Start(new ServiceMI());
            Console.ReadLine();

        }
    }
}
