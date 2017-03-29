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
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
When the watcher is started, it enumerates all existing accounts (raising an [AccountAdded](mobilebroadbandaccountwatcher_accountadded.md) event for each account). You can use the **EnumerationCompleted** event to determine when the enumeration operation has finished. After that, all proceeding events are new.

## -examples

## -see-also
