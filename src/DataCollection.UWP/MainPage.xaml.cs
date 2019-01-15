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
using Windows.UI.Xaml.Navigation;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.UI.Controls;
using Esri.ArcGISRuntime.ExampleApps.DataCollection.Shared.ViewModels;
using Esri.ArcGISRuntime.ExampleApps.DataCollection.Shared.Properties;

namespace Esri.ArcGISRuntime.ExampleApps.DataCollection.UWP
{
	/// <summary>
	/// A map page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}

        /// <summary>
        /// Gets the view-model that provides mapping capabilities to the view
        /// </summary>
        public MainViewModel MainViewModel { get; } = new MainViewModel();

        public AuthViewModel AuthViewModel { get; } = new AuthViewModel(
                                                        Settings.Default.WebmapURL,
                                                        Settings.Default.ArcGISOnlineURL,
                                                        Settings.Default.AppClientID,
                                                        Settings.Default.RedirectURL,
                                                        Settings.Default.OAuthRefreshToken);


    }
}