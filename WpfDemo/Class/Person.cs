using WpfDemo.Interface;

namespace WpfDemo.Class
{
    public class Person : BindableBase,IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
