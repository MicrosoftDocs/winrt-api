---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.StartTetheringAsync(Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.StartTetheringAsync(Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.NetworkOperatorTetheringOperationResult> StartTetheringAsync (Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration configuration);
-->


## -description

Starts the mobile hotspot using a specified per-session configuration.

This overload allows you to start a tethering session without having to pre-configure it via [ConfigureAccessPointAsync](./networkoperatortetheringmanager_configureaccesspointasync_1399951422.md). The configuration passed as a parameter is valid only for the current session, and will be lost once the session has ended.

Starting a new session via this overload of **StartTetheringAsync** also allows you to configure per-session-only parameters that can't be persistently set via **ConfigureAccessPointAsync**. Parameters that *can* be persisted are the network SSID, the network password, the network wireless frequency band, and the network authentication algorithm.

We recommended that you first call [StopTetheringAsync](./networkoperatortetheringmanager_stoptetheringasync_1234797808.md) in order to ensure that the tethering hotspot is off.

## -parameters

### -param configuration

A [NetworkOperatorTetheringSessionAccessPointConfiguration](./networkoperatortetheringsessionaccesspointconfiguration.md) object containing all the per-session fields necessary to configure the mobile hotspot. This configuration doesn't persist between sessions. 

## -returns

An object containing a [TetheringOperationStatus](./tetheringoperationstatus.md) status code indicating whether the start operation was successful, or the reason of failure, as well as a detailed **HSTRING** containing an additional error message if applicable.

## -remarks

## -see-also

## -examples

## -capabilities
wiFiControl
