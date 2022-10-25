---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandSlotManager.SetCurrentSlotAsync(System.Int32)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.MobileBroadbandSlotManager.SetCurrentSlotAsync(System.Int32)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.MobileBroadbandModemStatus> SetCurrentSlotAsync (int slotIndex);
-->

## -description

Asynchronously switches to the slot specified by the 0-based slot index.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic.

## -parameters

### -param slotIndex

The 0-based slot index to switch to.

## -returns

An asynchronous operation. On successful completion, the specified slot has been switched to.

## -remarks

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
