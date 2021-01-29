using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bai_nop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class p1_notifications : ContentPage
    {
        DS_Person xxx = new DS_Person();
        public p1_notifications()
        {
            InitializeComponent();
            list_notification.ItemsSource = xxx.GetDS();
        }

        async private void list_notification_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Person;
            await Navigation.PushAsync(new p1_selected(item.Id));
        }
    }
}