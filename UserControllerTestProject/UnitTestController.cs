namespace UserControllerTestProject
{
    [TestClass]
    public class UnitTestController
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
                int a = 5;
                int b = 10;
            // Act
            int sum = a + b;
            // Assert
            Assert.AreEqual(15, sum);
        }
    }
}