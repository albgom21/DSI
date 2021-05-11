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
    public sealed partial class ColeccionCartas : Page
    {
        public ObservableCollection<VMCartas> ListaCartas { get; } = new ObservableCollection<VMCartas>();
        public ObservableCollection<VMCartas_Grid> GridCartas { get; } = new ObservableCollection<VMCartas_Grid>();

        public ColeccionCartas()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaCartas != null)
                foreach (Cartas cartas in Model.GetAllCartas())
                {
                    VMCartas VMitem = new VMCartas(cartas);
                    ListaCartas.Add(VMitem);
                }

            if (GridCartas != null)
                foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                {
                    VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                    GridCartas.Add(VMitem);
                }
            base.OnNavigatedTo(e);     
        }

        private void sbutton_Checked(object sender, RoutedEventArgs e)
        {
            hbutton.IsChecked = false;
            cbutton.IsChecked = false;
        }

        private void hbutton_Checked(object sender, RoutedEventArgs e)
        {
            sbutton.IsChecked = false;
            cbutton.IsChecked = false;
        }      

        private void cbutton_Checked(object sender, RoutedEventArgs e)
        {
            hbutton.IsChecked = false;
            sbutton.IsChecked = false;
        }
    }
}