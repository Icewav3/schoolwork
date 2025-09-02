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

namespace Database_stuff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Database_stuff.Database1DataSet database1DataSet = ((Database_stuff.Database1DataSet)(this.FindResource("database1DataSet")));
            // Load data into the table Students. You can modify this code as needed.
            Database_stuff.Database1DataSetTableAdapters.StudentsTableAdapter database1DataSetStudentsTableAdapter = new Database_stuff.Database1DataSetTableAdapters.StudentsTableAdapter();
            database1DataSetStudentsTableAdapter.Fill(database1DataSet.Students);
            System.Windows.Data.CollectionViewSource studentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentsViewSource")));
            studentsViewSource.View.MoveCurrentToFirst();
            // Load data into the table Calculations. You can modify this code as needed.
            Database_stuff.Database1DataSetTableAdapters.CalculationsTableAdapter database1DataSetCalculationsTableAdapter = new Database_stuff.Database1DataSetTableAdapters.CalculationsTableAdapter();
            database1DataSetCalculationsTableAdapter.Fill(database1DataSet.Calculations);
            System.Windows.Data.CollectionViewSource calculationsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("calculationsViewSource")));
            calculationsViewSource.View.MoveCurrentToFirst();
        }
    }
}
