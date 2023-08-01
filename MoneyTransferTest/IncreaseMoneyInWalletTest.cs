using MoneyTransfer;

namespace MoneyTransferTest
{
    [TestClass]
    public class IncreaseMoneyInWalletTest
    {
        [TestMethod]
        public void AcceptMoney_PositiveInteger_IncreasesMoneyInWallet()
        {
            //Arrange 
            Person person = new Person("James", 1000);
            int amountToAccept = 200;
            int expectedMoney = person.wallet.money + amountToAccept;
           


            //Act
            person.AcceptMoney(amountToAccept);
            int actualMoney = person.wallet.money;

            //Assert
            Assert.AreEqual(expectedMoney, actualMoney, "Accepting a positive integer should increase the money in the person's Wallet.");
        }
        [TestMethod]
        public void AcceptMoney_NegativeInteger_DecreasesMoneyInWallet()
        {

            //Average
            Person person = new Person("Michelle", 700);
            int amountToAccept = -200;
            int expectedMoney = person.wallet.money + amountToAccept;

            //Act
            person.AcceptMoney(amountToAccept);
            int actualMoney = person.wallet.money;

            //Assert
            Assert.AreEqual(expectedMoney, actualMoney, "Accepting a negatice integer should decrease the money in the person's Wallet.");
        }
        [TestMethod]

        public void AcceptMoney_ZeroInteger_NoChangeInMoneyInWallet()
        {
            //Average
            Person person = new Person("Michelle", 700);
            int amountToAccept = 0;
            int expectedMoney = person.wallet.money + amountToAccept;

            //Act
            person.AcceptMoney(amountToAccept);
            int actualMoney = person.wallet.money;

            //Assert
            Assert.AreEqual(expectedMoney, actualMoney, "Accepting a zero integer should make no change in the person's Wallet.");
        }
    }
}