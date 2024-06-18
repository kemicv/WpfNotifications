using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfNotifications.Models
{
    public class Car : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName != nameof(IsChanged)) { IsChanged = true; }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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

        private bool _isChanged;
        public bool IsChanged
        {
            get { return _isChanged; }
            set { if (value == _isChanged) return; _isChanged = value; OnPropertyChanged(); }
        }
    }
}
