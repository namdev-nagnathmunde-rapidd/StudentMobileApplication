
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentAppFirebase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManuPage : MasterDetailPage
    {
        public ManuPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            // var ManuPage  = new StudentAppFirebase.Views.StudentDeailPage();
            Navigation.InsertPageBefore(new StudentDeailPage(), this);
            await Navigation.PopAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
          //  var ManuPage = new Views.VideoDetailPage();

            Navigation.InsertPageBefore(new VideoDetailPage(), this);
            await Navigation.PopAsync();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }
    }
}