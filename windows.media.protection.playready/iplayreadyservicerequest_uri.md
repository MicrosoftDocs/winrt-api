---
-api-id: P:Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest.Uri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Uri { get;  set; }
-->

# Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest.Uri

## -description
Gets or sets the URI used to perform a service request action.

## -property-value
The URI to be used.

## -remarks
For certain service requests, the URI must be set before calling [BeginServiceRequest](iplayreadyservicerequest_beginservicerequest_736222023.md) either through this property or through a different property (such as a content header) that contains a URI.

This property cannot be set after [BeginServiceRequest](iplayreadyservicerequest_beginservicerequest_736222023.md) or [GenerateManualEnablingChallenge](iplayreadyservicerequest_generatemanualenablingchallenge_1228062000.md) have been called.

## -examples

## -see-also
