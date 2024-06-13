---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.SetHeadsetOperation(Windows.Gaming.Input.Preview.HeadsetOperation,System.Byte[])
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.SetHeadsetOperation(Windows.Gaming.Input.Preview.HeadsetOperation,System.Byte[])

<!--
public void SetHeadsetOperation (Windows.Gaming.Input.Preview.HeadsetOperation operation, byte[] buffer);
-->

## -description

Sets a headset operation.

## -parameters

### -param operation

The setting to change.

### -param buffer

Buffer with the appropriate format for `operation`. See [HeadsetOperation](HeadsetOperation.md) for the respective formats.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the headset control APIs should only be used with hardware you have developed.

## -see-also

[HeadsetOperation](HeadsetOperation.md)

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::
