---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyContentHeader.#ctor(System.UInt32,System.Guid[],System.String[],Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm,Windows.Foundation.Uri,Windows.Foundation.Uri,System.String,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public PlayReadyContentHeader(System.UInt32 dwFlags, System.Guid[] contentKeyIds, System.String[] contentKeyIdStrings, Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm, Windows.Foundation.Uri licenseAcquisitionUrl, Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl, System.String customAttributes, System.Guid domainServiceId)
-->

# Windows.Media.Protection.PlayReady.PlayReadyContentHeader.PlayReadyContentHeader

## -description
Initializes a new instance of the PlayReadyContentHeader class.

## -parameters
### -param dwFlags
Reserved. Set to 0.

### -param contentKeyIds
Identifiers of the content encryption keys.

### -param contentKeyIdStrings
String representations of the content keys. Each string must be a Base-64 encoded 16 byte value.

### -param contentEncryptionAlgorithm
Encryption algorithm type used to encrypt the content.

### -param licenseAcquisitionUrl
The URL for the silent (no user interaction) license acquisition Web service.

### -param licenseAcquisitionUserInterfaceUrl
The URL for a non-silent license acquisition Web page.

### -param customAttributes
Contains custom data used by the content provider. The content author can add arbitrary XML inside this element. Microsoft code does not act on any data contained inside this element.

### -param domainServiceId
Service identifier for the domain service.

## -remarks
The *contentKeyIds* and *domainServiceId* parameters are sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -examples

## -see-also
[PlayReadyContentHeader(Byte[], Uri, Uri, String, Guid)](playreadycontentheader_playreadycontentheader_1270950489.md), [PlayReadyContentHeader(Guid, String, PlayReadyEncryptionAlgorithm, Uri, Uri, String, Guid)](playreadycontentheader_playreadycontentheader_115544006.md), [PlayReadyContentHeader(Byte[])](playreadycontentheader_playreadycontentheader_52593125.md)