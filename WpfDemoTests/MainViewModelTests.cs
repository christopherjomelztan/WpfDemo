using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.Tests
{
    [TestClass()]
    public class MainViewModelTests
    {
        [TestMethod()]
        public void PropertyNotifiedRaisedWhenFirstNameChanges()
        {
            var eventcalled = false;
            var vm = new MainViewModel();
            vm.PropertyChanged += (sender, args) => { eventcalled = true; };
            vm.FirstName = "";
            vm.LastName = "";

            Assert.IsTrue(eventcalled);
        }

        [TestMethod()]
        public void OnPropertyChangedTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MainViewModelTest()
        {
            Assert.Fail();
        }
    }
}