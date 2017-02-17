---
-api-id: T:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities : uint
-->

# SecondaryAuthenticationFactorDeviceCapabilities

## -description
Represents the capabilities of the companion device.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](http://aka.ms/appcap). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](https://msdn.microsoft.com/windows/uwp/security/companion-device-unlock) overview.

## -enum-fields
### -field None:0
No capabilities.

### -field SecureStorage:1
Set this flag if the companion device supports secure storage and can protect auth key and device key from unauthorized access. In order to make sure your key storage meets the security bar, contact cdfonboard@microsoft.com.

### -field StoreKeys:2
Set this flag if the companion device stores the auth key and device keys.

### -field ConfirmUserIntentToAuthenticate:4
Set this flag if the companion device can confirm user intent to authenticate.

### -field SupportSecureUserPresenceCheck:8
Set this flag if the companion device supports secure storage and can protect auth key and device key from unauthorized access. In order to make sure your key storage meets the security bar, contact cdfonboard@microsoft.com.

### -field TransmittedDataIsEncrypted:16
Set this flag if the companion device transmits auth keys and devices key over an encrypted channel.

### -field HMacSha256:32
The device supports HMacSha256.


### -field CloseRangeDataTransmission:64


## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](https://msdn.microsoft.com/windows/uwp/security/companion-device-unlock)
