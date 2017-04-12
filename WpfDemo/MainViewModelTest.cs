using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WpfDemo
{
    public class MainViewModelTest
    {
        public void PropertyNotifiedRaisedWhenFirstNameChanges()
        {
            var eventcalled = false;
            var vm = new MainViewModel();
            vm.PropertyChanged += (sender, args) => { eventcalled = true; };
            vm.FirstName = "xxx";

            //Assert.That(eventcalled, Is.True);
        }
    }
}
