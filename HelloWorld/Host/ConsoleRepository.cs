using HelloWorld.Core;
using System;

namespace Host
{
    public class ConsoleRepository : IMessageRepository
    {
        public ConsoleRepository()
        {
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
