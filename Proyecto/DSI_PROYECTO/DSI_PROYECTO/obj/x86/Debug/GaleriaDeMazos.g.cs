﻿#pragma checksum "C:\Users\adrim\Desktop\DSI\Proyecto\DSI_PROYECTO\DSI_PROYECTO\GaleriaDeMazos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EFD4E3454AAE3D00E8361C660B7601BA"
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
    partial class GaleriaDeMazos : 
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
        private class GaleriaDeMazos_obj52_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGaleriaDeMazos_Bindings
        {
            private global::DSI_PROYECTO.VMMazos_Grid dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj52;
            private global::Windows.UI.Xaml.Controls.Image obj53;
            private global::Windows.UI.Xaml.Controls.TextBlock obj54;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj53SourceDisabled = false;
            private static bool isobj54TextDisabled = false;

            public GaleriaDeMazos_obj52_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 24)
                {
                    isobj53SourceDisabled = true;
                }
                else if (lineNumber == 18 && columnNumber == 28)
                {
                    isobj54TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 52: // GaleriaDeMazos.xaml line 16
                        this.obj52 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 53: // GaleriaDeMazos.xaml line 17
                        this.obj53 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 54: // GaleriaDeMazos.xaml line 18
                        this.obj54 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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
                            (this.obj52.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::DSI_PROYECTO.VMMazos_Grid) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IGaleriaDeMazos_Bindings

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
                    // GaleriaDeMazos.xaml line 17
                    if (!isobj53SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj53, obj, null);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // GaleriaDeMazos.xaml line 18
                    if (!isobj54TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj54, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class GaleriaDeMazos_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGaleriaDeMazos_Bindings
        {
            private global::DSI_PROYECTO.GaleriaDeMazos dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj55;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj55ItemsSourceDisabled = false;

            public GaleriaDeMazos_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 642 && columnNumber == 69)
                {
                    isobj55ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 55: // GaleriaDeMazos.xaml line 641
                        this.obj55 = (global::Windows.UI.Xaml.Controls.GridView)target;
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

            // IGaleriaDeMazos_Bindings

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
                    this.dataRoot = (global::DSI_PROYECTO.GaleriaDeMazos)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DSI_PROYECTO.GaleriaDeMazos obj, int phase)
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
                    // GaleriaDeMazos.xaml line 641
                    if (!isobj55ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj55, obj, null);
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
            case 55: // GaleriaDeMazos.xaml line 641
                {
                    this.mazosGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.mazosGrid).ItemClick += this.mazosGrid_ItemClick;
                }
                break;
            case 56: // GaleriaDeMazos.xaml line 646
                {
                    global::Windows.UI.Xaml.Controls.Button element56 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element56).Click += this.Go_Coleccion;
                }
                break;
            case 57: // GaleriaDeMazos.xaml line 651
                {
                    global::Windows.UI.Xaml.Controls.Button element57 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element57).Click += this.Go_Coleccion_Edit;
                }
                break;
            case 58: // GaleriaDeMazos.xaml line 649
                {
                    this.MazoPrincipal = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 59: // GaleriaDeMazos.xaml line 634
                {
                    this.BN = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.BN).Click += this.Mazos_Normal;
                }
                break;
            case 60: // GaleriaDeMazos.xaml line 635
                {
                    this.BR = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.BR).Click += this.Mazos_Ranked;
                }
                break;
            case 61: // GaleriaDeMazos.xaml line 636
                {
                    this.BS = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.BS).Click += this.Mazos_SpellBreak;
                }
                break;
            case 62: // GaleriaDeMazos.xaml line 637
                {
                    this.BO = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.BO).Click += this.Mazos_Order;
                }
                break;
            case 63: // GaleriaDeMazos.xaml line 586
                {
                    this.B1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B1).Click += this.Go_Tienda;
                }
                break;
            case 64: // GaleriaDeMazos.xaml line 596
                {
                    this.B2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 65: // GaleriaDeMazos.xaml line 606
                {
                    this.B3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.B3).Click += this.Go_Pantalla_Principal;
                }
                break;
            case 66: // GaleriaDeMazos.xaml line 610
                {
                    this.B4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 67: // GaleriaDeMazos.xaml line 620
                {
                    this.B5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
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
            case 1: // GaleriaDeMazos.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    GaleriaDeMazos_obj1_Bindings bindings = new GaleriaDeMazos_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 52: // GaleriaDeMazos.xaml line 16
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element52 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    GaleriaDeMazos_obj52_Bindings bindings = new GaleriaDeMazos_obj52_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element52.DataContext);
                    element52.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element52, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element52, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

