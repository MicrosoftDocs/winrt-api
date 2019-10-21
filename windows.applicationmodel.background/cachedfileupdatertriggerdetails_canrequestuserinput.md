---
-api-id: P:Windows.ApplicationModel.Background.CachedFileUpdaterTriggerDetails.CanRequestUserInput
-api-type: winrt property
---

<!-- Property syntax
public bool CanRequestUserInput { get; }
-->

# Windows.ApplicationModel.Background.CachedFileUpdaterTriggerDetails.CanRequestUserInput

## -description
Gets whether the system can display UI allowing the user to launch provider app in response to the cached file updater trigger.

## -property-value
Whether the system can display UI allowing the user to launch provider app in response to the cached file updater trigger.

## -remarks
The Cached File Updater pattern allows the provider app to specify that user input is needed to complete the cached file update by setting the [Status](../windows.storage.provider/fileupdaterequest_status.md) property of the associated [FileUpdateRequest](../windows.storage.provider/fileupdaterequest.md) to [UserInputNeeded](../windows.storage.provider/fileupdaterequest_userinputneededmessage.md). It is possible that the system may not be able to show UI to the user during the background task, if the app that updated the file is not currently running in the foreground, for example. In this case, CanRequestUserInput will be false. So, you should check this value before requesting for the system to show UI. Setting the [FileUpdateRequest](../windows.storage.provider/fileupdaterequest.md) status to [UserInputNeeded](../windows.storage.provider/fileupdaterequest_userinputneededmessage.md) will throw an exception if CanRequestUserInput is false.

## -examples

## -see-also
