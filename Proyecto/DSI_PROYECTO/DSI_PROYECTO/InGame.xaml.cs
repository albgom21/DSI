using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_PROYECTO
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class InGame : Page
    {

        bool botIzq = false;
        PointerPoint ptrPt;

        public InGame()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Image mazo = e.Parameter as Image;
            if (mazo != null)
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + mazo.Source;
                h.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            canvas.PointerPressed += new PointerEventHandler(Target_PointerPressed);
            canvas.PointerReleased += new PointerEventHandler(Target_PointerReleased);

        }

        void Target_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ptrPt = e.GetCurrentPoint(canvas);
            if (ptrPt.Properties.IsLeftButtonPressed) botIzq = true;
        }

        private void Target_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            ptrPt = e.GetCurrentPoint(canvas);
            if (!ptrPt.Properties.IsLeftButtonPressed) botIzq = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opciones));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            historial.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            historial.Visibility = Visibility.Collapsed;
        }

        private void C1_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (botIzq)
            {
                ptrPt = e.GetCurrentPoint(canvas);
                C1.SetValue(Canvas.LeftProperty, ptrPt.Position.X - C1.Width / 2);
                C1.SetValue(Canvas.TopProperty, ptrPt.Position.Y - C1.Height / 2);
            }
        }

        private void C2_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (botIzq)
            {
                ptrPt = e.GetCurrentPoint(canvas);
                C2.SetValue(Canvas.LeftProperty, ptrPt.Position.X - C2.Width / 2);
                C2.SetValue(Canvas.TopProperty, ptrPt.Position.Y - C2.Height / 2);
            }
        }

        private void C3_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (botIzq)
            {
                ptrPt = e.GetCurrentPoint(canvas);
                C3.SetValue(Canvas.LeftProperty, ptrPt.Position.X - C3.Width / 2);
                C3.SetValue(Canvas.TopProperty, ptrPt.Position.Y - C3.Height / 2);
            }
        }

        private void C4_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (botIzq)
            {
                ptrPt = e.GetCurrentPoint(canvas);
                C4.SetValue(Canvas.LeftProperty, ptrPt.Position.X - C4.Width / 2);
                C4.SetValue(Canvas.TopProperty, ptrPt.Position.Y - C4.Height / 2);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mana.Value = (mana.Value + 1) > 10 ? 10 : (mana.Value + 1);
            manaText.Text = mana.Value.ToString();
        }

        private void Canvas_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            MazoBot.Visibility = Visibility.Visible;
        }

        private void Canvas_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            MazoBot.Visibility = Visibility.Collapsed;
        }

        private void Canvas_PointerEntered_1(object sender, PointerRoutedEventArgs e)
        {
            MazoTop.Visibility = Visibility.Visible;
        }

        private void Canvas_PointerExited_1(object sender, PointerRoutedEventArgs e)
        {
            MazoTop.Visibility = Visibility.Collapsed;
        }
    }
}
