using HelloWorld.Core;

namespace HelloWorld.StandardCommands
{
    public class GreetCommand : ICommand
    {
        const string _greetMessage = "Hello World";
        private readonly IMessageRepository _messageRepository;

        public GreetCommand(IMessageRepository messageRepository)
        {
            this._messageRepository = messageRepository;
        }
        public void RunCommand()
        {
            _messageRepository.WriteMessage($"{ _greetMessage} from {this.GetType().Name}");
        }
    }
}
