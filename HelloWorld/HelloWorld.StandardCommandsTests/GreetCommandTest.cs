using HelloWorld.Core;
using HelloWorld.StandardCommands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorld.StandardCommandsTests
{
    [TestClass]
    public class GreetCommandTest
    {
        [TestMethod]
        public void WriteMessageCalledOneTime()
        {
            // Arrange
            var messageRepositoryMock = new Mock<IMessageRepository>();
            ICommand greetCommand = new GreetCommand(messageRepositoryMock.Object);

            // Act
            greetCommand.RunCommand();

            // Assert
            messageRepositoryMock.Verify(x => x.WriteMessage(It.IsAny<string>()), Times.Exactly(1));
        }
    }
}
