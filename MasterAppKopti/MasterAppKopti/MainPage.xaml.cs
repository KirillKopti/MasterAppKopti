using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterAppKopti
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("Eshik.jpg");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "",
                Detail = "",
                ImagePath = "",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "",
                Detail = "",
                ImagePath = "",
                TargetPage = typeof(Views.ExperientsePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "",
                Detail = "",
                ImagePath = "",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "",
                Detail = "",
                ImagePath = "",
                TargetPage = typeof(Views.AchivmentsPage)
            });
            return list;
        }
        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
