---
-api-id: M:Windows.Devices.SmartCards.SmartCardCryptogramGenerator.CreateCryptogramMaterialStorageKeyAsync(Windows.Devices.SmartCards.SmartCardUnlockPromptingBehavior,System.String,Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyAlgorithm,Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyCapabilities)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardCryptogramGeneratorOperationStatus> CreateCryptogramMaterialStorageKeyAsync(Windows.Devices.SmartCards.SmartCardUnlockPromptingBehavior promptingBehavior, System.String storageKeyName, Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyAlgorithm algorithm, Windows.Devices.SmartCards.SmartCardCryptogramStorageKeyCapabilities capabilities)
-->

# Windows.Devices.SmartCards.SmartCardCryptogramGenerator.CreateCryptogramMaterialStorageKeyAsync

## -description
Generates a cryptogram storage key.

## -parameters
### -param promptingBehavior
The user prompting behavior.

### -param storageKeyName
The name of the new storage key.

### -param algorithm
The encryption algorithm to use with the storage key.

### -param capabilities
The capabilities of the new storage key.

## -returns
An asynchronous operation that completes with an operation status after the attempt of creating a storage key.

## -remarks

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
