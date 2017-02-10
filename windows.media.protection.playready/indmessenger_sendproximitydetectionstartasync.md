---
-api-id: M:Windows.Media.Protection.PlayReady.INDMessenger.SendProximityDetectionStartAsync(Windows.Media.Protection.PlayReady.NDProximityDetectionType,System.Byte[],System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Protection.PlayReady.INDSendResult> SendProximityDetectionStartAsync(Windows.Media.Protection.PlayReady.NDProximityDetectionType pdType, System.Byte[] transmitterChannelBytes, System.Byte[] sessionIDBytes, System.Byte[] challengeDataBytes)
-->

# Windows.Media.Protection.PlayReady.INDMessenger.SendProximityDetectionStartAsync

## -description
Sends the specified data in an asynchronous proximity detection start message.

## -parameters
### -param pdType
The type of proximity detection operation. This value can be **UDP**, **TCP**, or **Transport-Agnostic**.

### -param transmitterChannelBytes
The transmitter channel data.

### -param sessionIDBytes
The session identifier. The session identifier must be 16 bytes.

### -param challengeDataBytes
The data for the challenge message.

## -returns
The result of the proximity detection start operation.

## -remarks

## -examples

## -see-also
[INDSendResult](indsendresult.md)