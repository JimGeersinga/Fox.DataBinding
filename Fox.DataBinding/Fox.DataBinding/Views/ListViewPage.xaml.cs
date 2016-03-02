using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Fox.DataBinding
{
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<PersonModel> Persons { get; set; }

        public ListViewPage()
        {
            InitializeComponent();
            InitializePersons();

            this.Title = "List";
            PersonList.ItemsSource = Persons;

            PersonList.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                ((PersonModel)e.Item).Visible = true;
            };
        }

        public void InitializePersons()
        {
            Persons = new ObservableCollection<PersonModel>()
            {
                new PersonModel
                {
                    FirstName = "Erwin",
                    LastName = "Vorenhout",
                    Age = "19",
                    Role = "Meemer"
                },
                new PersonModel
                {
                    FirstName = "Jim",
                    LastName = "Geersinga",
                    Age = "20",
                    Role = "Programmer"
                },
                new PersonModel
                {
                    FirstName = "Thom",
                    LastName = "Kaptein",
                    Age = "12",
                    Role = "Putje schepper"
                },
                new PersonModel
                {
                    FirstName = "Donald",
                    LastName = "Trump",
                    Age = "69",
                    Role = "Homo"
                },
                new PersonModel
                {
                    FirstName = "Rick",
                    LastName = "Astley",
                    Age = "50",
                    Role = "Singer"
                },
                new PersonModel
                {
                    FirstName = "Barack",
                    LastName = "Obama",
                    Age = "54",
                    Role = "President"
                },
                new PersonModel
                {
                    FirstName = "Erwin",
                    LastName = "Vorenhout",
                    Age = "19",
                    Role = "Meemer"
                },
                new PersonModel
                {
                    FirstName = "Jim",
                    LastName = "Geersinga",
                    Age = "20",
                    Role = "Programmer"
                },
                new PersonModel
                {
                    FirstName = "Thom",
                    LastName = "Kaptein",
                    Age = "12",
                    Role = "Putje schepper"
                },
                new PersonModel
                {
                    FirstName = "Donald",
                    LastName = "Trump",
                    Age = "69",
                    Role = "Homo"
                },
                new PersonModel
                {
                    FirstName = "Rick",
                    LastName = "Astley",
                    Age = "50",
                    Role = "Singer"
                },
                new PersonModel
                {
                    FirstName = "Barack",
                    LastName = "Obama",
                    Age = "54",
                    Role = "President"
                },
                new PersonModel
                {
                    FirstName = "Erwin",
                    LastName = "Vorenhout",
                    Age = "19",
                    Role = "Meemer"
                },
                new PersonModel
                {
                    FirstName = "Jim",
                    LastName = "Geersinga",
                    Age = "20",
                    Role = "Programmer"
                },
                new PersonModel
                {
                    FirstName = "Thom",
                    LastName = "Kaptein",
                    Age = "12",
                    Role = "Putje schepper"
                },
                new PersonModel
                {
                    FirstName = "Donald",
                    LastName = "Trump",
                    Age = "69",
                    Role = "Homo"
                },
                new PersonModel
                {
                    FirstName = "Rick",
                    LastName = "Astley",
                    Age = "50",
                    Role = "Singer"
                },
                new PersonModel
                {
                    FirstName = "Barack",
                    LastName = "Obama",
                    Age = "54",
                    Role = "President"
                }
            };
        }
    }
}

