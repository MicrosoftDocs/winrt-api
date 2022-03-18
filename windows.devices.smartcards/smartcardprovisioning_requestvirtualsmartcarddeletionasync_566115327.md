---
-api-id: M:Windows.Devices.SmartCards.SmartCardProvisioning.RequestVirtualSmartCardDeletionAsync(Windows.Devices.SmartCards.SmartCard)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestVirtualSmartCardDeletionAsync(Windows.Devices.SmartCards.SmartCard card)
-->

# Windows.Devices.SmartCards.SmartCardProvisioning.RequestVirtualSmartCardDeletionAsync

## -description
Deletes a Trusted Platform Module (TPM) virtual smart card.

## -parameters
### -param card
The TPM virtual smart card to delete.

## -returns
After the deletion attempt completes, returns true if the TPM virtual smart card was successfully deleted; otherwise false.

## -remarks
When this method is called, it displays a UI to enable the user to consent to the deletion.

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
