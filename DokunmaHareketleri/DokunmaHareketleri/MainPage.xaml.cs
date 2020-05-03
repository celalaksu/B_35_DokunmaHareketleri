using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DokunmaHareketleri
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int dokunmaSayisi = 0;

        public MainPage()
        {
            InitializeComponent();

            var dokunmaHareketiRecognizer = new TapGestureRecognizer();
            dokunmaHareketiRecognizer.Tapped += DokunmaOluncaCalis;
            resimImage.GestureRecognizers.Add(dokunmaHareketiRecognizer);
            dokunmaHareketiRecognizer.NumberOfTapsRequired = 1;
        }

        private void DokunmaOluncaCalis(object sender, EventArgs e)
        {
            double scale = Content.Scale;
            dokunmaSayisi++;
            //var resimGorunumu = (Image)sender;
            // watch the monkey go from color to black&white!
            if (dokunmaSayisi % 2 == 0)
            {
                resimImage.Source = "xamarin.jpg";
            }
            else
            {
                resimImage.Source = "xamarin_monkey.png";
            }
        }

    }
}
