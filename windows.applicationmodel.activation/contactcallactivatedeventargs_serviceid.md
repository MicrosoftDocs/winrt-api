---
-api-id: P:Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs.ServiceId
-api-type: winrt property
---

<!-- Property syntax
public string ServiceId { get; }
-->

# Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs.ServiceId

## -description
Gets the identifier of the service used for the call.

## -property-value
The identifier of the service used for the call.

## -remarks
For PSTN calls, the ServiceId property is set to "telephone." For web-based services, the ServiceId property is set to the domain name of the service to be used for calling, for example “skype.com”. Your app will only receive call activations for ServiceIds that match the "ServiceId" elements that your app has registered in its manifest.

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](/previous-versions/windows/apps/dn518236(v=win.10)).

## -examples

## -see-also
[Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
