---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.SetHeadsetOperation(Windows.Gaming.Input.Preview.HeadsetOperation, System.Byte[])
-api-type: winrt method
---

<!-- Method syntax.
public void LegacyGipGameControllerProvider.SetHeadsetOperation(HeadsetOperation operation, byte[] buffer)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.SetHeadsetOperation

## -description

Sets a headset setting based on ``operation``. ``Buffer`` must be a value that is compatible with ``operation``. See [HeadsetOperation](HeadsetOperation.md) for the respective formats for ```buffer```.

## -parameters

### -param operation

The setting to change.

### -param buffer

Buffer with the appropriate format for ```operation```. See [HeadsetOperation](HeadsetOperation.md) for the respective formats.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the headset control APIs should only be used with hardware you have developed.

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::

## -see-also

[HeadsetOperation](HeadsetOperation.md)
