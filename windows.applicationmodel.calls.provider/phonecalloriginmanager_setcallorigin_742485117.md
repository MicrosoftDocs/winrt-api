---
-api-id: M:Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager.SetCallOrigin(System.Guid,Windows.ApplicationModel.Calls.Provider.PhoneCallOrigin)
-api-type: winrt method
---

<!-- Method syntax
public void SetCallOrigin(System.Guid requestId, Windows.ApplicationModel.Calls.Provider.PhoneCallOrigin callOrigin)
-->

# Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager.SetCallOrigin

## -description
Sets the call origin when a phone call comes in.

## -parameters
### -param requestId
The unique identifier for this phone call. This is retrieved from the *targetId* of the [PhoneCallOriginDataRequestTriggerDetails](../windows.applicationmodel.calls.background/phonecallorigindatarequesttriggerdetails.md)

### -param callOrigin
The call information for the incoming call.

## -remarks
Before attempting to call this method, make sure of the following.
+ You declare the **PhoneCall** capability in your app manifest file as follows: `<uap:Capability Name="phoneCall" />`
+ Your application has a background task that binds the [PhoneCallOriginDataRequestTriggerDetails](../windows.applicationmodel.calls.background/phonecallorigindatarequesttriggerdetails.md) trigger.
+ Your application can make phone calls (under Settings -> Privacy -> Phone calls).


If any of these are not true, SetCallOrigin will return an access denied error.

This method should be invoked in the background when the application is triggered by the [PhoneCallOriginDataRequestTriggerDetails](../windows.applicationmodel.calls.background/phonecallorigindatarequesttriggerdetails.md).

The following example shows how to set the location of the origin in response to a trigger.



[!code-csharp[ShowCallLocation](../windows.applicationmodel.calls.provider/code/CallProvider/cs/Scenario1.xaml.cs#SnippetShowCallLocation)]

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
