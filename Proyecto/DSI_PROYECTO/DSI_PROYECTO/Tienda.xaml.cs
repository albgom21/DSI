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

            // Timer
            DispatcherTimer tim = new DispatcherTimer();
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
            double miDinero = 0;
            int length = dinero.Text.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                int c = dinero.Text[i] - '0';
                miDinero += c * (Math.Pow(10, length - i));
            }

            miDinero += 300;

            dinero.Text = miDinero.ToString();
        }

        private void Button_Oferta2(object sender, RoutedEventArgs e)
        {
            double miDinero = 0;
            int length = dinero.Text.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                int c = dinero.Text[i] - '0';
                miDinero += c * (Math.Pow(10, length - i));
            }

            miDinero += 800;

            dinero.Text = miDinero.ToString();
        }

        private void Button_Oferta3(object sender, RoutedEventArgs e)
        {
            double miDinero = 0;
            int length = dinero.Text.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                int c = dinero.Text[i] - '0';
                miDinero += c * (Math.Pow(10, length - i));
            }

            miDinero += 1450;

            dinero.Text = miDinero.ToString();
        }
    }
}
