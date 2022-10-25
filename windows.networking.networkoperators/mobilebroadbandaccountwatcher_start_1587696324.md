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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
When you start the account watcher, it first enumerates all Mobile Broadband Accounts and raises an [AccountAdded](mobilebroadbandaccountwatcher_accountadded.md) event for each account found. When the enumeration operation is completed, the account watcher raises the [EnumerationCompleted](mobilebroadbandaccountwatcher_enumerationcompleted.md) event. After the [EnumerationCompleted](mobilebroadbandaccountwatcher_enumerationcompleted.md) event is raised, the account watcher continues to raise account-related events ([AccountAdded](mobilebroadbandaccountwatcher_accountadded.md), [AccountUpdated](mobilebroadbandaccountwatcher_accountupdated.md), and [AccountRemoved](mobilebroadbandaccountwatcher_accountremoved.md)) until you call the [Stop](mobilebroadbandaccountwatcher_stop_1201535524.md) method.

Note that you do not need to explicitly stop and start the account watcher on App Suspend/Resume events. Instead, starting and starting the watcher is handled by the API itself.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
