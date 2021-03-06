// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Object_GetValueOrDefault
    {
        [TestMethod]
        public void GetValueOrDefault()
        {
            // Type
            var @this = new XmlDocument();

            // Exemples
            string result1 = @this.GetValueOrDefault(x => x.FirstChild.InnerXml, "FizzBuzz"); // return "FizzBuzz";
            string result2 = @this.GetValueOrDefault(x => x.FirstChild.InnerXml, () => "FizzBuzz"); // return "FizzBuzz"

            // Unit Test
            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzBuzz", result2);
        }
    }
}