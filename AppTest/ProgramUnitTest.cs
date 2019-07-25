using App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class ProgramUnitTest
    {
        [TestMethod]
        public void ShouldRun()
        {
            Program.Main(new[] { "arg" });
        }
    }
}
