using System.ComponentModel;

namespace WpfNotifications.Models
{
    public partial class Car : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Id):
                        break;
                    case nameof(Make):
                        return Make == "ModelT" ? "Too Old" : CheckMakeAndColor();
                    case nameof(Color):
                        return CheckMakeAndColor();
                    case nameof(PetName):
                        break;
                }
                return string.Empty;
            }
        }

        internal string CheckMakeAndColor()
        {
            if (Make == "Chevy" && Color == "Pink")
            {
                return $"{Make}'s don't come in {Color}";
            }
            return string.Empty;
        }

        public string Error { get; }
    }
}
