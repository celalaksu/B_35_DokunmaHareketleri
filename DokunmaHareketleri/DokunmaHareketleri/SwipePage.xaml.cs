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
    public partial class SwipePage : ContentPage
    {
        public SwipePage()
        {
            InitializeComponent();
            var leftSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Left };
            leftSwipeGesture.Swiped += OnSwiped;
            var rightSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Right };
            rightSwipeGesture.Swiped += OnSwiped;
            var upSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Up };
            upSwipeGesture.Swiped += OnSwiped;
            var downSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Down };
            downSwipeGesture.Swiped += OnSwiped;

            boxView.GestureRecognizers.Add(leftSwipeGesture);
            boxView.GestureRecognizers.Add(rightSwipeGesture);
            boxView.GestureRecognizers.Add(upSwipeGesture);
            boxView.GestureRecognizers.Add(downSwipeGesture);
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    _label.Text = $"{e.Direction.ToString()} yönünde kaydırdınız";
                    break;
                case SwipeDirection.Right:
                    _label.Text = $"{e.Direction.ToString()} yönünde kaydırdınız";
                    break;
                case SwipeDirection.Up:
                    _label.Text = $"{e.Direction.ToString()} yönünde kaydırdınız";
                    break;
                case SwipeDirection.Down:
                    _label.Text = $"{e.Direction.ToString()} yönünde kaydırdınız";
                    break;
            }
        }
    }
}