using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfNotifications.Models
{
    public class Car : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { if (value == _id) return; _id = value; OnPropertyChanged(); }
        }

        public string Make { get; set; }
        
        private string _color;
        public string Color
        {
            get { return _color; }
            set { if (value == _color) return; _color = value; OnPropertyChanged(); }
        }

        public string PetName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
        }
    }
}
