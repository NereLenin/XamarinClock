using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace clock
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomClockCell : ContentView
    {
     
        public CustomClockCell()
        {
            InitializeComponent();
            
        }

        public void ShowNumber(char OneNotDecadeNumber)
        {

            Color On = Color.Red;
            Color Off = Color.FromHex("#5a5a5a");

            switch(OneNotDecadeNumber)
            {
                case '0':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = Off;
                        Segm5.BackgroundColor = Segm5.BorderColor = On;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                case '1':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = Off;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = Off;
                        Segm5.BackgroundColor = Segm5.BorderColor = Off;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = Off;
                    }
                    break;
                case '2':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = Off;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = On;
                        Segm6.BackgroundColor = Segm6.BorderColor = Off;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                case '3':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = Off;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = Off;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                case '4':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = Off;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = Off;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = Off;
                    }
                    break;
                case '5':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = Off;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = Off;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                case '6':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = Off;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = On;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                case '7':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = Off;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = Off;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = Off;
                    }
                    break;
                case '8':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = On;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                case '9':
                    {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = On;
                        Segm5.BackgroundColor = Segm5.BorderColor = Off;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                    }
                    break;
                default: {
                        Segm1.BackgroundColor = Segm1.BorderColor = On;
                        Segm2.BackgroundColor = Segm2.BorderColor = On;
                        Segm3.BackgroundColor = Segm3.BorderColor = On;
                        Segm4.BackgroundColor = Segm4.BorderColor = Off;
                        Segm5.BackgroundColor = Segm5.BorderColor = On;
                        Segm6.BackgroundColor = Segm6.BorderColor = On;
                        Segm7.BackgroundColor = Segm7.BorderColor = On;
                        
                    }
                    break;

            }

         

        }
    }
}