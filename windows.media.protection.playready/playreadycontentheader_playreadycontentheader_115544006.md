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

Starting with Windows 10, version 1709, you can specify [PlayReadyEncryptionAlgorithm.Aes128Cbc](/uwp/api/windows.media.protection.playready.playreadyencryptionalgorithm), for AES128CBC encryption, or [PlayReadyEncryptionAlgorithm.Unspecified](/uwp/api/windows.media.protection.playready.playreadyencryptionalgorithm), to allow the server backend to determine the encryption type, as the value for the *contentEncryptionAlgorithm* parameter. On previous versions of Windows 10, specifying either of these values will cause an exception to be thrown. For this reason, you should check for the presence of the enumeration value by calling **[ApiInformationIsApiContractPresent](/uwp/api/windows.foundation.metadata.apiinformation#Windows_Foundation_Metadata_ApiInformation_IsApiContractPresent_System_String_System_UInt16_)** and specifying major contract version 5 before using the new enum values in the constructor call.

```csharp
bool supportsAes128CbcAndUnspecified = ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 5);

if (supportsAes128CbcAndUnspecified)
{
    // Guid and URL below are known by app, obtaining them is out of scope
    PlayReadyContentHeader header = new PlayReadyContentHeader(
        new Guid("{6591a70e-06fc-4d1f-862a-80bb569f07da}"),
        null,
        PlayReadyEncryptionAlgorithm.Unspecified,
        new Uri("http://www.contoso.com/rightsmanager.aspx"),
        null,
        null,
        new Guid("{215304E7-9263-446A-B150-0754D5E18973}"));
  
    var request = PlayReadyContentResolver.ServiceRequest(header);
    await request.BeginServiceRequest();
}
else
{
    // Application chooses behavior, for example, picks different content
    // or tells user that their system doesn’t support the selected content
}
```

## -examples

## -see-also
