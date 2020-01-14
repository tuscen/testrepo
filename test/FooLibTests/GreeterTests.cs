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

        [Theory]
        [InlineData("Anon")]
        [InlineData("tuscen")]
        [InlineData("foo bar")]
        public void ShouldReturnGreetString2(string name)
        {
            var greeter = new Greeter();
            var greetingString = greeter.Greet(name);
            Assert.Equal($"Hello, {name}", greetingString);
        }
    }
}
