---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadySecureStopServiceRequest.Uri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Uri { get;  set; }
-->

# Windows.Media.Protection.PlayReady.PlayReadySecureStopServiceRequest.Uri

## -description
Gets or sets the URI used to perform a service request action.

## -property-value
The URI to be used.

## -remarks
The URI must be set through this property before calling [BeginServiceRequest](playreadysecurestopservicerequest_beginservicerequest.md).

This property cannot be set after [BeginServiceRequest](playreadysecurestopservicerequest_beginservicerequest.md) or [GenerateManualEnablingChallenge](playreadysecurestopservicerequest_generatemanualenablingchallenge.md) have been called.

## -examples

## -see-also
