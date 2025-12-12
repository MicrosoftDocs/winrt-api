---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationView.IsHosted
-api-type: winrt property
---

<!-- Property syntax
public bool IsHosted { get; }
-->

# Windows.ApplicationModel.Core.CoreApplicationView.IsHosted

## -description

Gets the value that indicates whether this app view is hosted.

## -property-value

If **true**, this app view is hosted; if **false**, it isn't.

## -remarks

An app view is hosted when the process that launches it controls its lifetime. For example, the window that opens when a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) is launched is hosted.

## -examples

Here's a simple example that demonstrates how to use the `IsHosted` property:

```csharp
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml;

namespace ExampleApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Check if the current app view is hosted
            bool isHosted = CoreApplication.GetCurrentView().IsHosted;

            // Display the result
            if (isHosted)
            {
                System.Diagnostics.Debug.WriteLine("The app view is hosted.");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("The app view is not hosted.");
            }
        }
    }
}

## -see-also
