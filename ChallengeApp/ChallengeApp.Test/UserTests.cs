using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {


        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectSumAsRes()
        {
            //arrange
            var user = new Employee("adam","pass",22);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-11);
            //act
            var result = user.Result;
            

            //assert

            Assert.AreEqual(0, result);

        }
    }
}

