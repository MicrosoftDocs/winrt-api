//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the Microsoft Public License.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI;

namespace Input
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario2 : SDKTemplate.Common.LayoutAwarePage
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        //<snippetScenario2Code>
        int _pointerCount;

        public Scenario2()
        {
            this.InitializeComponent();
            bEnteredExited.PointerEntered += bEnteredExited_PointerEntered;
            bEnteredExited.PointerExited += bEnteredExited_PointerExited;
            bEnteredExited.PointerPressed += bEnteredExited_PointerPressed;
            bEnteredExited.PointerReleased += bEnteredExited_PointerReleased;
            bEnteredExited.PointerMoved += bEnteredExited_PointerMoved;

            // To code for multiple Pointers (that is, fingers), 
            // we track how many entered/exited.
            _pointerCount = 0;
        }

        private void bEnteredExited_PointerMoved(object sender, 
            PointerRoutedEventArgs e)
        {
            Scenario2UpdateVisuals(sender as Border, "Moved");
        }

        private void bEnteredExited_PointerReleased(object sender, 
            PointerRoutedEventArgs e)
        {
            ((Border)sender).ReleasePointerCapture(e.Pointer);
            txtCaptureStatus.Text = string.Empty;
        }

        //Can only get capture on PointerPressed (i.e. touch down, mouse click, pen press)
        private void bEnteredExited_PointerPressed(object sender, 
            PointerRoutedEventArgs e)
        {
            if (tbPointerCapture.IsOn)
            {
                bool _hasCapture = ((Border)sender).CapturePointer(e.Pointer);
                txtCaptureStatus.Text = "Got Capture: " + _hasCapture;
            }
        }

        private void bEnteredExited_PointerExited(object sender, 
            PointerRoutedEventArgs e)
        {
            _pointerCount--;
            Scenario2UpdateVisuals(sender as Border, "Exited");
        }

        private void bEnteredExited_PointerEntered(object sender, 
            PointerRoutedEventArgs e)
        {
            _pointerCount++;
            Scenario2UpdateVisuals(sender as Border, "Entered");
        }

        private void Scenario2UpdateVisuals(Border border, 
            String eventDescription)
        {
            switch (eventDescription.ToLower())
            {
                case "exited":
                    if (_pointerCount <= 0)
                    {
                        border.Background = new SolidColorBrush(Colors.Red);
                        bEnteredExitedTextBlock.Text = eventDescription;
                    }
                    break;
                case "moved":
                    RotateTransform rt = 
                        (RotateTransform)bEnteredExitedTimer.RenderTransform;
                    rt.Angle += 2;
                    if (rt.Angle > 360) rt.Angle -= 360;
                    break;
                default:
                    border.Background = new SolidColorBrush(Colors.Green);
                    bEnteredExitedTextBlock.Text = eventDescription;
                    break;
            }
        }

        private void Scenario2Reset(object sender, RoutedEventArgs e)
        {
            Scenario2Reset();
        }

        private void Scenario2Reset()
        {
            bEnteredExited.Background = new SolidColorBrush(Colors.Green);
            bEnteredExitedTextBlock.Text = string.Empty;
        }
        //</snippetScenario2Code>
    }
}
