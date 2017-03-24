---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceServiceCommandResult : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceCommandResult
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult

## -description
Represents the result of a mobile broadband device service command.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
A [MobileBroadbandDeviceServiceCommandResult](mobilebroadbanddeviceservicecommandresult.md) instance is created when the [SendQueryCommandAsync](mobilebroadbanddeviceservicecommandsession_sendquerycommandasync.md) or [SendSetCommandAsync](mobilebroadbanddeviceservicecommandsession_sendsetcommandasync.md) method is called on the [MobileBroadbandDeviceServiceCommandSession](mobilebroadbanddeviceservicecommandsession.md) and the result of the command has been received.

## -examples

## -see-also
[MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md), [MobileBroadbandDeviceServiceCommandSession](mobilebroadbanddeviceservicecommandsession.md), [SendQueryCommandAsync](mobilebroadbanddeviceservicecommandsession_sendquerycommandasync.md), [SendSetCommandAsync](mobilebroadbanddeviceservicecommandsession_sendsetcommandasync.md)