---
-api-id: M:Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager.ShowPhoneCallOriginSettingsUI
-api-type: winrt method
---

<!-- Method syntax
public void ShowPhoneCallOriginSettingsUI()
-->

# Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager.ShowPhoneCallOriginSettingsUI

## -description
Opens the interface that enables the user to select the call origin application.

## -remarks
A user can have multiple phone call origin applications installed on a phone. However, only one of the applications can be the default application and respond to incoming calls. Calling this method opens the user interface to let the user select which phone call origin application is used.

An app must meet certain requirements in order to be show in the list of possible applications for managing call origin.
+ The application must include `<mobile:Extension Category="windows.phoneCallOriginProvider"/>` in the app manifest.
+ The application much register the trigger [PhoneCallOriginDataRequestTriggerDetails](../windows.applicationmodel.calls.background/phonecallorigindatarequesttriggerdetails.md).


To successfully build a package to deploy a custom app, your app needs to have **mobile** as a value for the **IgnorableNamespaces** attribute of the **Package**. Here is a sample **Package** element for a custom app.

```
<Package
 xmlns="http://schemas.microsoft.com/appx/manifest/foundation/windows10"
 xmlns:mp="http://schemas.microsoft.com/appx/2014/phone/manifest"
 xmlns:uap="http://schemas.microsoft.com/appx/manifest/uap/windows10"
 xmlns:mobile="http://schemas.microsoft.com/appx/manifest/mobile/windows10"
 IgnorableNamespaces="uap mp mobile"
 >
```



The following example shows how to pull up the phone call origins application UI so the user can select the appropriate app.



[!code-csharp[SelectOriginApp](../windows.applicationmodel.calls.provider/code/CallProvider/cs/Scenario1.xaml.cs#SnippetSelectOriginApp)]

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
