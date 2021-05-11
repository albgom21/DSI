using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace PrototipoXAML
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PantallaPrincipal : Page
    {
        public ObservableCollection<ViewModelAmigos> ListaAmigos { get; } = new ObservableCollection<ViewModelAmigos>();
        public PantallaPrincipal()
        {
            this.InitializeComponent();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaRanking));
        }

        private void Logros_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaLogros));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaAmigos != null)
                foreach (Amigo amigo in ModelA.getAllAmigos())
                {
                    ViewModelAmigos VMitem = new ViewModelAmigos(amigo);
                    ListaAmigos.Add(VMitem);
                }
            base.OnNavigatedTo(e);
        }
    }
}
