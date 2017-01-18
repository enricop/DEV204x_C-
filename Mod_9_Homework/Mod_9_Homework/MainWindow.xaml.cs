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

namespace Mod_9_Homework
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        protected string[] fieldnames = {"first name",
            "last name",
            "city"
        };
    }

    class Student : Person
    {
        public Student(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> mystudents = new List<Student>();
        int display_index = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student curr_student = new Student(txtFirstName.Text, txtLastName.Text);
            curr_student.City = txtCity.Text;

            mystudents.Add(curr_student);

            MessageBox.Show("Student created");

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (mystudents.Count == 0)
                return;

            Student curr_student = mystudents[Math.Abs(display_index % (mystudents.Count - 1))];

            txtFirstName.Text = curr_student.FirstName;
            txtLastName.Text = curr_student.LastName;
            txtCity.Text = curr_student.City;

            display_index--;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (mystudents.Count == 0)
                return;

            Student curr_student = mystudents[Math.Abs(display_index % (mystudents.Count - 1))];

            txtFirstName.Text = curr_student.FirstName;
            txtLastName.Text = curr_student.LastName;
            txtCity.Text = curr_student.City;

            display_index++;
        }
    }
}
