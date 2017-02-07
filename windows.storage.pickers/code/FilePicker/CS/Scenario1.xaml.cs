//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using SDKTemplate;

using System;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FilePicker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1 : SDKTemplate.Common.LayoutAwarePage
    {
        MainPage rootPage = MainPage.Current;

        public Scenario1()
        {
            this.InitializeComponent();
            PickAFileButton.Click += new RoutedEventHandler(PickAFileButton_Click);
        }

        private async void PickAFileButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous returned file name, if it exists, between iterations of this scenario
            rootPage.ResetScenarioOutput(OutputTextBlock);

            //<Snippetall_openpicker_checksnapped_showsingle>
            //<Snippetcs_openpicker_checksnapped_showsingle>
            //<Snippetall_openpicker_setprops_show>
            //<Snippetcs_openpicker_setprops_show>
            //<Snippetall_openpicker_setprops>
            //<Snippetcs_openpicker_setprops>
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            //</Snippetcs_openpicker_setprops>
            //</Snippetall_openpicker_setprops>

            //<Snippetall_openpicker_showsingle>
            //<Snippetcs_openpicker_showsingle>
            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                OutputTextBlock.Text = "Picked photo: " + file.Name;
            }
            else
            {
                OutputTextBlock.Text = "Operation cancelled.";
            }
            //</Snippetcs_openpicker_showsingle>
            //</Snippetall_openpicker_showsingle>
            //</Snippetcs_openpicker_setprops_show>
            //</Snippetall_openpicker_setprops_show>
            //</Snippetcs_openpicker_checksnapped_showsingle>
            //</Snippetall_openpicker_checksnapped_showsingle>
        }
    }
}
