using FooLib;
using Xunit;

namespace FooLibTests
{
    public class GreeterTests
    {
        [Fact]
        public void ShouldReturnGreetString()
        {
            var greeter = new Greeter();
            var greetingString = greeter.Greet("Anon");
            Assert.Equal("Hello, Anon", greetingString);
        }
    }
}
