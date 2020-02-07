---
-api-id: M:Windows.Devices.SmartCards.SmartCardProvisioning.RequestAttestedVirtualSmartCardCreationAsync(System.String,Windows.Storage.Streams.IBuffer,Windows.Devices.SmartCards.SmartCardPinPolicy)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(System.String friendlyName, Windows.Storage.Streams.IBuffer administrativeKey, Windows.Devices.SmartCards.SmartCardPinPolicy pinPolicy)
-->

# Windows.Devices.SmartCards.SmartCardProvisioning.RequestAttestedVirtualSmartCardCreationAsync

## -description
Creates an attested Trusted Platform Module (TPM) virtual smart card with the specified parameters.

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
[RequestAttestedVirtualSmartCardCreationAsync(String, IBuffer, SmartCardPinPolicy, Guid)](smartcardprovisioning_requestattestedvirtualsmartcardcreationasync_794718138.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
