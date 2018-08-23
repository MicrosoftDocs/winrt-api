---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyDomainJoinServiceRequest.Uri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri Uri { get;  set; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyDomainJoinServiceRequest.Uri

## -description
Gets or sets the URI used to perform a service request action.

## -property-value
The URI to be used.

## -remarks
The URI must be set through this property before calling [BeginServiceRequest](playreadydomainjoinservicerequest_beginservicerequest_736222023.md).

This property cannot be set after [BeginServiceRequest](playreadydomainjoinservicerequest_beginservicerequest_736222023.md) or [GenerateManualEnablingChallenge](playreadydomainjoinservicerequest_generatemanualenablingchallenge_1228062000.md) have been called.

## -examples

## -see-also
