---
-api-id: M:Windows.Devices.SmartCards.SmartCardCryptogramGenerator.RequestCryptogramMaterialStorageKeyInfoAsync(Windows.Devices.SmartCards.SmartCardUnlockPromptingBehavior,System.String,Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyInfo> RequestCryptogramMaterialStorageKeyInfoAsync(Windows.Devices.SmartCards.SmartCardUnlockPromptingBehavior promptingBehavior, System.String storageKeyName, Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType format)
-->

# Windows.Devices.SmartCards.SmartCardCryptogramGenerator.RequestCryptogramMaterialStorageKeyInfoAsync

## -description
Returns the public key and attestation information related to the cryptogram storage key.

## -parameters
### -param promptingBehavior
The prompting behavior to display to the user for validation.

### -param storageKeyName
The name of the storage key.

### -param format
The format in which the public key of the storage key is to be returned.

## -returns
An asynchronous operation that returns the smart card cryptogram storage key information.

## -remarks

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
