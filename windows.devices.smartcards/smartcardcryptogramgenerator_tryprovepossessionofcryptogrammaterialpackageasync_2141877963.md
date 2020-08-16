---
-api-id: M:Windows.Devices.SmartCards.SmartCardCryptogramGenerator.TryProvePossessionOfCryptogramMaterialPackageAsync(Windows.Devices.SmartCards.SmartCardUnlockPromptingBehavior,Windows.Devices.SmartCards.SmartCardCryptogramMaterialPackageConfirmationResponseFormat,System.String,System.String,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardCryptogramMaterialPossessionProof> TryProvePossessionOfCryptogramMaterialPackageAsync(Windows.Devices.SmartCards.SmartCardUnlockPromptingBehavior promptingBehavior, Windows.Devices.SmartCards.SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat, System.String materialPackageName, System.String materialName, Windows.Storage.Streams.IBuffer challenge)
-->

# Windows.Devices.SmartCards.SmartCardCryptogramGenerator.TryProvePossessionOfCryptogramMaterialPackageAsync

## -description
This method allows the payment app to query the cryptogram generator for proof of material package possession.

## -parameters
### -param promptingBehavior
The prompting behavior to display to the user for validation.

### -param responseFormat
The format of the response.

### -param materialPackageName
The material package name.

### -param materialName
The material name.

### -param challenge
A buffer that contains the confirmation challenge token. The challenge token must consist of UTF-8 characters conformating to the following C# regular expression. ```
^(?<api>0\d{7})(?<sc>\d+)(?<tvl>\d*[|][0-9a-fA-F]*[|]\d*[|][QM])*$"
```



## -returns
An asynchronous operation that completes with the material possession proof.

## -remarks

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
