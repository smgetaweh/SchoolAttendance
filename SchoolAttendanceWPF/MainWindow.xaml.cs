using AttendanceModels;
using SchoolAttendanceWPF.Data;
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

namespace SchoolAttendanceWPF
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

        public async Task GetData()
        {
            var ds = await DataManager.GetAllAttendanceAsync();
            if (ds.Count > 0)
            {
                dgvAttendance.ItemsSource = ds.ToList();
            }
        }

        //public void CreateSampleYears()
        //{
        //    SchoolYear newSchoolYear = new SchoolYear();
        //    newSchoolYear.ID = 001;
        //    newSchoolYear.Description = "2016 - 2017";
        //    newSchoolYear.YearStartDate = DateTime.Now.AddMonths(-7);
        //    newSchoolYear.YearEndDate = DateTime.Now.AddMonths(+3);
        //    newSchoolYear.Notes = "test school year";

        //    lblSchoolYear.Content = string.Format("ID:{0} Description:{1} Start Date:{2} End Date:{3}"
        //        , newSchoolYear.ID, newSchoolYear.Description, newSchoolYear.YearStartDate.ToShortDateString(),
        //        newSchoolYear.YearEndDate.ToShortDateString()); ;
        //}

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await GetData();
        }
    }
}
