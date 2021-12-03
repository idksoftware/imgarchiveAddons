using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HelpDeskLib;



namespace HelpdeskUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelpDeskData helpDeskData = new HelpDeskData();
            Customer c = new Customer();

            c.Name = "Iain Ferguson";
            c.Address = "78 Hook Rd, Burgess Hill, Sussex";
            c.Phone = "+447986770876";
            c.Email = "iain@hotmail.com";
            c.User = "i.ferguson";
            c.Password = "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225";

            helpDeskData.NewCustomer(c);

            helpDeskData.WriteFile();
        }

        [TestMethod]
        public void TestMethod2()
        {
            HelpDeskData helpDeskData = new HelpDeskData();
            Customer c = new Customer();

            c.Name = "Iain Ferguson";
            c.Address = "78 Hook Rd, Burgess Hill, Sussex";
            c.Phone = "+447986770876";
            c.Email = "iain@hotmail.com";
            c.User = "i.ferguson";
            c.Password = "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225";

            helpDeskData.NewCustomer(c);

            c = new Customer();
            c.Name = "John Ferguson";
            c.Address = "101 Hook Rd, Burgess Hill, Sussex";
            c.Phone = "+44791177987";
            c.Email = "John@hotmail.com";
            c.User = "j.ferguson";
            c.Password = "15e2b0d3c33891ebb0f1ef609ec419420c20e3208764c65fbc8c3312448eb225";

            helpDeskData.NewCustomer(c);

            helpDeskData.WriteFile();
            helpDeskData.ReadFile();
        }
        /*
        [TestMethod]
        public void TestMethod1()
        {
            LoginCommands lc = new LoginCommands();
            lc.AddUser("John", "012345678","John@hotmail.com");
            lc.AddUser("Iain", "123456789", "i.ferguson@idk.co.uk");
            lc.AddUser("Joe", "234567890","Joe@hotmail.com");
            lc.AddUser("Dave", "345678901","Dave@hotmail.com");

            Assert.AreEqual(true, true, "test 1 passed");
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            LoginCommands lc = new LoginCommands();
            bool res = lc.Login("Iain", "123456789");

            Assert.AreEqual(res, true, "test 2 passed");
        }

        [TestMethod]
        public void TestMethod3()
        {
            
            LoginCommands lc = new LoginCommands();
            bool res = lc.NewUser("Tom", "Qaz2wsx3edc..", "Tom@hotmail.com");

            Assert.AreEqual(res, true, "test 3 passed");
        }

        [TestMethod]
        public void TestMethod4()
        {

            LoginCommands lc = new LoginCommands();
            bool res = lc.NewPassword("Tom", "Qaz2wsx3edc..", "Qaz2wsx3edc.{}");

            Assert.AreEqual(res, true, "test 3 passed");
        }

        [TestMethod]
        public void TestMethod5()
        {

            LoginCommands lc = new LoginCommands();
            String res = lc.ForgotPassword("Tom");

            //Assert.AreEqual(res, "Tom@hotmail.com", "test 3 passed");
        }
        */
    }
}
