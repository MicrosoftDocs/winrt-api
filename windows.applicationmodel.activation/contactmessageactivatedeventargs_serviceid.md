---
-api-id: P:Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs.ServiceId
-api-type: winrt property
---

<!-- Property syntax
public string ServiceId { get; }
-->

# Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs.ServiceId

## -description
Gets the identifier of the service used for the message.

## -property-value
The identifier of the service used for the message.

## -remarks
For standard text messages, the [ServiceId](contactmessageactivatedeventargs_serviceid.md) property is set to "telephone." For web service-based messaging, the [ServiceId](contactmessageactivatedeventargs_serviceid.md) property is set to the domain name of the service to be used for messaging, for example “skype.com”. Your app will only receive message activations for ServiceIds that match the "ServiceId" elements that your app has registered in its manifest.

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](https://msdn.microsoft.com/library/397d8b2a-6255-4f37-8556-449a3be2ef3f) and [Quickstart: Handling contact actions ](https://msdn.microsoft.com/library/61bacc8a-24c9-4b3d-b77b-e0822467700c).

## -examples

## -see-also
[Handling Contact Actions sample](https://go.microsoft.com/fwlink/p/?LinkID=320151)
