using System;
using System.ComponentModel;

namespace Fox.DataBinding
{
    public class PersonModel : INotifyPropertyChanged
    {
        public PersonModel()
        {
            this.Visible = false;
        }
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        public string Age { get; set; }
        public string Role { get; set; }
        public bool Visible { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

