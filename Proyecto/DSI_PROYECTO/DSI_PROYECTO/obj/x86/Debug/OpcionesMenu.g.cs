﻿#pragma checksum "C:\Users\adrim\Desktop\DSI\Proyecto\DSI_PROYECTO\DSI_PROYECTO\OpcionesMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "805160C82F9D974DCD5CBC22BDAE457B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSI_PROYECTO
{
    partial class OpcionesMenu : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 25: // OpcionesMenu.xaml line 327
                {
                    global::Windows.UI.Xaml.Controls.Button element25 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element25).Click += this.Principal;
                }
                break;
            case 26: // OpcionesMenu.xaml line 328
                {
                    global::Windows.UI.Xaml.Controls.Button element26 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element26).Click += this.X_Click;
                }
                break;
            case 27: // OpcionesMenu.xaml line 361
                {
                    this.borderEsp = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 28: // OpcionesMenu.xaml line 362
                {
                    this.besp = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.besp).Click += this.SetIdioma;
                }
                break;
            case 29: // OpcionesMenu.xaml line 366
                {
                    this.borderCat = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 30: // OpcionesMenu.xaml line 367
                {
                    this.bcat = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.bcat).Click += this.SetIdioma;
                }
                break;
            case 31: // OpcionesMenu.xaml line 371
                {
                    this.borderUk = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 32: // OpcionesMenu.xaml line 372
                {
                    this.buk = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buk).Click += this.SetIdioma;
                }
                break;
            case 33: // OpcionesMenu.xaml line 354
                {
                    global::Windows.UI.Xaml.Controls.Slider element33 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element33).ValueChanged += this.Slider_ValueChanged_g;
                }
                break;
            case 34: // OpcionesMenu.xaml line 355
                {
                    global::Windows.UI.Xaml.Controls.Slider element34 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element34).ValueChanged += this.Slider_ValueChanged_m;
                }
                break;
            case 35: // OpcionesMenu.xaml line 356
                {
                    global::Windows.UI.Xaml.Controls.Slider element35 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element35).ValueChanged += this.Slider_ValueChanged_s;
                }
                break;
            case 36: // OpcionesMenu.xaml line 342
                {
                    this.vg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 37: // OpcionesMenu.xaml line 343
                {
                    this.vm = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 38: // OpcionesMenu.xaml line 344
                {
                    this.vs = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 39: // OpcionesMenu.xaml line 302
                {
                    this.B1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B1).Checked += this.Tienda;
                }
                break;
            case 40: // OpcionesMenu.xaml line 306
                {
                    this.B2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B2).Checked += this.Galeria_Mazos;
                }
                break;
            case 41: // OpcionesMenu.xaml line 310
                {
                    this.B3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B3).Checked += this.Principal;
                }
                break;
            case 42: // OpcionesMenu.xaml line 313
                {
                    this.B4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B4).Checked += this.Ranking;
                }
                break;
            case 43: // OpcionesMenu.xaml line 317
                {
                    this.B5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B5).Unchecked += this.B5_Unchecked;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

