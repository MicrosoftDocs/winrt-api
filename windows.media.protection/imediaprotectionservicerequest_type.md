---
-api-id: P:Windows.Media.Protection.IMediaProtectionServiceRequest.Type
-api-type: winrt property
---

<!-- Property syntax
public System.Guid Type { get; }
-->

# Windows.Media.Protection.IMediaProtectionServiceRequest.Type

## -description
Retrieves the [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) for the type of operation that the [IMediaProtectionServiceRequest](imediaprotectionservicerequest.md) performs.

## -property-value
The GUID to retrieve.

## -remarks
The possible values of Type depend on the content protection system used for the content. This can be determined by context or by inspecting the [ProtectionSystem](imediaprotectionservicerequest_protectionsystem.md) property.

## -examples

## -see-also
