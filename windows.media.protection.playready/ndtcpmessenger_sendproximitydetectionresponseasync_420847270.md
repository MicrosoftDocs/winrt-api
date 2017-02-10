---
-api-id: M:Windows.Media.Protection.PlayReady.NDTCPMessenger.SendProximityDetectionResponseAsync(Windows.Media.Protection.PlayReady.NDProximityDetectionType,System.Byte[],System.Byte[],System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Protection.PlayReady.INDSendResult> SendProximityDetectionResponseAsync(Windows.Media.Protection.PlayReady.NDProximityDetectionType pdType, System.Byte[] transmitterChannelBytes, System.Byte[] sessionIDBytes, System.Byte[] responseDataBytes)
-->

# Windows.Media.Protection.PlayReady.NDTCPMessenger.SendProximityDetectionResponseAsync

## -description
Sends the specified data in an asynchronous proximity detection response message.

## -parameters
### -param pdType
The type of proximity detection operation. This value can be **UDP**, **TCP**, or **Transport-Agnostic**.

### -param transmitterChannelBytes
The transmitter channel data.

### -param sessionIDBytes
The session identifier. The session identifier must be 16 bytes.

### -param responseDataBytes
The data for the response message.

## -returns
The result of the proximity detection response operation.

## -remarks

## -examples

## -see-also
[INDSendResult](indsendresult.md)