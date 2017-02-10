---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest.DomainServiceId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid DomainServiceId { get;  set; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest.DomainServiceId

## -description
Gets or sets the current domain service identifier property that overrides a service identifier in the content header.

## -property-value
The current domain service identifier property. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -remarks
This property cannot be set after [BeginServiceRequest](playreadylicenseacquisitionservicerequest_beginservicerequest.md) or [GenerateManualEnablingChallenge](playreadylicenseacquisitionservicerequest_generatemanualenablingchallenge.md) have been called.

## -examples

## -see-also
