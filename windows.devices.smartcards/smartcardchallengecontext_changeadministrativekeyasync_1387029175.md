---
-api-id: M:Windows.Devices.SmartCards.SmartCardChallengeContext.ChangeAdministrativeKeyAsync(Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ChangeAdministrativeKeyAsync(Windows.Storage.Streams.IBuffer response, Windows.Storage.Streams.IBuffer newAdministrativeKey)
-->

# Windows.Devices.SmartCards.SmartCardChallengeContext.ChangeAdministrativeKeyAsync

## -description
Changes the smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).

## -parameters
### -param response
The response to a smart card authentication challenge/response operation.

### -param newAdministrativeKey
The new smart card admin key.

## -returns
An asynchronous action that completes after the admin key change attempt is done.

## -remarks

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
