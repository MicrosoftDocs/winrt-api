---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyStatics.CheckSupportedHardware(Windows.Media.Protection.PlayReady.PlayReadyHardwareDRMFeatures)
-api-type: winrt method
---

<!-- Method syntax
public bool CheckSupportedHardware(Windows.Media.Protection.PlayReady.PlayReadyHardwareDRMFeatures hwdrmFeature)
-->

# Windows.Media.Protection.PlayReady.PlayReadyStatics.CheckSupportedHardware

## -description
Queries whether the specified hardware digital rights management (DRM) feature is supported on the system.

## -parameters
### -param hwdrmFeature
The hardware DRM feature to query.

## -returns
**true** if the hardware DRM feature is supported, otherwise **false**.

## -remarks
Starting with Windows 10, version 1709, you can detect support for AES128CBC hardware encryption on a device by calling **CheckSupportedHardware** and specifying the enumeration value [**PlayReadyHardwareDRMFeatures.Aes128Cbc**](/uwp/api/Windows.Media.Protection.PlayReady.PlayReadyHardwareDRMFeatures). On previous versions of Windows 10, specifying this value will cause an exception to be thrown. For this reason, you should check for the presence of the enumeration value by calling **[ApiInformationIsApiContractPresent](/uwp/api/windows.foundation.metadata.apiinformation#Windows_Foundation_Metadata_ApiInformation_IsApiContractPresent_System_String_System_UInt16_)** and specifying major contract version 5 before calling **CheckSupportedHardware**.

```csharp
bool supportsAes128Cbc = ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 5);

if (supportsAes128Cbc)
{
    supportsAes128Cbc = PlayReadyStatics.CheckSupportedHardware(PlayReadyHardwareDRMFeatures.Aes128Cbc);
}
```

## -examples

## -see-also
