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
using System.Windows.Shapes;

namespace SchoolAttendanceWPF.Views
{
    /// <summary>
    /// Interaction logic for WinStartUp.xaml
    /// </summary>
    public partial class WinStartUp : Window
    {
        public WinStartUp()
        {
            InitializeComponent();
        }

        public async Task GetYearDataAsync()
        {
            var dsSchoolYears = await DataManager.GetSchoolYearsAsync();
            if (dsSchoolYears.Count > 0)
            {
                cmbSchoolYear.ItemsSource = null;

                cmbSchoolYear.ItemsSource = dsSchoolYears.ToList();
                cmbSchoolYear.DisplayMemberPath = "Description";
                cmbSchoolYear.SelectedValuePath = "ID";
            }

           
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await GetYearDataAsync();
        }

        private async void cmbSchoolYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbSchoolYear.SelectedIndex > -1)
            {
                var selectedyearid = (SchoolYear)cmbSchoolYear.SelectedItem;
                var ds = await DataManager.GetSchoolYearsTermsAsync(selectedyearid.ID);
                if (ds.Count > 0)
                {
                    cmbSchoolterm.ItemsSource = null;
                    cmbSchoolterm.ItemsSource = ds.ToList();
                    cmbSchoolterm.DisplayMemberPath = "Description";
                    cmbSchoolterm.SelectedValuePath = "ID";
                }
            }

            
        }

        private void cmbSchoolYear_DropDownClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("Closed");



        }

        private async void cmbSchoolterm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbSchoolterm.SelectedIndex > -1)
            {
                var selectedterm = (SchoolYearTerm)cmbSchoolterm.SelectedItem;
                var ds = await DataManager.GetAllTermLevelsAsync(selectedterm.ID);
                if (ds.Count > 0)
                {
                    cmbSchoolLevel.ItemsSource = null;
                    cmbSchoolLevel.ItemsSource = ds.ToList();
                    cmbSchoolLevel.DisplayMemberPath = "Description";
                    cmbSchoolLevel.SelectedValuePath = "ID";
                }
            }
        }

        private async void cmbSchoolLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbSchoolLevel.SelectedIndex > -1)
            {
                var selectedterm = (Level)cmbSchoolLevel.SelectedItem;
                var ds = await DataManager.GetAllLevelsClassAsync(selectedterm.ID);
                if (ds.Count > 0)
                {
                    cmbClass.ItemsSource = null;
                    cmbClass.ItemsSource = ds.ToList();
                    cmbClass.DisplayMemberPath = "Description";
                    cmbClass.SelectedValuePath = "ID";
                }
            }
        }
    }
}
