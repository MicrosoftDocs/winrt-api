---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.Start

## -description
Starts the account watcher.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
When you start the account watcher, it first enumerates all Mobile Broadband Accounts and raises an [AccountAdded](mobilebroadbandaccountwatcher_accountadded.md) event for each account found. When the enumeration operation is completed, the account watcher raises the [EnumerationCompleted](mobilebroadbandaccountwatcher_enumerationcompleted.md) event. After the [EnumerationCompleted](mobilebroadbandaccountwatcher_enumerationcompleted.md) event is raised, the account watcher continues to raise account-related events ([AccountAdded](mobilebroadbandaccountwatcher_accountadded.md), [AccountUpdated](mobilebroadbandaccountwatcher_accountupdated.md), and [AccountRemoved](mobilebroadbandaccountwatcher_accountremoved.md)) until you call the [Stop](mobilebroadbandaccountwatcher_stop.md) method.

Note that you do not need to explicitly stop and start the account watcher on App Suspend/Resume events. Instead, starting and starting the watcher is handled by the API itself.

## -examples

## -see-also
