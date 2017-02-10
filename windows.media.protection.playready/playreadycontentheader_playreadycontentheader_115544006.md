---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyContentHeader.#ctor(System.Guid,System.String,Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm,Windows.Foundation.Uri,Windows.Foundation.Uri,System.String,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public PlayReadyContentHeader(System.Guid contentKeyId, System.String contentKeyIdString, Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm contentEncryptionAlgorithm, Windows.Foundation.Uri licenseAcquisitionUrl, Windows.Foundation.Uri licenseAcquisitionUserInterfaceUrl, System.String customAttributes, System.Guid domainServiceId)
-->

# Windows.Media.Protection.PlayReady.PlayReadyContentHeader.PlayReadyContentHeader

## -description
Initializes a new instance of the [PlayReadyContentHeader](playreadycontentheader.md) class.

## -parameters
### -param contentKeyId
Identifier of the content encryption key.

### -param contentKeyIdString
String representation of the content key. If the *contentKeyId* parameter is specified, then this parameter is ignored.

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
The *contentKeyId* and *domainServiceId* parameters are sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -examples

## -see-also
[PlayReadyContentHeader(UInt32, Guid[], String[], PlayReadyEncryptionAlgorithm, Uri, Uri, String, Guid)](playreadycontentheader_playreadycontentheader_40363517.md), [PlayReadyContentHeader(Byte[], Uri, Uri, String, Guid)](playreadycontentheader_playreadycontentheader_1270950489.md), [PlayReadyContentHeader(Byte[])](playreadycontentheader_playreadycontentheader_52593125.md)