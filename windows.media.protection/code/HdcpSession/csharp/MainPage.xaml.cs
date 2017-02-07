using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Protection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowsMediaProtectionSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // <SnippetHdcpSessionDeclarations>
        private HdcpProtection desiredHdcpProtection = HdcpProtection.OnWithTypeEnforcement;
        private HdcpProtection currentHdcpProtection = HdcpProtection.On;
        private bool outputIsProtected = false;
        private HdcpSession hdcpSession;
        // </SnippetHdcpSessionDeclarations>

        public MainPage()
        {
            this.InitializeComponent();
            SetHdcpProtection();
        }

        //<SnippetHdcpSessionMethod>
        private void SetHdcpProtection()
        {
            hdcpSession = new HdcpSession();

            // Register an event to get notified when HDCP changes
            hdcpSession.ProtectionChanged += (HdcpSession sender, object eventArgs) =>
            {
                // In case we want to do something with the level
                HdcpProtection? protection = sender.GetEffectiveProtection();

                if (protection != null)
                {
                    currentHdcpProtection = protection.Value;
                }
                else
                {
                    // The current Hdcp protection level is pending... so treat it as though it's off altogether
                    currentHdcpProtection = HdcpProtection.Off;
                }

                // Check the protection
                outputIsProtected = sender.IsEffectiveProtectionAtLeast(desiredHdcpProtection);
            };

            hdcpSession.SetDesiredMinProtectionAsync(desiredHdcpProtection).Completed = (asyncOperation, asyncStatus) =>
            {
                if (HdcpSetProtectionResult.Success != asyncOperation.GetResults())
                {
                    // Handle the case where we failed to set the HDCP protection
                    DebugTextBlock.Text = "ERROR! Something went wrong";
                }

                outputIsProtected = hdcpSession.IsEffectiveProtectionAtLeast(desiredHdcpProtection);
            };
        }
        //</SnippetHdcpSessionMethod>
    }
}
