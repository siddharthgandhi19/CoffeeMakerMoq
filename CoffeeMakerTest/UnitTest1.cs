using CoffeeMaker;
using Moq;

namespace CoffeeMakerTest
{
    public class Tests
    {

        [Test]
        public void OrderACoffee_Should_Return_Receive_Message()
        {
            StarbucksStore store = new StarbucksStore(new FakeStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received", result);

        }

        [Test]
        public void OrderACoffee1_Should_Return_Receive_Message()
        {
            StarbucksStore store = new StarbucksStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received", result);
        }
        [Test]
        public void OrderACoffee_Should_Return_Receive_MessageUsingMock()
        {
            var service = new Mock<IMakeCoffee>();
            service.Setup(x => x.CheckIngridentAvailability()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is received");
            var store = new StarbucksStore(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your Order is received", result);
        }    
    }
}