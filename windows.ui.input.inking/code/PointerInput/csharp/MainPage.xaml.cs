// <SnippetCompleteExample>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PointerInput
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
// <SnippetInitialize>
        // For this example, we track simultaneous contacts in case the 
        // number of contacts has reached the maximum supported by the device.
        // Depending on the device, additional contacts might be ignored 
        // (PointerPressed not fired). 
        uint numActiveContacts;
        Windows.Devices.Input.TouchCapabilities touchCapabilities = new Windows.Devices.Input.TouchCapabilities();

        // Dictionary to maintain information about each active contact. 
        // An entry is added during PointerPressed/PointerEntered events and removed 
        // during PointerReleased/PointerCaptureLost/PointerCanceled/PointerExited events.
        Dictionary<uint, Windows.UI.Xaml.Input.Pointer> contacts;

        public MainPage()
        {
            this.InitializeComponent();
            numActiveContacts = 0;
            // Initialize the dictionary.
            contacts = new Dictionary<uint, Windows.UI.Xaml.Input.Pointer>((int)touchCapabilities.Contacts);
            // Declare the pointer event handlers.
            Target.PointerPressed += new PointerEventHandler(Target_PointerPressed);
            Target.PointerEntered += new PointerEventHandler(Target_PointerEntered);
            Target.PointerReleased += new PointerEventHandler(Target_PointerReleased);
            Target.PointerExited += new PointerEventHandler(Target_PointerExited);
            Target.PointerCanceled += new PointerEventHandler(Target_PointerCanceled);
            Target.PointerCaptureLost += new PointerEventHandler(Target_PointerCaptureLost);
            Target.PointerMoved += new PointerEventHandler(Target_PointerMoved);
            Target.PointerWheelChanged += new PointerEventHandler(Target_PointerWheelChanged);
        }

// </SnippetInitialize>

// <SnippetPointerPressed>
        // PointerPressed and PointerReleased events do not always occur in pairs. 
        // Your app should listen for and handle any event that might conclude a pointer down action 
        // (such as PointerExited, PointerCanceled, and PointerCaptureLost).
        // For this example, we track the number of contacts in case the 
        // number of contacts has reached the maximum supported by the device.
        // Depending on the device, additional contacts might be ignored 
        // (PointerPressed not fired). 
        void Target_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (Convert.ToBoolean(touchCapabilities.TouchPresent) && (numActiveContacts > touchCapabilities.Contacts))
            {
                // Number of supported contacts exceeded.
                return;
            }

            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nDown: " + ptr.PointerId;

            // Change background color of target when pointer contact detected.
            Target.Fill = new SolidColorBrush(Windows.UI.Colors.Green);

            // Check if pointer already exists (for example, enter occurred prior to press).
            if (contacts.ContainsKey(ptr.PointerId))
            {
                return;
            }
            // Add contact to dictionary.
            contacts[ptr.PointerId] = ptr;
            ++numActiveContacts;

            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;

            // Display pointer details.
            createInfoPop(e);
        }
// </SnippetPointerPressed>

        // <SnippetPointerReleased>
        void Target_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nUp: " + ptr.PointerId;

            // If event source is mouse pointer and the pointer is still 
            // over the target, retain pointer and pointer details.
            // Return without removing pointer from pointers dictionary.
            // For this example, we assume a maximum of one mouse pointer.
            if (ptr.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Mouse)
            {
                Target.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
                return;
            }

            // Update target UI.
            Target.Fill = new SolidColorBrush(Windows.UI.Colors.Red);


            destroyInfoPop(ptr);

            // Remove contact from dictionary.
            if (contacts.ContainsKey(ptr.PointerId))
            {
                contacts[ptr.PointerId] = null;
                contacts.Remove(ptr.PointerId);
                --numActiveContacts;
            }
            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;
        }
        // </SnippetPointerReleased>

        // <SnippetPointerMoved>
        private void Target_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Multiple, simultaneous mouse button inputs are processed here.
            // Mouse input is associated with a single pointer assigned when 
            // mouse input is first detected. 
            // Clicking additional mouse buttons (left, wheel, or right) during 
            // the interaction creates secondary associations between those buttons 
            // and the pointer through the pointer pressed event. 
            // The pointer released event is fired only when the last mouse button 
            // associated with the interaction (not necessarily the initial button) 
            // is released. 
            // Because of this exclusive association, other mouse button clicks are 
            // routed through the pointer move event.          
            if (ptr.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Mouse)
            {
                // To get mouse state, we need extended pointer details.
                // We get the pointer info through the getCurrentPoint method
                // of the event argument. 
                Windows.UI.Input.PointerPoint ptrPt = e.GetCurrentPoint(Target);
                if (ptrPt.Properties.IsLeftButtonPressed)
                {
                    eventLog.Text += "\nLeft button: " + ptrPt.PointerId;
                }
                if (ptrPt.Properties.IsMiddleButtonPressed)
                {
                    eventLog.Text += "\nWheel button: " + ptrPt.PointerId;
                }
                if (ptrPt.Properties.IsRightButtonPressed)
                {
                    eventLog.Text += "\nRight button: " + ptrPt.PointerId;
                }
            }

            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;

            // Display pointer details.
            updateInfoPop(e);
        }
        // </SnippetPointerMoved>

