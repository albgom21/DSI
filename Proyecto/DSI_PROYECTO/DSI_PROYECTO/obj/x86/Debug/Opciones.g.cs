﻿#pragma checksum "C:\Users\adrim\Desktop\DSI\Proyecto\DSI_PROYECTO\DSI_PROYECTO\Opciones.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F347756CF9EA33BF717512990DBDF528"
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
    partial class Opciones : 
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
            case 26: // Opciones.xaml line 323
                {
                    global::Windows.UI.Xaml.Controls.Button element26 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element26).Click += this.X_Click;
                }
                break;
            case 27: // Opciones.xaml line 356
                {
                    this.besp = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.besp).Checked += this.ToggleButton_Checked_esp;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.besp).Unchecked += this.besp_Unchecked;
                }
                break;
            case 28: // Opciones.xaml line 360
                {
                    this.bcat = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.bcat).Checked += this.ToggleButton_Checked_cat;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.bcat).Unchecked += this.bcat_Unchecked;
                }
                break;
            case 29: // Opciones.xaml line 364
                {
                    this.buk = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.buk).Checked += this.ToggleButton_Checked_uk;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.buk).Unchecked += this.buk_Unchecked;
                }
                break;
            case 30: // Opciones.xaml line 350
                {
                    global::Windows.UI.Xaml.Controls.Slider element30 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element30).ValueChanged += this.Slider_ValueChanged_g;
                }
                break;
            case 31: // Opciones.xaml line 351
                {
                    global::Windows.UI.Xaml.Controls.Slider element31 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element31).ValueChanged += this.Slider_ValueChanged_m;
                }
                break;
            case 32: // Opciones.xaml line 352
                {
                    global::Windows.UI.Xaml.Controls.Slider element32 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)element32).ValueChanged += this.Slider_ValueChanged_s;
                }
                break;
            case 33: // Opciones.xaml line 336
                {
                    this.vg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 34: // Opciones.xaml line 337
                {
                    this.vm = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 35: // Opciones.xaml line 338
                {
                    this.vs = (global::Windows.UI.Xaml.Controls.Image)(target);
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

