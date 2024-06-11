using System.Windows;
using WpfNotifications.Models;

namespace WpfNotifications
{
    public partial class MainWindow : Window
    {
        readonly IList<Car> _cars = new List<Car>();

        public MainWindow()
        {
            InitializeComponent();
            _cars.Add(new Car { Id = 1, Color = "Blue", Make = "Chevy", PetName = "Kit" });
            _cars.Add(new Car { Id = 2, Color = "Red", Make = "Ford", PetName = "Red Rider" });
            cboCars.ItemsSource = _cars;
        }

        private void BtnChangeColor_OnClick(object sender, RoutedEventArgs e)
        {
            //Use the SelectedItem property of the ComboBox to locate the
            //selected record from the car list and change the color
            _cars.First(x => x.Id == ((Car)cboCars.SelectedItem)?.Id).Color = "Pink";
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            //Add an event handler to the btnAddCar button
            var maxCount = _cars?.Max(x => x.Id) ?? 0;
            _cars?.Add(new Car { Id = ++maxCount, Color = "Yellow", Make = "VW", PetName = "Birdie" });
        }
    }
}