// <SnippetPointerEntered>
        private void Target_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nOver: " + ptr.PointerId;

            if (contacts.Count == 0)
            {
                // Change background color of target when pointer contact detected.
                Target.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);
            }

            // Check if pointer already exists (if enter occurred prior to down).
            if (contacts.ContainsKey(ptr.PointerId))
            {
                return;
            }

            // Add contact to dictionary.
            contacts[ptr.PointerId] = ptr;
            ++numActiveContacts;

            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;

            // Display pointer details.
            createInfoPop(e);
        }
// </SnippetPointerEntered>

        // <SnippetPointerWheel>
        private void Target_PointerWheelChanged(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nMouse wheel: " + ptr.PointerId;

            // Check if pointer already exists (for example, enter occurred prior to wheel).
            if (contacts.ContainsKey(ptr.PointerId))
            {
                return;
            }

            // Add contact to dictionary.
            contacts[ptr.PointerId] = ptr;
            ++numActiveContacts;

            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;

            // Display pointer details.
            createInfoPop(e);
        }
        // </SnippetPointerWheel>

        // <SnippetPointerCaptureLost>
        // Fires for various reasons, including: 
        //    - User interactions
        //    - Programmatic capture of another pointer
        //    - Captured pointer was deliberately released
        // PointerCaptureLost can fire instead of PointerReleased. 
        private void Target_PointerCaptureLost(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nPointer capture lost: " + ptr.PointerId;

            // Remove contact from dictionary.
            if (contacts.ContainsKey(ptr.PointerId))
            {
                contacts[ptr.PointerId] = null;
                contacts.Remove(ptr.PointerId);
                --numActiveContacts;
            }

            destroyInfoPop(ptr);

            if (contacts.Count == 0)
            {
                Target.Fill = new SolidColorBrush(Windows.UI.Colors.Black);
            }
            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;
        }
        // </SnippetPointerCaptureLost>

        // <SnippetPointerCanceled>
        // Fires for various reasons, including: 
        //    - Touch contact canceled by pen coming into range of the surface.
        //    - The device doesn't report an active contact for more than 100ms.
        //    - The desktop is locked or the user logged off. 
        //    - The number of simultaneous contacts exceeded the number supported by the device.
        private void Target_PointerCanceled(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nPointer canceled: " + ptr.PointerId;

            // Remove contact from dictionary.
            if (contacts.ContainsKey(ptr.PointerId))
            {
                contacts[ptr.PointerId] = null;
                contacts.Remove(ptr.PointerId);
                --numActiveContacts;
            }

            destroyInfoPop(ptr);

            if (contacts.Count == 0)
            {
                Target.Fill = new SolidColorBrush(Windows.UI.Colors.Black);
            }
            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;
        }
        // </SnippetPointerCanceled>

        // <SnippetPointerExited>
        private void Target_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Input.Pointer ptr = e.Pointer;

            // Update event sequence.
            eventLog.Text += "\nPointer exited: " + ptr.PointerId;

            // Remove contact from dictionary.
            if (contacts.ContainsKey(ptr.PointerId))
            {
                contacts[ptr.PointerId] = null;
                contacts.Remove(ptr.PointerId);
                --numActiveContacts;
            }

            // Update the UI and pointer details.
            destroyInfoPop(ptr);

            if (contacts.Count == 0)
            {
                Target.Fill = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            // Prevent most handlers along the event route from handling the same event again.
            e.Handled = true;
        }
        // </SnippetPointerExited>

