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
        Test vm;
        public Infections_Britain()
        {
            vm = new Test();
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}