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
        [InlineData("Anon", false)]
        [InlineData("tuscen", true)]
        [InlineData("foo bar", false)]
        public void ShouldReturnGreetString2(string name, bool exclamation)
        {
            var greeter = new Greeter();
            var greetingString = greeter.Greet(name, exclamation);
            Assert.Equal(exclamation ? $"Hello, {name}!" : $"Hello, {name}", greetingString);
        }

        [Fact]
        public void ShouldReturnTestString()
        {
            var test = new Test();
            var testValue = test.GetValue();
            Assert.Equal("test5", testValue);
        }
    }
}