// <SnippetCreateInfoPop>
        void createInfoPop(PointerRoutedEventArgs e)
        {
            TextBlock pointerDetails = new TextBlock();
            Windows.UI.Input.PointerPoint ptrPt = e.GetCurrentPoint(Target);
            pointerDetails.Name = ptrPt.PointerId.ToString();
            pointerDetails.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
            pointerDetails.Text = queryPointer(ptrPt);

            TranslateTransform x = new TranslateTransform();
            x.X = ptrPt.Position.X + 20;
            x.Y = ptrPt.Position.Y + 20;
            pointerDetails.RenderTransform = x;

            Container.Children.Add(pointerDetails);
        }
        // </SnippetCreateInfoPop>

        // <SnippetDestroyInfoPop>
        void destroyInfoPop(Windows.UI.Xaml.Input.Pointer ptr)
        {
            foreach (var pointerDetails in Container.Children)
            {
                if (pointerDetails.GetType().ToString() == "Windows.UI.Xaml.Controls.TextBlock")
                {
                    TextBlock _TextBlock = (TextBlock)pointerDetails;
                    if (_TextBlock.Name == ptr.PointerId.ToString())
                    {
                        Container.Children.Remove(pointerDetails);
                    }
                }
            }
        }
        // </SnippetDestroyInfoPop>

// <SnippetUpdateInfoPop>
        void updateInfoPop(PointerRoutedEventArgs e)
        {
            foreach (var pointerDetails in Container.Children)
            {
                if (pointerDetails.GetType().ToString() == "Windows.UI.Xaml.Controls.TextBlock")
                {
                    TextBlock _TextBlock = (TextBlock)pointerDetails;
                    if (_TextBlock.Name == e.Pointer.PointerId.ToString())
                    {
                        // To get pointer location details, we need extended pointer info.
                        // We get the pointer info through the getCurrentPoint method
                        // of the event argument. 
                        Windows.UI.Input.PointerPoint ptrPt = e.GetCurrentPoint(Target);
                        TranslateTransform x = new TranslateTransform();
                        x.X = ptrPt.Position.X + 20;
                        x.Y = ptrPt.Position.Y + 20;
                        pointerDetails.RenderTransform = x;
                        _TextBlock.Text = queryPointer(ptrPt);
                    }
                }
            }
        }
// </SnippetUpdateInfoPop>

// <SnippetQueryPointer>
         String queryPointer(PointerPoint ptrPt)
         {
             String details = "";

             switch (ptrPt.PointerDevice.PointerDeviceType)
             {
                 case Windows.Devices.Input.PointerDeviceType.Mouse:
                     details += "\nPointer type: mouse";
                     break;
                 case Windows.Devices.Input.PointerDeviceType.Pen:
                     details += "\nPointer type: pen";
                     if (ptrPt.IsInContact)
                     {
                         details += "\nPressure: " + ptrPt.Properties.Pressure;
                         details += "\nrotation: " + ptrPt.Properties.Orientation;
                         details += "\nTilt X: " + ptrPt.Properties.XTilt;
                         details += "\nTilt Y: " + ptrPt.Properties.YTilt;
                         details += "\nBarrel button pressed: " + ptrPt.Properties.IsBarrelButtonPressed;
                     }
                     break;
                 case Windows.Devices.Input.PointerDeviceType.Touch:
                     details += "\nPointer type: touch";
                     details += "\nrotation: " + ptrPt.Properties.Orientation;
                     details += "\nTilt X: " + ptrPt.Properties.XTilt;
                     details += "\nTilt Y: " + ptrPt.Properties.YTilt;
                     break;
                 default:
                     details += "\nPointer type: n/a";
                     break;
             }

             GeneralTransform gt = Target.TransformToVisual(page);
             Point screenPoint;

             screenPoint = gt.TransformPoint(new Point(ptrPt.Position.X, ptrPt.Position.Y));
             details += "\nPointer Id: " + ptrPt.PointerId.ToString() +
                 "\nPointer location (parent): " + ptrPt.Position.X + ", " + ptrPt.Position.Y +
                 "\nPointer location (screen): " + screenPoint.X + ", " + screenPoint.Y;
             return details;
         }
        // </SnippetQueryPointer>
    }
}
// </SnippetCompleteExample>