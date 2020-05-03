using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DokunmaHareketleri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PanPage : ContentPage
    {
        double x, y;

        public PanPage()
        {
            InitializeComponent();
            var panHareketiRecognizer = new PanGestureRecognizer();
            panHareketiRecognizer.PanUpdated += PanHareketiOluncacalis;

            resimImage.GestureRecognizers.Add(panHareketiRecognizer);
        }


        private void PanHareketiOluncacalis(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    // Translate and ensure we don't pan beyond the wrapped user interface element bounds.
                    Content.TranslationX =
                      Math.Max(Math.Min(0, x + e.TotalX), -Math.Abs(Content.Width - App.ScreenWidth));
                    Content.TranslationY =
                      Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs(Content.Height - App.ScreenHeight));
                    break;

                case GestureStatus.Completed:
                    // Store the translation applied during the pan
                    x = Content.TranslationX;
                    y = Content.TranslationY;
                    break;
            }
        }
    }
}