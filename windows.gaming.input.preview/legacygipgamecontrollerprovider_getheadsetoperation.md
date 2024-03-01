---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetHeadsetOperation(Windows.Gaming.Input.Preview.HeadsetOperation)
-api-type: winrt method
---

<!-- Method syntax.
public byte[] LegacyGipGameControllerProvider.GetHeadsetOperation(HeadsetOperation operation)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetHeadsetOperation

## -description

Gets a headset setting based on ``operation``. Returns a buffer with contents dependent on ``operation``. See [HeadsetOperation](HeadsetOperation.md) for the respective return value formats.

## -parameters

### -param operation

The setting to read.

## -returns

A buffer with the appropriate format for ```operation```. See [HeadsetOperation](HeadsetOperation.md) for the respective formats.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the headset control APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::

## -see-also

[HeadsetOperation](HeadsetOperation.md)
