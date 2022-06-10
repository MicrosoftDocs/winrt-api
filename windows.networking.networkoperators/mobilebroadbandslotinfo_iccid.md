---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandSlotInfo.IccId
-api-type: winrt property
---

# Windows.Networking.NetworkOperators.MobileBroadbandSlotInfo.IccId

<!--
public string IccId { get; }
-->


## -description

Gets the Integrated Circuit Card Identifier (ICCID) for an eSim (in either the active or inactive slot, for Dual Sim Single Active devices).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -property-value

The Integrated Circuit Card Identifier (ICCID) if it's available; otherwise, an empty string. The ICCID is available after successful initialization of the UICC/eUICC card, and the subscriber information state has become ready.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
