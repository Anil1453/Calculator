using System.Security.Cryptography.X509Certificates;
using Calculator;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            public void Add_CorrectSum()
        {
            Calc calc = new Calc();
            var result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
        
    }
}