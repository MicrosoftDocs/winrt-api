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

using Windows.UI.Input;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Core;

// The Blank Page item template is documented at 
// http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RadialControllerApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private RadialController radialController;
        private RadialControllerConfiguration radialControllerConfig;
        private List<RadialControllerMenuItem> menuItems;
        private int activeMenuItemIndex;
        private List<StackPanel> containers;
        private List<Slider> sliders;
        private List<ToggleSwitch> toggles;
        private List<TextBlock> subheads;
        private const int PRIMARY_MENU_ITEM_INDEX = 0;

        private CoreDispatcher dispatcher;


        public MainPage()
        {
            InitializeComponent();
            InitializeController();
            Loaded += MainPage_Loaded;
        }
        // <SnippetTestRC>
        // Once page has loaded, invoke default menu item.
        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcher = CoreWindow.GetForCurrentThread().Dispatcher;
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                OnItemInvoked(PRIMARY_MENU_ITEM_INDEX);
            });
        }
        // </SnippetTestRC>
        // <SnippetInitializeController>
        // Create and configure our radial controller.
        private void InitializeController() 
        {
            // Create a reference to the RadialController.
            radialController = RadialController.CreateForCurrentView();
            // Set rotation resolution to 1 degree of sensitivity.
            radialController.RotationResolutionInDegrees = 1;

            // Declare input handlers for the RadialController.
            radialController.ButtonClicked += (sender, args) =>
            { RadialController_ButtonClicked(sender, args); };
            radialController.RotationChanged += (sender, args) =>
            { RadialController_RotationChanged(sender, args); };

            radialController.ControlAcquired += (sender, args) =>
            { RadialController_ControlAcquired(sender, args); };
            radialController.ControlLost += (sender, args) =>
            { RadialController_ControlLost(sender, args); };
            radialController.ScreenContactStarted += (sender, args) =>
            { RadialController_ScreenContactStarted(sender, args); };
            radialController.ScreenContactContinued += (sender, args) =>
            { RadialController_ScreenContactContinued(sender, args); };
            radialController.ScreenContactEnded += (sender, args) =>
            { RadialController_ScreenContactEnded(sender, args); };
            AddToLog("Input handlers created");

            // Create the custom menu items.
            CreateMenuItems();
            // Specify the menu items.
            ConfigureMenu();
        }
        // </SnippetInitializeController>

        // Specify the radial controller menu items.
        // We remove all built-in items and add our default custom item.
        private void ConfigureMenu()
        {
            // Add primary (default) tool.
            radialController.Menu.Items.Add(menuItems[PRIMARY_MENU_ITEM_INDEX]);
            activeMenuItemIndex = PRIMARY_MENU_ITEM_INDEX;

            // Remove built-in tools to declutter the menu.
            // NOTE: The Surface Dial menu must have at least one menu item. 
            // If all built-in tools are removed before you add a custom 
            // tool, the default tools are restored and your tool is appended 
            // to the default collection.
            radialControllerConfig = RadialControllerConfiguration.GetForCurrentView();
            radialControllerConfig.SetDefaultMenuItems(new RadialControllerSystemMenuItemKind[] { });
        }

        /// <summary>
        /// Create custom menu items for all tools.
        /// </summary>
        private void CreateMenuItems()
        {
            // Enumerate all UI elements.
            // Used for UI feedback to indicate current control region.
            containers = new List<StackPanel> { Stack0, Stack1 };
            // Used for rotate actions.
            sliders = new List<Slider> { RotationSlider0, RotationSlider1 };
            // Used for click actions.
            toggles = new List<ToggleSwitch> { ClickToggle0, ClickToggle1 };
            // Used for click actions.
            subheads = new List<TextBlock> { SubHeading0, SubHeading1 };

            // Create icons for the custom tools.
            RandomAccessStreamReference icon =
              RandomAccessStreamReference.CreateFromUri(
                new Uri("ms-appx:///Assets/StoreLogo.png"));

            // Enumerate custom menu items for each control region.
            menuItems = new List<RadialControllerMenuItem>
            {
                // RadialController menu adds built-in ink menu items by default.
                // We need to create other custom tools manually. 
                RadialControllerMenuItem.CreateFromIcon("Tool0", icon),
                RadialControllerMenuItem.CreateFromIcon("Tool1", icon)
            };

            // Create and configure custom menu items.
            for (int i = 0; i < menuItems.Count; ++i)
            {
                RadialControllerMenuItem radialControllerMenuItem =
                    menuItems[i];

                radialControllerMenuItem.Tag = i;

                AddToLog("\n" + menuItems[i].DisplayText + " created");

                radialControllerMenuItem.Invoked +=
                    (sender, args) => { OnItemInvoked(radialControllerMenuItem.Tag); };
            }
        }

        // Occurs when a custom tool is selected from the RadialController menu.
        // Set the active menu item index and update UI.
        private void OnItemInvoked(object selectedItemIndex)
        {
            activeMenuItemIndex = (int)selectedItemIndex;

            UpdateUI(menuItems[activeMenuItemIndex]);

            AddToLog("\n" + menuItems[activeMenuItemIndex].DisplayText + " invoked");
        }








        // Occurs when a custom RadialController tool (defined by an app) 
        // is selected from the menu, or when an app associated with the 
        // RadialController object is brought to the foreground while a 
        // custom RadialController tool is active.
        // Event logged, no other action.
        private void RadialController_ControlAcquired(RadialController sender,
            RadialControllerControlAcquiredEventArgs args)
        {
            AddToLog("\n" + menuItems[activeMenuItemIndex].DisplayText + " control acquired");
        }










        // Occurs while a custom RadialController tool (defined by an app) 
        // is active, and either the app associated with the RadialController 
        // object is sent to the background, or the user activates the 
        // RadialController menu.
        // Event logged, no other action.
        private void RadialController_ControlLost(RadialController sender, object args)
        {
            AddToLog("\n" + menuItems[activeMenuItemIndex].DisplayText + " control lost");
        }









        private void RadialController_ScreenContactStarted(RadialController sender,
            RadialControllerScreenContactStartedEventArgs args)
        {
            Point contactPosition = args.Contact.Position;
            Rect contactBounds = args.Contact.Bounds;
            Rect containerRect;

            for (int i = 0; i < menuItems.Count; ++i)
            {
                // Assuming Position is the center point of the wheel device on the digitizer surface.
                // If wheel device contact is within bounding rect of 
                containerRect = containers[i].TransformToVisual(this).TransformBounds(
                    LayoutInformation.GetLayoutSlot(containers[i]));
                if ((contactPosition.X < (containerRect.X + containerRect.Width)) && 
                    (contactPosition.Y < (containerRect.Y + containerRect.Height)))
                {
                    if (radialController.Menu.Items.Contains(menuItems[i]))
                        OnItemInvoked(i);
                    break;
                }
            }
            AddToLog("\nScreen contact started (Location: " + contactPosition.X.ToString() + " " + contactPosition.Y.ToString() + " / Bounds: " + contactBounds.X.ToString() + " " + contactBounds.Y.ToString() + " " + contactBounds.Width.ToString() + " " + contactBounds.Height.ToString() + ")");
        }





        private void RadialController_ScreenContactContinued(RadialController sender,
            RadialControllerScreenContactContinuedEventArgs args)
        {
            Point contactPosition = args.Contact.Position;
            Rect contactBounds = args.Contact.Bounds;

            AddToLog("\nScreen contact started (Location: " +
                contactPosition.X.ToString() + " " +
                contactPosition.Y.ToString() + " / Bounds: " +
                contactBounds.X.ToString() + " " +
                contactBounds.Y.ToString() + " " +
                contactBounds.Width.ToString() + " " +
                contactBounds.Height.ToString() + ")");
        }








        private void RadialController_ScreenContactEnded(RadialController sender, object args)
        {
            AddToLog("\nScreen contact ended");
        }
















        // <SnippetRotationChangedHandler>
        // Occurs when the wheel device is rotated while a custom 
        // RadialController tool is active.
        // NOTE: Your app does not receive this event when the RadialController 
        // menu is active or a built-in tool is active
        // Send rotation input to slider of active region.
        private void RadialController_RotationChanged(RadialController sender,
          RadialControllerRotationChangedEventArgs args)
        {
            Slider slider = sliders[activeMenuItemIndex];
            if (slider.Value + args.RotationDeltaInDegrees > 100)
            {
                slider.Value = 100;
                return;
            }
            else if (slider.Value + args.RotationDeltaInDegrees < 0)
            {
                slider.Value = 0;
                return;
            }
            slider.Value += args.RotationDeltaInDegrees;
            AddToLog("\nRotation: " + sliders[activeMenuItemIndex].Name + " value changed to " + slider.Value);
        }
        // </SnippetRotationChangedHandler>

        // <SnippetButtonClickedHandler>
        // Occurs when the wheel device is pressed and then released 
        // while a customRadialController tool is active.
        // NOTE: Your app does not receive this event when the RadialController 
        // menu is active or a built-in tool is active
        // Send click input to toggle button of active region.
        private void RadialController_ButtonClicked(RadialController sender,
          RadialControllerButtonClickedEventArgs args)
        {
            toggles[activeMenuItemIndex].IsOn = !toggles[activeMenuItemIndex].IsOn;
        }
        // </SnippetButtonClickedHandler>













        // Add specified item to the RadialController menu.
        private void AddItem(object sender, RoutedEventArgs e)
        {
            RadialControllerMenuItem radialControllerMenuItem =
                GetRadialControllerMenuItemFromSender(sender);

            if (!radialController.Menu.Items.Contains(radialControllerMenuItem))
            {
                radialController.Menu.Items.Add(radialControllerMenuItem);
            }
        }

        // Remove specified item from the RadialController menu.
        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            RadialControllerMenuItem radialControllerMenuItem = GetRadialControllerMenuItemFromSender(sender);

            if (radialController.Menu.Items.Contains(radialControllerMenuItem))
            {
                radialController.Menu.Items.Remove(radialControllerMenuItem);
                // Attempts to select and activate the previously selected tool.
                // NOTE: Does not differentiate between built-in and custom tools.
                radialController.Menu.TrySelectPreviouslySelectedMenuItem();
            }
        }

        // Select specified item from the RadialController menu.
        private void SelectItem(object sender, RoutedEventArgs e)
        {
            RadialControllerMenuItem radialControllerMenuItem = GetRadialControllerMenuItemFromSender(sender);

            if (radialController.Menu.Items.Contains(radialControllerMenuItem))
            {
                radialController.Menu.SelectMenuItem(radialControllerMenuItem);

                UpdateUI(radialControllerMenuItem);

                AddToLog("\n" + radialControllerMenuItem.DisplayText + " selected");
            }
        }

        // Indicate which region is receiving RadialController input.
        private void UpdateUI(RadialControllerMenuItem radialControllerMenuItem)
        {
            for (int i = 0; i < menuItems.Count; ++i)
            {
                containers[i].Background = (Brush)Application.Current.Resources["ApplicationPageBackgroundThemeBrush"];
                containers[i].BorderThickness = new Thickness(1);
                subheads[i].Text = "Inactive";
            }
            containers[(int)radialControllerMenuItem.Tag].Background = new SolidColorBrush(Colors.AliceBlue);
            containers[(int)radialControllerMenuItem.Tag].BorderThickness = new Thickness(5);
            subheads[(int)radialControllerMenuItem.Tag].Text = "Active";
        }

        // Returns the selected menu item.
        private RadialControllerMenuItem GetRadialControllerMenuItemFromSender(object sender)
        {
            Button button = sender as Button;
            int index = Convert.ToInt32(button.CommandParameter);

            return menuItems[index];
        }

        // Update RadialController log.
        private void AddToLog(string s)
        {
            logText.Text += s;
        }

        // Scroll to last string added to log.
        private void OnLogViewerSizeChanged(object sender, object e)
        {
            logViewer.ChangeView(null, logViewer.ExtentHeight, null);
        }
    }
}
