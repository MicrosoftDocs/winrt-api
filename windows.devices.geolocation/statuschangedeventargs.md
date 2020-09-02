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

This code example demonstrates how the [StatusChanged](geolocator_statuschanged.md) event is handled. The [Geolocator](geolocator.md) object triggers the [StatusChanged](geolocator_statuschanged.md) event to indicate that the user's location settings changed. That event passes the corresponding status via the argument's **Status** property (of type [PositionStatus](positionstatus.md)). Note that this method is not called from the UI thread and the [Dispatcher](../windows.ui.core/coredispatcher.md) object invokes the UI changes. For more info, see [Get current location](/windows/uwp/maps-and-location/get-location).

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
                
                // notify user: Location platform is ready
                break;

            case PositionStatus.Initializing:
                // Location platform is attempting to acquire a fix. 
                
                // notify user: Location platform is attempting to obtain a position
                break;

            case PositionStatus.NoData:
                // Location platform could not obtain location data.
                
                // notify user: Not able to determine the location
                break;

            case PositionStatus.Disabled:
                // The permission to access location data is denied by the user or other policies.
                
                // notify user: Access to location is denied
                
                // Clear cached location data if any
                break;

            case PositionStatus.NotInitialized:
                // The location platform is not initialized. This indicates that the application 
                // has not made a request for location data.
                
                // notify user: No request for location is made yet
                break;

            case PositionStatus.NotAvailable:
                // The location platform is not available on this version of the OS.
                
                // notify user: Location is not available on this version of the OS
                break;

            default:
                // unknown case
                break;
        }
    });
}
```

## -see-also

[Geolocation sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities

location
ID_CAP_LOCATION [Windows Phone]
