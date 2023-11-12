
using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Test2

    {
        [Test]
        public void test3()
        {
         //arange
            double doub1 = 3.4;
            double doub2 = 3.3231;

        //act
        

        //assert
            Assert.AreNotEqual(doub1, doub2);  

        }
        [Test]
        public void test2()
        {
            //arrange
            int numer1 = 1;
            int numer2 = 2;
            int numer3 = 3; 

            //act

            //assert
            Assert.AreEqual(numer2 + numer3 + numer1, numer2 + numer3 + numer1);
        }
        [Test]
        public void test1()

        {
            //arange
            var user1 = GetUser2("Maciej");
            var user2 = GetUser2("Maciej");

            //act


            //assert
            Assert.AreEqual(user1.Name, user2.Name);  
        }

        private Employee GetUser2(string name)
        {
            return new Employee(name);
        }
    }
    
}
