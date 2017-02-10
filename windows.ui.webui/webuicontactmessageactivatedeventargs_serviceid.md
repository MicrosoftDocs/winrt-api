---
-api-id: P:Windows.UI.WebUI.WebUIContactMessageActivatedEventArgs.ServiceId
-api-type: winrt property
---

<!-- Property syntax
public string ServiceId { get; }
-->

# Windows.UI.WebUI.WebUIContactMessageActivatedEventArgs.ServiceId

## -description
Gets the identifier of the service used for the message.

## -property-value
The identifier of the service used for the message.

## -remarks
For standard text messages, the [ServiceId](webuicontactmessageactivatedeventargs_serviceid.md) property is set to "telephone." For web service-based messaging, the [ServiceId](webuicontactmessageactivatedeventargs_serviceid.md) property is set to the domain name of the service to be used for messaging, for example "skype.com." Your app will only receive message activations for ServiceIds that match the "ServiceId" elements that your app has registered in its manifest.

## -examples

## -see-also
