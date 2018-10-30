//<snippetCode>
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace PointerExample
{
    public sealed partial class BlankPage : Page
    {
        Dictionary<uint, Point?> _contacts;
        const uint SUPPORTEDCONTACTS = 5;

        public BlankPage()
        {
            this.InitializeComponent();
            _contacts = new Dictionary<uint, Point?>((int)SUPPORTEDCONTACTS);
            this.PointerPressed += BlankPage_PointerPressed;
            this.PointerReleased += BlankPage_PointerReleased;
        }

        private void BlankPage_PointerPressed(object sender, 
            PointerRoutedEventArgs e)
        {
            // Ignore mouse inputs. 
            if (e.Pointer.PointerDeviceType != 
                Windows.Devices.Input.PointerDeviceType.Mouse)
            {
                // Store and touch input contacts.  
                Windows.UI.Input.PointerPoint pt = e.GetCurrentPoint(this);
                _contacts[e.Pointer.PointerId] = pt.Position;
            }
            e.Handled = true;
        }

        private void BlankPage_PointerReleased(object sender, 
            PointerRoutedEventArgs e)
        {
            // Ignore mouse inputs.
            if (e.Pointer.PointerDeviceType != 
                Windows.Devices.Input.PointerDeviceType.Mouse)
            {
                // Remove pointer contacts information.
                uint ptrId = e.Pointer.PointerId;
                if (_contacts.ContainsKey(ptrId))
                {
                    _contacts[ptrId] = null;
                    _contacts.Remove(ptrId);
                }
            }
            e.Handled = true;
        }
    }
}
//</snippetCode>