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
    public partial class p1_selected : ContentPage
    {
        private DS_Person personSelected = new DS_Person();
        public p1_selected(int personID)
        {
            InitializeComponent();
            BindingContext = personSelected.GetPersonSelected(personID);
        }
    }
}