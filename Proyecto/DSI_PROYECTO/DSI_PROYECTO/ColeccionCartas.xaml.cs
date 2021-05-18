using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
        public ObservableCollection<VMMazos_Grid> ListaMazos { get; set; } = new ObservableCollection<VMMazos_Grid>();
        public VMMazos_Grid mazoActual;

        public ColeccionCartas()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled; //Required si se quieren ignorar los límites de CacheSize

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                mazoActual = e.Parameter as VMMazos_Grid;
                // Cosntruye las listas de ModelView a partir de la lista Modelo 
                if (ListaCartas != null)
                    foreach (Cartas cartas in mazoActual.Cartas)
                    {
                        VMCartas VMitem = new VMCartas(cartas);
                        ListaCartas.Add(VMitem);
                    }
                MazoName.Text = mazoActual.Name;
            }

            if (ListaMazos != null)
                foreach (Mazos_Grid mazos in Model.GetAllMazos_Grid())
                {
                    VMMazos_Grid VMitem = new VMMazos_Grid(mazos);
                    ListaMazos.Add(VMitem);
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
            if (GridCartas != null)
            {
                GridCartas.Clear();
                foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                {
                    VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                    if (VMitem.Tipo == 's')
                        GridCartas.Add(VMitem);
                    else if ((bool)hbutton.IsChecked && VMitem.Tipo == 'h')
                        GridCartas.Add(VMitem);
                    else if ((bool)cbutton.IsChecked && VMitem.Tipo == 'c')
                        GridCartas.Add(VMitem);
                }
            }
        }

        private void sbutton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (GridCartas != null)
            {
                GridCartas.Clear();
                if (!(bool)hbutton.IsChecked && !(bool)cbutton.IsChecked)
                {
                    foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                    {
                        VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                        GridCartas.Add(VMitem);
                    }
                }
                else
                {
                    foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                    {
                        VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                        if ((bool)hbutton.IsChecked && VMitem.Tipo == 'h')
                            GridCartas.Add(VMitem);
                        else if ((bool)cbutton.IsChecked && VMitem.Tipo == 'c')
                            GridCartas.Add(VMitem);
                    }
                }
            }
        }

        private void hbutton_Checked(object sender, RoutedEventArgs e)
        {
            if (GridCartas != null)
            {
                GridCartas.Clear();
                foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                {
                    VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                    if (VMitem.Tipo == 'h')
                        GridCartas.Add(VMitem);
                    else if ((bool)sbutton.IsChecked && VMitem.Tipo == 's')
                        GridCartas.Add(VMitem);
                    else if ((bool)cbutton.IsChecked && VMitem.Tipo == 'c')
                        GridCartas.Add(VMitem);
                }
            }
        }

        private void hbutton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (GridCartas != null)
            {           
                GridCartas.Clear();
                if (!(bool)sbutton.IsChecked && !(bool)cbutton.IsChecked)
                {
                    foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                    {
                        VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                        GridCartas.Add(VMitem);
                    }
                }
                else
                {
                    foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                    {
                        VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                        if ((bool)sbutton.IsChecked && VMitem.Tipo == 's')
                            GridCartas.Add(VMitem);
                        else if ((bool)cbutton.IsChecked && VMitem.Tipo == 'c')
                            GridCartas.Add(VMitem);
                    }
                }
            }
        }

        private void cbutton_Checked(object sender, RoutedEventArgs e)
        {
            if (GridCartas != null)
            {
                GridCartas.Clear();
                foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                {
                    VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                    if (VMitem.Tipo == 'c')
                        GridCartas.Add(VMitem);
                    else if ((bool)hbutton.IsChecked && VMitem.Tipo == 'h')
                        GridCartas.Add(VMitem);
                    else if ((bool)sbutton.IsChecked && VMitem.Tipo == 's')
                        GridCartas.Add(VMitem);
                }
            }
        }

        private void cbutton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (GridCartas != null)
            {
                GridCartas.Clear();
                GridCartas.Clear();
                if (!(bool)hbutton.IsChecked && !(bool)sbutton.IsChecked)
                {
                    foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                    {
                        VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                        GridCartas.Add(VMitem);
                    }
                }
                else
                {
                    foreach (Cartas_Grid cartas in Model.GetAllCartas_Grid())
                    {
                        VMCartas_Grid VMitem = new VMCartas_Grid(cartas);
                        if ((bool)hbutton.IsChecked && VMitem.Tipo == 'h')
                            GridCartas.Add(VMitem);
                        else if ((bool)sbutton.IsChecked && VMitem.Tipo == 's')
                            GridCartas.Add(VMitem);
                    }
                }
            }
        }

        private void cartasGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMCartas_Grid item = e.ClickedItem as VMCartas_Grid;
            VMCartas cart = new VMCartas();
            cart.Nombre = item.Name;
            cart.cantidad = 1;
            bool encontrada = false;
            int i = 0;
            int borrar = -1;
            int nTotalCartas = 0;

            if (item.Tipo != 'c') //Si la carta no es crafteable se puede añadir al mazo
            {
                foreach (VMCartas cartas in ListaCartas)
                {
                    VMCartas VMitem = new VMCartas(cartas);
                    nTotalCartas += VMitem.cantidad;
                    if (VMitem.Nombre == item.Name)
                    {
                        cart.cantidad = VMitem.cantidad;
                        cart.cantidad += 1;

                        borrar = i;

                        //ListaCartas[i].cantidad += 1;                
                        encontrada = true;
                    }
                    i++;
                }
                if (!encontrada && nTotalCartas < 20)
                {
                    cart.cantidad = 1;
                    ListaCartas.Insert(0, cart);
                }
                else if (nTotalCartas < 20)
                {
                    ListaCartas.RemoveAt(borrar);
                    ListaCartas.Insert(0, cart);
                }

                if (mazoActual != null)
                {
                    mazoActual.Cartas.Clear();
                    foreach (VMCartas cartas in ListaCartas)
                        mazoActual.Cartas.Add(cartas);
                }
            }
        }

        private void cartasList_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMCartas item = e.ClickedItem as VMCartas;
            VMCartas cart = new VMCartas();
            cart.Nombre = item.Nombre;
            cart.cantidad = 1;
            bool encontrada = false;
            int i = 0;
            int borrar = -1;

            foreach (VMCartas cartas in ListaCartas)
            {
                VMCartas VMitem = new VMCartas(cartas);
                if (VMitem.Nombre == item.Nombre)
                {
                    cart.cantidad = VMitem.cantidad;
                    cart.cantidad -= 1;

                    borrar = i;

                    //ListaCartas[i].cantidad += 1;                
                    encontrada = true;
                }
                i++;
            }
            if (encontrada)
            {
                if (cart.cantidad == 0)
                    ListaCartas.RemoveAt(borrar);
                else
                {
                    ListaCartas.RemoveAt(borrar);
                    ListaCartas.Insert(0, cart);
                }
            }

            if (mazoActual != null)
            {
                mazoActual.Cartas.Clear();
                foreach (VMCartas cartas in ListaCartas)
                    mazoActual.Cartas.Add(cartas);
            }
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
                this.Frame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var mazos = Model.GetAllMazos_Grid();
            if (mazoActual == null)
            {
                Mazos_Grid newMazo = new Mazos_Grid();
                newMazo.Name = MazoName.Text;
                newMazo.Imagen = "Assets\\mazo1.png";
                newMazo.Cartas.Clear();
                foreach (VMCartas cartas in ListaCartas)
                    newMazo.Cartas.Add(cartas);

                mazos.Add(newMazo);
            }
            else
            {
                mazos.Clear();
                foreach (VMMazos_Grid m in ListaMazos)
                {
                    if (m == mazoActual)
                        mazos.Add(mazoActual);
                    else
                        mazos.Add(m);
                }
            }

            this.Frame.Navigate(typeof(GaleriaDeMazos));
        }

        private void MazoName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (mazoActual != null)
                mazoActual.Name = MazoName.Text;
        }
    }
}