---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyMeteringReportServiceRequest.Type
-api-type: winrt property
---

<!-- Property syntax
public System.Guid Type { get; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyMeteringReportServiceRequest.Type

## -description
Gets the GUID for the type of operation that the PlayReady metering report service request performs.

## -property-value
The GUID for the type of operation. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -remarks
The possible values of **Type** depend on the content protection system used for the content. This can be determined by context or by inspecting the [ProtectionSystem](playreadymeteringreportservicerequest_protectionsystem.md) property.

## -examples

## -see-also
