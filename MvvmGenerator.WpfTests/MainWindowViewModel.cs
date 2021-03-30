using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmGenerator.WpfTests
{
    public partial class MainWindowViewModel
    {
        [AutoNotify("Xxxx")]
        private string _firstName;

        [AutoNotify]
        private string _lastName;

        [AutoNotify]
        public string FullName => $"{Xxxx} {LastName}";
    }
}
