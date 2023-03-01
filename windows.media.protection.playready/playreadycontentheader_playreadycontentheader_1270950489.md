---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyContentHeader.#ctor(System.Byte[],Windows.Foundation.Uri,Windows.Foundation.Uri,System.String,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public PlayReadyContentHeader(System.Byte[] headerBytes, Windows.Foundation.Uri licenseAcquisitionUrl, Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl, System.String customAttributes, System.Guid domainServiceId)
-->

# Windows.Media.Protection.PlayReady.PlayReadyContentHeader.PlayReadyContentHeader

## -description
Initializes a new instance of the [PlayReadyContentHeader](playreadycontentheader.md) class.

## -parameters
### -param headerBytes
Raw data bytes representing a legacy WMDRM header.

### -param licenseAcquisitionUrl
The URL for the silent (no user interaction) license acquisition Web service.

### -param licenseAcquisitionUserInterfaceUrl
The URL for a non-silent license acquisition Web page.

### -param customAttributes
Contains custom data used by the content provider. The content author can add arbitrary XML inside this element. Microsoft code does not act on any data contained inside this element.

### -param domainServiceId
Service identifier for the domain service.

## -remarks
This constructor should be used to convert a legacy WMDRM header to a PlayReady header.

The *domainServiceId* parameter is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -examples

## -see-also
