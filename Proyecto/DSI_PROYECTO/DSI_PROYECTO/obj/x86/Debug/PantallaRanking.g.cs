﻿#pragma checksum "C:\Users\skoon\Desktop\dsiclon\DSI\Proyecto\DSI_PROYECTO\DSI_PROYECTO\PantallaRanking.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C15802DB0EA9011F53C252FA56EC2CC8"
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
    partial class PantallaRanking : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PantallaRanking_obj10_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPantallaRanking_Bindings
        {
            private global::DSI_PROYECTO.ViewModelRanking dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj10;
            private global::Windows.UI.Xaml.Controls.ContentControl obj11;
            private global::Windows.UI.Xaml.Controls.Image obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj11ContentDisabled = false;
            private static bool isobj12SourceDisabled = false;
            private static bool isobj13TextDisabled = false;
            private static bool isobj14TextDisabled = false;
            private static bool isobj15TextDisabled = false;

            public PantallaRanking_obj10_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 20 && columnNumber == 33)
                {
                    isobj11ContentDisabled = true;
                }
                else if (lineNumber == 21 && columnNumber == 24)
                {
                    isobj12SourceDisabled = true;
                }
                else if (lineNumber == 22 && columnNumber == 28)
                {
                    isobj13TextDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 28)
                {
                    isobj14TextDisabled = true;
                }
                else if (lineNumber == 24 && columnNumber == 28)
                {
                    isobj15TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // PantallaRanking.xaml line 13
                        this.obj10 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 11: // PantallaRanking.xaml line 20
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ContentControl)target;
                        break;
                    case 12: // PantallaRanking.xaml line 21
                        this.obj12 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 13: // PantallaRanking.xaml line 22
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14: // PantallaRanking.xaml line 23
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15: // PantallaRanking.xaml line 24
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj10.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DSI_PROYECTO.ViewModelRanking) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IPantallaRanking_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DSI_PROYECTO.ViewModelRanking)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DSI_PROYECTO.ViewModelRanking obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CCImg1(obj.CCImg1, phase);
                        this.Update_Imagen2(obj.Imagen2, phase);
                        this.Update_Nombre(obj.Nombre, phase);
                        this.Update_Nivel(obj.Nivel, phase);
                        this.Update_Rango(obj.Rango, phase);
                    }
                }
            }
            private void Update_CCImg1(global::Windows.UI.Xaml.Controls.ContentControl obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PantallaRanking.xaml line 20
                    if (!isobj11ContentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj11, obj, null);
                    }
                }
            }
            private void Update_Imagen2(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PantallaRanking.xaml line 21
                    if (!isobj12SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj12, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_Nombre(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PantallaRanking.xaml line 22
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj, null);
                    }
                }
            }
            private void Update_Nivel(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PantallaRanking.xaml line 23
                    if (!isobj14TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj.ToString(), null);
                    }
                }
            }
            private void Update_Rango(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PantallaRanking.xaml line 24
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PantallaRanking_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPantallaRanking_Bindings
        {
            private global::DSI_PROYECTO.PantallaRanking dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj22;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj22ItemsSourceDisabled = false;

            public PantallaRanking_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 186 && columnNumber == 19)
                {
                    isobj22ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 22: // PantallaRanking.xaml line 182
                        this.obj22 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IPantallaRanking_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DSI_PROYECTO.PantallaRanking)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DSI_PROYECTO.PantallaRanking obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ListaRanking(obj.ListaRanking, phase);
                    }
                }
            }
            private void Update_ListaRanking(global::System.Collections.ObjectModel.ObservableCollection<global::DSI_PROYECTO.ViewModelRanking> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // PantallaRanking.xaml line 182
                    if (!isobj22ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj22, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 11: // PantallaRanking.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.ContentControl element11 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)element11).PointerPressed += this.Galeria_Click;
                }
                break;
            case 16: // PantallaRanking.xaml line 163
                {
                    this.Atras = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Atras).Click += this.Atras_Click;
                }
                break;
            case 17: // PantallaRanking.xaml line 168
                {
                    this.RankingT = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // PantallaRanking.xaml line 173
                {
                    this.NombreT = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // PantallaRanking.xaml line 174
                {
                    this.NivelT = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // PantallaRanking.xaml line 175
                {
                    this.RangoT = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // PantallaRanking.xaml line 176
                {
                    this.MazoT = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22: // PantallaRanking.xaml line 182
                {
                    this.ImageGridView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 23: // PantallaRanking.xaml line 141
                {
                    this.B1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B1).Click += this.Tienda_Click;
                }
                break;
            case 24: // PantallaRanking.xaml line 145
                {
                    this.B2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B2).Click += this.Galeria_Click;
                }
                break;
            case 25: // PantallaRanking.xaml line 149
                {
                    this.B3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B3).Click += this.PantallaPrincipal_Click;
                }
                break;
            case 26: // PantallaRanking.xaml line 152
                {
                    this.B4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 27: // PantallaRanking.xaml line 156
                {
                    this.B5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B5).Click += this.Opciones_Click;
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
            switch(connectionId)
            {
            case 1: // PantallaRanking.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    PantallaRanking_obj1_Bindings bindings = new PantallaRanking_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 10: // PantallaRanking.xaml line 13
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element10 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    PantallaRanking_obj10_Bindings bindings = new PantallaRanking_obj10_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element10.DataContext);
                    element10.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element10, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element10, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

