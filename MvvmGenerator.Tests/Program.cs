using System;

namespace MvvmGenerator.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var vm = new MainPageViewModel();

            vm.PropertyChanged += (o, e) =>
                  Console.WriteLine($"{e.PropertyName} Property Changed");

            Console.WriteLine($"FullName is [{vm.FullName}]");

            vm.Xxxx = "Anders ";
            Console.WriteLine($"FullName is [{vm.FullName}]");

            vm.LastName = "Hejlsberg";
            Console.WriteLine($"FullName is [{vm.FullName}]");
        }
    }

    public partial class MainPageViewModel
    {
        [AutoNotify("Xxxx")]
        private string _firstName;

        [AutoNotify]
        private string _lastName;

        [AutoNotify]
        public string FullName => $"{Xxxx} {LastName}";
    }
}
