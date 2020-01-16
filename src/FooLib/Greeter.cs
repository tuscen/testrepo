using System;

namespace FooLib
{
    /// <summary>
    ///
    /// </summary>
    public class Greeter
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="exclamation"></param>
        /// <returns></returns>
        public string Greet(string name, bool exclamation = false)
        {
            return exclamation
                ? $"Hello, {name}!"
                : $"Hello, {name}";
        }
    }
}
