---
-api-id: T:Windows.Devices.Sms.SmsMessageReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SmsMessageReceivedEventArgs : Windows.Devices.Sms.ISmsMessageReceivedEventArgs
-->

# Windows.Devices.Sms.SmsMessageReceivedEventArgs

## -description
Provides data for [ISmsBinaryMessage](ismsbinarymessage.md) event handlers.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> Note that this class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use this class, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use this class if you are developing new apps for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks
An instance of the SmsMessageReceivedEventArgs class can be retrieved from the [SmsMessageReceivedEventHandler](smsmessagereceivedeventhandler.md) delegate.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
