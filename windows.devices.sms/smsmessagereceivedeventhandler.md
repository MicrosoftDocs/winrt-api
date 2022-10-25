---
-api-id: T:Windows.Devices.Sms.SmsMessageReceivedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void SmsMessageReceivedEventHandler(Windows.Devices.Sms.SmsDevice sender, Windows.Devices.Sms.SmsMessageReceivedEventArgs e)
-->
# Windows.Devices.Sms.SmsMessageReceivedEventHandler

## -description
This event handler is called when a new binary message is received. Callers should implement this when they want to handle new binary messages from a given SMS device.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> This class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows. If you do use this class, then you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Don't use this class if you're developing a new app for Windows. Instead, use the APIs in this namespace that don't require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -parameters
### -param sender
A reference to the SMS device object that sent the message.

### -param e
An object that holds the binary and text representations of the message.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
