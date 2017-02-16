---
-api-id: P:Windows.UI.WebUI.WebUIContactCallActivatedEventArgs.ServiceId
-api-type: winrt property
---

<!-- Property syntax
public string ServiceId { get; }
-->

# Windows.UI.WebUI.WebUIContactCallActivatedEventArgs.ServiceId

## -description
Gets the identifier of the service used for the call.

## -property-value
The identifier of the service used for the call.

## -remarks
For PSTN calls, the [ServiceId](webuicontactcallactivatedeventargs_serviceid.md) property is set to "telephone." For web-based services, the [ServiceId](webuicontactcallactivatedeventargs_serviceid.md) property is set to the domain name of the service to be used for calling, for example “skype.com”. Your app will only receive call activations for ServiceIds that match the "ServiceId" elements that your app has registered in its manifest.

## -examples

## -see-also
