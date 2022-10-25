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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
A MobileBroadbandDeviceServiceCommandResult instance is created when the [SendQueryCommandAsync](mobilebroadbanddeviceservicecommandsession_sendquerycommandasync_1203981658.md) or [SendSetCommandAsync](mobilebroadbanddeviceservicecommandsession_sendsetcommandasync_422276589.md) method is called on the [MobileBroadbandDeviceServiceCommandSession](mobilebroadbanddeviceservicecommandsession.md) and the result of the command has been received.

## -examples

## -see-also
[MobileBroadbandDeviceService](mobilebroadbanddeviceservice.md), [MobileBroadbandDeviceServiceCommandSession](mobilebroadbanddeviceservicecommandsession.md), [SendQueryCommandAsync](mobilebroadbanddeviceservicecommandsession_sendquerycommandasync_1203981658.md), [SendSetCommandAsync](mobilebroadbanddeviceservicecommandsession_sendsetcommandasync_422276589.md)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
