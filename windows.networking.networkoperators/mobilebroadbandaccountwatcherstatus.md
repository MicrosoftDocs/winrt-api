---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcherStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcherStatus : int
-->

# MobileBroadbandAccountWatcherStatus

## -description
Describes different states of a MobileBroadbandAccountWatcherStatus object.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -enum-fields
### -field Created:0
The watcher has been created but not started and is in its initial state.

### -field Started:1
The watcher has been started and has yet to enumerate the existing accounts.

### -field EnumerationCompleted:2
The watcher is running and has finished enumerating the existing accounts.

### -field Stopped:3
The watcher has been stopped. No events will be delivered while the watcher is in this state.

### -field Aborted:4
The watcher has aborted its watching operation due to an unexpected error condition. No events will be delivered while the watcher is in this state.


## -remarks

## -examples

## -see-also
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
