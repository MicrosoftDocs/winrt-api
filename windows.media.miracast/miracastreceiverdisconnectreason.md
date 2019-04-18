---
-api-id: T:Windows.Media.Miracast.MiracastReceiverDisconnectReason
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum MiracastReceiverDisconnectReason : int 
-->

# Windows.Media.Miracast.MiracastReceiverDisconnectReason

## -description

Specifies the reason why the app decided to disconnect the Miracast connection.

## -enum-fields
### -field MediaStreamingError:6

The app encountered an error while streaming was in progress. The error was not related to decoding or decrypting of the data.

### -field MediaDecryptionError:7

Streaming failed due to an error related to decrypting of the audio or video data.

### -field MediaDecodingError:5

Streaming failed due to an error in decoding the audio or video data.

### -field Finished:0

The stream ended without error.

### -field FailedToStartStreaming:4

The app was unable to start streaming, e.g., a connection error.

### -field DisconnectedByUser:3

The user requested to stop streaming.

### -field ConnectionNotAccepted:2

The user refused the Miracast connection.

### -field AppSpecificError:1

An error occurred in the app.

## -remarks

## -see-also

## -examples

