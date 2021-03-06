﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

#if NETFX_CORE
using global::Windows.UI.Xaml.Markup;
#elif !PCL && !XAMARIN && !XAMARIN_FORMS
using System.Windows.Markup;
#endif

// All other assembly info is defined in SharedAssembly.cs

[assembly: AssemblyTitle("Catel.MVVM")]
[assembly: AssemblyProduct("Catel.MVVM")]
[assembly: AssemblyDescription("Catel MVVM library")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

#if !PCL
[assembly: ComVisible(false)]
#endif

// Theme info
#if NET
[assembly: ThemeInfo(
    ResourceDictionaryLocation.SourceAssembly, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
    )]
#endif

// XmlnsDefinition is not supported in UWP
#if !NETFX_CORE && !PCL && !XAMARIN && !XAMARIN_FORMS

[assembly: XmlnsPrefix("http://schemas.catelproject.com", "catel")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.MVVM")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.MVVM.Converters")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.MVVM.Providers")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.MVVM.Views")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.Windows")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.Windows.Controls")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.Windows.Interactivity")]

#if NET
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.Windows.Data")]
[assembly: XmlnsDefinition("http://schemas.catelproject.com", "Catel.Windows.Markup")]
#endif

#endif
