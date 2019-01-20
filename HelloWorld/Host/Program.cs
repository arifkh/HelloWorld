using HelloWorld.Core;
using Microsoft.Practices.Unity.Configuration;
using System;
using Unity;

namespace Host
{
    class Program
    {
        internal static readonly IUnityContainer UnityContainer = new UnityContainer();

        static void Main(string[] args)
        {
            UnityContainer.LoadConfiguration();

            var greetCommand = UnityContainer.Resolve<ICommand>("SendGreetings");
            greetCommand.RunCommand();

            Console.ReadLine();
        }
    }
}
