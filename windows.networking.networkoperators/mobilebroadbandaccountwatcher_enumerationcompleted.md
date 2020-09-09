---
-api-id: E:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.EnumerationCompleted
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EnumerationCompleted<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,  object>
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.EnumerationCompleted

## -description
Occurs when the account watcher has finished enumerating accounts for the client.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations). 

## -remarks
When the watcher is started, it enumerates all existing accounts (raising an [AccountAdded](mobilebroadbandaccountwatcher_accountadded.md) event for each account). You can use the **EnumerationCompleted** event to determine when the enumeration operation has finished. After that, all proceeding events are new.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
