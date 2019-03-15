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

namespace HomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dictionary<Employee, Department> db = new Dictionary<Employee, Department>();
        public MainWindow()
        {
            InitializeComponent();
            btnUpload.Click += BtnUpload_Click;


            //Dictionary<Employee, Department> db = new Dictionary<Employee, Department>() ;

            Random age = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                db.Add(new Employee() { Name = $"Name{i}", LastName = $"LastName{i}", Age = age.Next(20, 50) }, 
                    new Department() { NameOfDepartment = $"NameOfDeparment{i}" });

            }

        }

        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {

            lbdb.ItemsSource = db;

        }
    }
}
