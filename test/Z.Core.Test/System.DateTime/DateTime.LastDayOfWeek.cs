// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_LastDayOfWeek
    {
        [TestMethod]
        public void LastDayOfWeek()
        {
            // Type
            var @this = new DateTime(2014, 01, 24);

            // Exemples
            DateTime result = @this.LastDayOfWeek(); // return "2014/01/25";

            // Unit Test
            Assert.AreEqual(new DateTime(2014, 01, 25), result.Date);
        }
    }
}