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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_PROYECTO
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PantallaLogros : Page
    {
        public ObservableCollection<VM_Logro> ListaLogros { get; } = new ObservableCollection<VM_Logro>();
        public PantallaLogros()
        {
            this.InitializeComponent();
        }

        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PantallaPrincipal));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaLogros != null)
                foreach (Logro logro in ModelLogro.getAllLogros())
                {
                    VM_Logro VMitem = new VM_Logro(logro);
                    ListaLogros.Add(VMitem);
                }
            base.OnNavigatedTo(e);
        }


    }
}
