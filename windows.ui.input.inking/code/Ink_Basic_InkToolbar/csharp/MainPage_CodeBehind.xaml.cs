using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Ink_Basic_InkToolbar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage_CodeBehind : Page
    {
        // <SnippetInkToolbarMainPageCB>
        /// <summary>
        /// An empty page that can be used on its own or navigated to within a Frame.
        /// Here, we set up InkToolbar event listeners.
        /// </summary>
        public MainPage_CodeBehind()
        {
            this.InitializeComponent();
            // Add handlers for InkToolbar events.
            inkToolbar.Loading += inkToolbar_Loading;
            //inkToolbar.Loaded += inkToolbar_Loaded;
        }
        // </SnippetInkToolbarMainPageCB>

        // <SnippetInkToolbarLoadedCB>
        /// <summary>
        /// Handle the Loaded event of the InkToolbar.
        /// By default, the active tool is set to the first tool on the toolbar.
        /// Here, we set the active tool to the pencil button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inkToolbar_Loaded(object sender, RoutedEventArgs e)
        {
            InkToolbarToolButton pencilButton = inkToolbar.GetToolButton(InkToolbarTool.Pencil);
            inkToolbar.ActiveTool = pencilButton;
        }
        // </SnippetInkToolbarLoadedCB>

        // <SnippetInkToolbarLoadingCB>
        /// <summary>
        /// Handles the Loading event of the InkToolbar. 
        /// Here, we identify the buttons to include on the InkToolbar.
        /// </summary>
        /// <param name="sender">The InkToolbar</param>
        /// <param name="args">The InkToolbar event data. 
        /// If there is no event data, this parameter is null</param>
        private void inkToolbar_Loading(FrameworkElement sender, object args)
        {
            // Clear all built-in buttons from the InkToolbar.
            inkToolbar.InitialControls = InkToolbarInitialControls.None;

            // Add only the ballpoint pen, pencil, and eraser.
            // Note that the buttons are added to the toolbar in the order
            // defined by the framework, not the order we specify here.
            InkToolbarBallpointPenButton ballpoint = new InkToolbarBallpointPenButton();
            InkToolbarPencilButton pencil = new InkToolbarPencilButton();
            InkToolbarEraserButton eraser = new InkToolbarEraserButton();
            inkToolbar.Children.Add(eraser);
            inkToolbar.Children.Add(ballpoint);
            inkToolbar.Children.Add(pencil);
        }
        // </SnippetInkToolbarLoadingCB>
    }
}
