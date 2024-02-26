---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.StartTetheringAsync(Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.StartTetheringAsync(Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.NetworkOperatorTetheringOperationResult> StartTetheringAsync (Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration configuration);
-->


## -description

Allows you to start a tethering session without having to pre-configure it via [ConfigureAccessPointAsync](./networkoperatortetheringmanager_configureaccesspointasync_1399951422.md). The configuration passed as a parameter is valid only for the current session, and will be lost once the session has ended.

Starting a new session via this overload of **StartTetheringAsync** also allows you to configure per-session-only parameters that can't be persistently set via **ConfigureAccessPointAsync**. Parameters that *can* be persisted are the network SSID, the network password, the network wireless frequency band, and the network authentication algorithm.

## -parameters

### -param configuration

## -returns

## -remarks

## -see-also

## -examples
