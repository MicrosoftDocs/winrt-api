---
-api-id: T:Windows.Devices.Geolocation.StatusChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class StatusChangedEventArgs : Windows.Devices.Geolocation.IStatusChangedEventArgs
-->

# Windows.Devices.Geolocation.StatusChangedEventArgs

## -description

Provides information for the [StatusChanged](geolocator_statuschanged.md) event.

## -remarks

This object is the argument passed to the handler for the [StatusChanged](geolocator_statuschanged.md) event.

## -examples

This code example demonstrates how the [StatusChanged](geolocator_statuschanged.md) event is handled. The [Geolocator](geolocator.md) object triggers the [StatusChanged](geolocator_statuschanged.md) event to indicate that the user's location settings changed. That event passes the corresponding status via the argument's **Status** property (of type [PositionStatus](positionstatus.md)). Note that this method is not called from the UI thread and the [Dispatcher](../windows.ui.core/coredispatcher.md) object invokes the UI changes. For more info, see [Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8).

```csharp

using Windows.UI.Core;
...
async private void OnStatusChanged(Geolocator sender, StatusChangedEventArgs e)
{
    await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
    {
        // Show the location setting message only if status is disabled.
        LocationDisabledMessage.Visibility = Visibility.Collapsed;

        switch (e.Status)
        {
            case PositionStatus.Ready:
                // Location platform is providing valid data.
                ScenarioOutput_Status.Text = "Ready";
                _rootPage.NotifyUser("Location platform is ready.", NotifyType.StatusMessage);
                break;

            case PositionStatus.Initializing:
                // Location platform is attempting to acquire a fix. 
                ScenarioOutput_Status.Text = "Initializing";
                _rootPage.NotifyUser("Location platform is attempting to obtain a position.", NotifyType.StatusMessage);
                break;

            case PositionStatus.NoData:
                // Location platform could not obtain location data.
                ScenarioOutput_Status.Text = "No data";
                _rootPage.NotifyUser("Not able to determine the location.", NotifyType.ErrorMessage);
                break;

            case PositionStatus.Disabled:
                // The permission to access location data is denied by the user or other policies.
                ScenarioOutput_Status.Text = "Disabled";
                _rootPage.NotifyUser("Access to location is denied.", NotifyType.ErrorMessage);

                // Show message to the user to go to location settings
                LocationDisabledMessage.Visibility = Visibility.Visible;

                // Clear cached location data if any
                UpdateLocationData(null);
                break;

            case PositionStatus.NotInitialized:
                // The location platform is not initialized. This indicates that the application 
                // has not made a request for location data.
                ScenarioOutput_Status.Text = "Not initialized";
                _rootPage.NotifyUser("No request for location is made yet.", NotifyType.StatusMessage);
                break;

            case PositionStatus.NotAvailable:
                // The location platform is not available on this version of the OS.
                ScenarioOutput_Status.Text = "Not available";
                _rootPage.NotifyUser("Location is not available on this version of the OS.", NotifyType.ErrorMessage);
                break;

            default:
                ScenarioOutput_Status.Text = "Unknown";
                _rootPage.NotifyUser(string.Empty, NotifyType.StatusMessage);
                break;
        }
    });
}
```

## -see-also

[Geolocation sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=533278)

## -capabilities

location
ID_CAP_LOCATION [Windows Phone]
