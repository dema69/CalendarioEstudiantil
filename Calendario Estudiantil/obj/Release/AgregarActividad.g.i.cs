﻿#pragma checksum "C:\Users\Dema op\Desktop\Calendario Estudiantil\Calendario Estudiantil\AgregarActividad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53957A93C428445CD8754960E18323F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34003
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Calendario_Estudiantil {
    
    
    public partial class AgregarActividad : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.DatePicker Fecha_picker;
        
        internal Microsoft.Phone.Controls.TimePicker Time_Picker;
        
        internal Microsoft.Phone.Controls.ListPicker Tipo;
        
        internal System.Windows.Controls.TextBox comentariosActividad;
        
        internal System.Windows.Controls.Button btnGuardarActividad;
        
        internal System.Windows.Controls.Button btnAtras;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Calendario%20Estudiantil;component/AgregarActividad.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Fecha_picker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("Fecha_picker")));
            this.Time_Picker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("Time_Picker")));
            this.Tipo = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Tipo")));
            this.comentariosActividad = ((System.Windows.Controls.TextBox)(this.FindName("comentariosActividad")));
            this.btnGuardarActividad = ((System.Windows.Controls.Button)(this.FindName("btnGuardarActividad")));
            this.btnAtras = ((System.Windows.Controls.Button)(this.FindName("btnAtras")));
        }
    }
}

