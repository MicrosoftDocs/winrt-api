---
-api-id: P:Windows.Networking.NetworkOperators.ESim.SlotIndex
-api-type: winrt property
---

# Windows.Networking.NetworkOperators.ESim.SlotIndex

<!--
public System.Nullable<int> SlotIndex { get; }
-->


## -description

Gets the 0-based slot index (slot number) that the eSim corresponds to. **ESim.SlotIndex** matches the [Index](mobilebroadbandslotinfo_index.md) property of the corresponding [MobileBroadbandSlotInfo](mobilebroadbandslotinfo.md) object.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -property-value

The 0-based slot index (slot number) that the eSim corresponds to, or `null` if the modem doesn't support the multi-SIM function.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
