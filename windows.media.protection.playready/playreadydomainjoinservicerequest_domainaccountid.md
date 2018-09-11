---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyDomainJoinServiceRequest.DomainAccountId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid DomainAccountId { get;  set; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyDomainJoinServiceRequest.DomainAccountId

## -description
Gets or sets the current domain account identifier property.

## -property-value
The current domain account identifier. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -remarks
This property cannot be set after [BeginServiceRequest](playreadydomainjoinservicerequest_beginservicerequest_736222023.md) or [GenerateManualEnablingChallenge](playreadydomainjoinservicerequest_generatemanualenablingchallenge_1228062000.md) have been called.

## -examples

## -see-also
