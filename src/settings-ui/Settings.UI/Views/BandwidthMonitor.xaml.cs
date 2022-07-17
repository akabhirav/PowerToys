// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Threading.Tasks;
using Microsoft.PowerToys.Settings.UI.Library;
using Microsoft.PowerToys.Settings.UI.ViewModels;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace BandwidthMonitor
{
    using Microsoft.PowerToys.Settings.UI;
    using Microsoft.PowerToys.Settings.UI.Views;

    public sealed partial class BandwidthMonitorPage : Page
    {
        private VideoConferenceViewModel ViewModel { get; set; }

        public BandwidthMonitorPage()
        {
            var settingsUtils = new SettingsUtils();
            ViewModel = new VideoConferenceViewModel(settingsUtils, SettingsRepository<GeneralSettings>.GetInstance(settingsUtils), ShellPage.SendDefaultIPCMessage, PickFileDialog);
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
