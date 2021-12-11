using Covid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid.ForAnalysis.Britain
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Infections_Britain : ContentPage
    {
        Britain_Infections vm;
        public Infections_Britain()
        {
            vm = new Britain_Infections();
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}