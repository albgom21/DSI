﻿#pragma checksum "C:\Users\adrim\Desktop\DSI\Proyecto\DSI_PROYECTO\DSI_PROYECTO\OpcionesMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "05184ADB350882C494894A4D55D09ECF"
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
            case 33: // OpcionesMenu.xaml line 441
                {
                    global::Windows.UI.Xaml.Controls.Button element33 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element33).Click += this.Principal;
                }
                break;
            case 34: // OpcionesMenu.xaml line 442
                {
                    global::Windows.UI.Xaml.Controls.Button element34 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element34).Click += this.X_Click;
                }
                break;
            case 35: // OpcionesMenu.xaml line 475
                {
                    this.borderEsp = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 36: // OpcionesMenu.xaml line 477
                {
                    this.besp = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.besp).Click += this.ToggleButton_Checked_esp;
                }
                break;
            case 37: // OpcionesMenu.xaml line 481
                {
                    this.borderCat = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 38: // OpcionesMenu.xaml line 483
                {
                    this.bcat = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.bcat).Click += this.ToggleButton_Checked_cat;
                }
                break;
            case 39: // OpcionesMenu.xaml line 487
                {
                    this.borderUk = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 40: // OpcionesMenu.xaml line 489
                {
                    this.buk = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buk).Click += this.ToggleButton_Checked_uk;
                }
                break;
            case 41: // OpcionesMenu.xaml line 469
                {
                    global::Windows.UI.Xaml.Controls.Slider element41 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element41).ValueChanged += this.Slider_ValueChanged_g;
                }
                break;
            case 42: // OpcionesMenu.xaml line 470
                {
                    global::Windows.UI.Xaml.Controls.Slider element42 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element42).ValueChanged += this.Slider_ValueChanged_m;
                }
                break;
            case 43: // OpcionesMenu.xaml line 471
                {
                    global::Windows.UI.Xaml.Controls.Slider element43 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element43).ValueChanged += this.Slider_ValueChanged_s;
                }
                break;
            case 44: // OpcionesMenu.xaml line 455
                {
                    this.vg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 45: // OpcionesMenu.xaml line 456
                {
                    this.vm = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 46: // OpcionesMenu.xaml line 457
                {
                    this.vs = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 47: // OpcionesMenu.xaml line 396
                {
                    this.B1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B1).Checked += this.Tienda;
                }
                break;
            case 48: // OpcionesMenu.xaml line 406
                {
                    this.B2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B2).Checked += this.Galeria_Mazos;
                }
                break;
            case 49: // OpcionesMenu.xaml line 416
                {
                    this.B3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B3).Checked += this.Principal;
                }
                break;
            case 50: // OpcionesMenu.xaml line 419
                {
                    this.B4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B4).Checked += this.Ranking;
                }
                break;
            case 51: // OpcionesMenu.xaml line 429
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

