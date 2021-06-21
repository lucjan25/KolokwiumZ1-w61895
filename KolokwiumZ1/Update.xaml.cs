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
using System.Windows.Shapes;

namespace KolokwiumZ1
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public Person person;
        public Update(Person person)
        {
            InitializeComponent();
            if (person != null)
            {
                tbName.Text = person.Name;
                tbSurname.Text = person.Surname;
                tbE_mail.Text = person.email;
            }
            this.person = person ?? new Person();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            person.Name = tbName.Text;
            person.Surname = tbSurname.Text;
            person.email = tbE_mail.Text;

            this.DialogResult = true;
        }
    }
}
