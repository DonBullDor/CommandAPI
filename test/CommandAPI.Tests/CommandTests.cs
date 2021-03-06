using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand =
                new Command {
                    HowTo = "Do something",
                    Platform = "Some platform",
                    CommandLine = "Some commandline"
                };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            var testCommand =
                new Command {
                    HowTo = "Do something awesome",
                    Platform = "xUnit",
                    CommandLine = "dotnet test"
                };

            //Act
            testCommand.HowTo = "Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }
    }
}
