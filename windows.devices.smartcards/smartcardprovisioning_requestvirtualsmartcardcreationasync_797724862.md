---
-api-id: M:Windows.Devices.SmartCards.SmartCardProvisioning.RequestVirtualSmartCardCreationAsync(System.String,Windows.Storage.Streams.IBuffer,Windows.Devices.SmartCards.SmartCardPinPolicy)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(System.String friendlyName, Windows.Storage.Streams.IBuffer administrativeKey, Windows.Devices.SmartCards.SmartCardPinPolicy pinPolicy)
-->

# Windows.Devices.SmartCards.SmartCardProvisioning.RequestVirtualSmartCardCreationAsync

## -description
Creates a Trusted Platform Module (TPM) virtual smart card with a given human-readable name, admin key, and personal identification number (PIN) rules set.

## -parameters
### -param friendlyName
The smart card's human-readable name.

### -param administrativeKey
The smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).

### -param pinPolicy
The smart card's PIN rules set.

## -returns
After the operation completes, returns an instance of [SmartCardProvisioning](smartcardprovisioning.md), representing the configured TPM virtual smart card.

## -remarks
When this method is called, it displays a UI to get the PIN from the user.

## -examples

## -see-also
[RequestVirtualSmartCardCreationAsync(String, IBuffer, SmartCardPinPolicy, Guid)](smartcardprovisioning_requestvirtualsmartcardcreationasync_1650468110.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
