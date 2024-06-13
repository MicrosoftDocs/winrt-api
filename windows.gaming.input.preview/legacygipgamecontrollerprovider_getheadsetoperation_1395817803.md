---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetHeadsetOperation(Windows.Gaming.Input.Preview.HeadsetOperation)
-api-type: winrt method
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetHeadsetOperation(Windows.Gaming.Input.Preview.HeadsetOperation)

<!--
public byte[] GetHeadsetOperation (Windows.Gaming.Input.Preview.HeadsetOperation operation);
-->

## -description

Retrieves a headset setting based on ``operation``.

## -parameters

### -param operation

The setting to read.

## -returns

A buffer with the appropriate format for `operation`.

## -remarks

> [!CAUTION]
> To avoid damaging devices, the headset control APIs should only be used with hardware you have developed.

## -see-also

[HeadsetOperation](HeadsetOperation.md)

## -examples

:::code language="csharp" source="code/csharp/HeadsetManagementSample.cs":::
