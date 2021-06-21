using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KolokwiumZ1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> ListaOsob { get; set; }
        public MainWindow()
        {
            ListaOsob = new List<Person>()
            { 
                 new Person() {ID = 1, Name = "Jan", Surname = "Kowalski", email = "jkowalski@onet.pl"},
                 new Person() {ID = 2, Name = "Adam", Surname = "Nowak", email = "anowak@gmail.com"},
                 new Person() {ID = 3, Name = "Anna", Surname = "Malinowska", email = "amalinowska@wp.pl"}
            };
            InitializeComponent();

            dGrid.Columns.Add(new DataGridTextColumn() { Header = "ID", Binding = new Binding("ID") });
            dGrid.Columns.Add(new DataGridTextColumn() { Header = "Name", Binding = new Binding("Name") });
            dGrid.Columns.Add(new DataGridTextColumn() { Header = "Surname", Binding = new Binding("Surname") });
            dGrid.Columns.Add(new DataGridTextColumn() { Header = "e-mail", Binding = new Binding("email") });

            dGrid.AutoGenerateColumns = false;
            dGrid.ItemsSource = ListaOsob;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = ListaOsob.Count() + 1;
                string name = tbName.Text, surname = tbSurname.Text, email = tbE_mail.Text;

                ListaOsob.Add(new Person(id, name, surname, email));
                dGrid.Items.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd w danych","Błąd", MessageBoxButton.OK);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dGrid.SelectedItem is Person)
                ListaOsob.Remove((Person)dGrid.SelectedItem);
            dGrid.Items.Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dGrid.SelectedItem is not Person)
                return;
            var dialog = new Update((Person)dGrid.SelectedItem);
            if (dialog.ShowDialog() == true)
                dGrid.Items.Refresh();
        }
    }
}
