﻿#pragma checksum "C:\Users\skoon\Desktop\dsiclon\DSI\Proyecto\DSI_PROYECTO\DSI_PROYECTO\ModosDeJuego.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E6FCD5B04E268338EF5F6861E040D531"
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
    partial class ModosDeJuego : 
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
        private class ModosDeJuego_obj58_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IModosDeJuego_Bindings
        {
            private global::DSI_PROYECTO.VMMazos_Grid dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj58;
            private global::Windows.UI.Xaml.Controls.Image obj59;
            private global::Windows.UI.Xaml.Controls.TextBlock obj60;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj59SourceDisabled = false;
            private static bool isobj60TextDisabled = false;

            public ModosDeJuego_obj58_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 24)
                {
                    isobj59SourceDisabled = true;
                }
                else if (lineNumber == 17 && columnNumber == 28)
                {
                    isobj60TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 58: // ModosDeJuego.xaml line 15
                        this.obj58 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 59: // ModosDeJuego.xaml line 16
                        this.obj59 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 60: // ModosDeJuego.xaml line 17
                        this.obj60 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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
                            (this.obj58.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DSI_PROYECTO.VMMazos_Grid) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IModosDeJuego_Bindings

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
                    this.dataRoot = (global::DSI_PROYECTO.VMMazos_Grid)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DSI_PROYECTO.VMMazos_Grid obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Img(obj.Img, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Img(global::Windows.UI.Xaml.Controls.Image obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Img_Source(obj.Source, phase);
                    }
                }
            }
            private void Update_Img_Source(global::Windows.UI.Xaml.Media.ImageSource obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ModosDeJuego.xaml line 16
                    if (!isobj59SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj59, obj, null);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ModosDeJuego.xaml line 17
                    if (!isobj60TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj60, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ModosDeJuego_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IModosDeJuego_Bindings
        {
            private global::DSI_PROYECTO.ModosDeJuego dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj68;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj68ItemsSourceDisabled = false;

            public ModosDeJuego_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 790 && columnNumber == 19)
                {
                    isobj68ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 68: // ModosDeJuego.xaml line 786
                        this.obj68 = (global::Windows.UI.Xaml.Controls.GridView)target;
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

            // IModosDeJuego_Bindings

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
                    this.dataRoot = (global::DSI_PROYECTO.ModosDeJuego)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DSI_PROYECTO.ModosDeJuego obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_GridMazos(obj.GridMazos, phase);
                    }
                }
            }
            private void Update_GridMazos(global::System.Collections.ObjectModel.ObservableCollection<global::DSI_PROYECTO.VMMazos_Grid> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ModosDeJuego.xaml line 786
                    if (!isobj68ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj68, obj, null);
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
            case 61: // ModosDeJuego.xaml line 723
                {
                    global::Windows.UI.Xaml.Controls.Button element61 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element61).Click += this.X_Click;
                }
                break;
            case 62: // ModosDeJuego.xaml line 726
                {
                    global::Windows.UI.Xaml.Controls.Button element62 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element62).Click += this.Jugar_Click;
                }
                break;
            case 63: // ModosDeJuego.xaml line 734
                {
                    this.descripcion = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 64: // ModosDeJuego.xaml line 737
                {
                    this.nbutton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.nbutton).Checked += this.nbutton_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.nbutton).Unchecked += this.restartMazos;
                }
                break;
            case 65: // ModosDeJuego.xaml line 743
                {
                    this.rbutton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.rbutton).Checked += this.rbutton_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.rbutton).Unchecked += this.restartMazos;
                }
                break;
            case 66: // ModosDeJuego.xaml line 749
                {
                    this.sbutton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.sbutton).Checked += this.sbutton_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.sbutton).Unchecked += this.restartMazos;
                }
                break;
            case 67: // ModosDeJuego.xaml line 755
                {
                    this.obutton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.obutton).Checked += this.obutton_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.obutton).Unchecked += this.restartMazos;
                }
                break;
            case 68: // ModosDeJuego.xaml line 786
                {
                    this.mazosGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.mazosGrid).ItemClick += this.mazosGrid_ItemClick;
                }
                break;
            case 69: // ModosDeJuego.xaml line 800
                {
                    this.mazoName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 70: // ModosDeJuego.xaml line 801
                {
                    this.MazoSel = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 71: // ModosDeJuego.xaml line 805
                {
                    this.a = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 72: // ModosDeJuego.xaml line 764
                {
                    this.B1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B1).Checked += this.Tienda;
                }
                break;
            case 73: // ModosDeJuego.xaml line 768
                {
                    this.B2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B2).Checked += this.Galeria_Mazos;
                }
                break;
            case 74: // ModosDeJuego.xaml line 772
                {
                    this.B3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B3).Unchecked += this.B3_Unchecked;
                }
                break;
            case 75: // ModosDeJuego.xaml line 775
                {
                    this.B4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B4).Checked += this.Ranking;
                }
                break;
            case 76: // ModosDeJuego.xaml line 779
                {
                    this.B5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B5).Checked += this.Opciones;
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
            case 1: // ModosDeJuego.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ModosDeJuego_obj1_Bindings bindings = new ModosDeJuego_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 58: // ModosDeJuego.xaml line 15
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element58 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    ModosDeJuego_obj58_Bindings bindings = new ModosDeJuego_obj58_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element58.DataContext);
                    element58.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element58, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element58, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

