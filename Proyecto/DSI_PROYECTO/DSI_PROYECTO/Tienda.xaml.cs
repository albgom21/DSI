using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Tienda : Page
    {
        public Tienda()
        {
            this.InitializeComponent();

            dinero.Text = Model.getDinero().ToString();

            var compradas = Model.GetCartasCompradas();

            if (compradas[0]) comprar1.Visibility = Visibility.Visible;
            if (compradas[1]) comprar2.Visibility = Visibility.Visible;
            if (compradas[2]) comprar3.Visibility = Visibility.Visible;
            if (compradas[3]) comprar4.Visibility = Visibility.Visible;

            // Timer
            DispatcherTimer tim = new DispatcherTimer();
            timer_Tick(new object(), new object());
            tim.Interval = TimeSpan.FromSeconds(1);
            tim.Tick += timer_Tick;
            tim.Start();
        }

        private void timer_Tick(object sender, object e)
        {
            int h = 23 - DateTime.Now.Hour;
            string hours = h < 10 ? ("0" + h.ToString()) : h.ToString();

            int m = 59 - DateTime.Now.Minute;
            string min = m < 10 ? ("0" + m.ToString()) : m.ToString();

            int s = 59 - DateTime.Now.Second;
            string sec = s < 10 ? ("0" + s.ToString()) : s.ToString();

            string time = hours + ":" + min + ":" + sec;
            timer.Text = time;
        }

        private void Button_Oferta1(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            miDinero += 300;

            Model.setDinero(miDinero);

            dinero.Text = miDinero.ToString();
        }

        private void Button_Oferta2(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            miDinero += 800;

            Model.setDinero(miDinero);

            dinero.Text = miDinero.ToString();
        }

        private void Button_Oferta3(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            miDinero += 1450;

            Model.setDinero(miDinero);

            dinero.Text = miDinero.ToString();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            B1.IsChecked = true;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GaleriaDeMazos));
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaPrincipal));
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaRanking));
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpcionesMenu));
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            if (comprar1.Visibility == Visibility.Collapsed && miDinero >= 125)
            {
                miDinero -= 125;

                Model.setDinero(miDinero);

                dinero.Text = miDinero.ToString();

                Model.GetCartasCompradas()[0] = true;

                comprar1.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            if (comprar2.Visibility == Visibility.Collapsed && miDinero >= 125)
            {
                miDinero -= 125;

                Model.setDinero(miDinero);

                dinero.Text = miDinero.ToString();

                Model.GetCartasCompradas()[1] = true;

                comprar2.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            if (comprar3.Visibility == Visibility.Collapsed && miDinero >= 125)
            {
                miDinero -= 125;

                Model.setDinero(miDinero);

                dinero.Text = miDinero.ToString();

                Model.GetCartasCompradas()[2] = true;

                comprar3.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int miDinero = Model.getDinero();

            if (comprar4.Visibility == Visibility.Collapsed && miDinero >= 125)
            {
                miDinero -= 125;

                Model.setDinero(miDinero);

                dinero.Text = miDinero.ToString();

                Model.GetCartasCompradas()[3] = true;

                comprar4.Visibility = Visibility.Visible;
            }
        }
    }
}
