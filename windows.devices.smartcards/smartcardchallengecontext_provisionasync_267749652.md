---
-api-id: M:Windows.Devices.SmartCards.SmartCardChallengeContext.ProvisionAsync(Windows.Storage.Streams.IBuffer,System.Boolean,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ProvisionAsync(Windows.Storage.Streams.IBuffer response, System.Boolean formatCard, System.Guid newCardId)
-->

# Windows.Devices.SmartCards.SmartCardChallengeContext.ProvisionAsync

## -description
Reconfigures an existing, configured smart card with a new response and ID. Optionally, formats the smart card.

## -parameters
### -param response
The new response to a smart card authentication challenge/response operation.

### -param formatCard
True to format the smart card; otherwise false.

### -param newCardId
The new smart card ID.

## -returns
An asynchronous action that completes after the smart card reconfiguration attempt is done.

## -remarks

## -examples

## -see-also
[ProvisionAsync(IBuffer, Boolean)](smartcardchallengecontext_provisionasync_1459375156.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
