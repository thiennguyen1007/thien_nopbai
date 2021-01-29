using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bai_nop
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string IMG = "https://images.unsplash.com/photo-1541701494587-cb58502866ab?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80";
            img.Source = IMG;

        }

        async private void btn_Login_Clicked(object sender, EventArgs e)
        {
            

        }

       async private void btn_login_Clicked_1(object sender, EventArgs e)
        {

            if (txt_name.Text != "admin" || txt_pass.Text != "admin")
            {
                await DisplayAlert("Thong bao!", "Sai!", "OK");

            }
            else
            {
                await Navigation.PushAsync(new Basic_App());
            }
            
        }
    }
}
