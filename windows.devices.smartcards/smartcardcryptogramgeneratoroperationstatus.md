---
-api-id: T:Windows.Devices.SmartCards.SmartCardCryptogramGeneratorOperationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardCryptogramGeneratorOperationStatus : int
-->

# SmartCardCryptogramGeneratorOperationStatus

## -description
Defines the statuses for cryptogram generator methods.

## -enum-fields
### -field Success:0
Operation completed successfully.

### -field AuthorizationFailed:1
The authorization failed.

### -field AuthorizationCanceled:2
The authorization was canceled.

### -field AuthorizationRequired:3
Authorization is required.

### -field CryptogramMaterialPackageStorageKeyExists:4
The cryptogram material package storage key already exists.

### -field NoCryptogramMaterialPackageStorageKey:5
There is no cryptogram material package storage key.

### -field NoCryptogramMaterialPackage:6
There is no cryptogram material package.

### -field UnsupportedCryptogramMaterialPackage:7
The cryptogram material package is unsupported.

### -field UnknownCryptogramMaterialName:8
The specified material name was not found when opening the package.

### -field InvalidCryptogramMaterialUsage:9
Invalid cryptogram material usage.

### -field ApduResponseNotSent:10
The APDU response was not sent.

### -field OtherError:11
An unknown error occurred.

### -field ValidationFailed:12
The validation failed.

### -field NotSupported:13
The operation is not supported.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ValidationFailed |
| 1709 | 16299 | NotSupported |

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)

