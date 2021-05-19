﻿using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_PROYECTO
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Opciones : Page
    {    
        public Opciones()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled; //Required si se quieren ignorar los límites de CacheSize
            if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "es")
                borderEsp.Visibility = Visibility.Visible;
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "en")
                borderUk.Visibility = Visibility.Visible;
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "ca")
                borderCat.Visibility = Visibility.Visible;
        }

        private void Slider_ValueChanged_g(object sender, RangeBaseValueChangedEventArgs e)
        {
            double new_value = e.NewValue;
            double old_value = e.OldValue;

            if (new_value >= 80 && !(old_value >= 80))
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz.png";
                vg.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            else if (new_value > 0 && new_value < 80 && !(old_value > 0 && old_value < 80))
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz1.png";
                vg.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            else if (new_value == 0)
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz0.png";
                vg.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
        }

        private void Slider_ValueChanged_m(object sender, RangeBaseValueChangedEventArgs e)
        {
            double new_value = e.NewValue;     
            double old_value = e.OldValue;     

            if (new_value >= 80 && !(old_value >= 80))
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz.png";
                vm.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            else if (new_value > 0 && new_value < 80 && !(old_value > 0 && old_value < 80))
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz1.png";
                vm.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            else if(new_value == 0)
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz0.png";
                vm.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
        }

        private void Slider_ValueChanged_s(object sender, RangeBaseValueChangedEventArgs e)
        {
            double new_value = e.NewValue;
            double old_value = e.OldValue;

            if (new_value >= 80 && !(old_value >= 80))
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz.png";
                vs.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            else if (new_value > 0 && new_value < 80 && !(old_value > 0 && old_value < 80))
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz1.png";
                vs.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
            else if (new_value == 0)
            {
                string s = System.IO.Directory.GetCurrentDirectory() + "\\" + "Assets/altavoz0.png";
                vs.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            }
        } 

        private void ToggleButton_Checked_esp(object sender, RoutedEventArgs e)
        {
            Frame.CacheSize = 0;
            if ((sender as Button)?.Tag is string tag)
            {
                // Change the app language
                Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = tag;

                // Clear the back-navigation stack, and send the user to MainPage
                // This is done because any loaded pages (MainPage(in back-stack) and LanguageSettings (current active page))
                // will stay in the previous language until reloaded.
                Frame.BackStack.Clear();
                Frame.Navigate(typeof(Opciones));               
            }
        }

        private void ToggleButton_Checked_cat(object sender, RoutedEventArgs e)
        {
            Frame.CacheSize = 0;
            if ((sender as Button)?.Tag is string tag)
            {
                // Change the app language
                Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = tag;

                // Clear the back-navigation stack, and send the user to MainPage
                // This is done because any loaded pages (MainPage(in back-stack) and LanguageSettings (current active page))
                // will stay in the previous language until reloaded.
                Frame.BackStack.Clear();
                Frame.Navigate(typeof(Opciones));
            }
        }

        private void ToggleButton_Checked_uk(object sender, RoutedEventArgs e)
        {
            Frame.CacheSize = 0;
            if ((sender as Button)?.Tag is string tag)
            {
                // Change the app language
                Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = tag;

                // Clear the back-navigation stack, and send the user to MainPage
                // This is done because any loaded pages (MainPage(in back-stack) and LanguageSettings (current active page))
                // will stay in the previous language until reloaded.
                Frame.BackStack.Clear();
                Frame.Navigate(typeof(Opciones));
            }
        }

        private void Rendirse_Click(object sender, RoutedEventArgs e)
        {
          
            this.Frame.Navigate(typeof(PantallaPrincipal));
            if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "es")
                rendirse.Content = "RENDIRSE";
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "en")
                rendirse.Content = "GIVE UP";
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "ca")
                rendirse.Content = "RENDIR";
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
        
            this.Frame.Navigate(typeof(InGame));
            if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "es")
                salir.Content = "SALIR";
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "en")
                salir.Content = "EXIT";
            else if (Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride == "ca")
                salir.Content = "SORTIR";
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {       
            this.Frame.Navigate(typeof(InGame));
        }
    }
}