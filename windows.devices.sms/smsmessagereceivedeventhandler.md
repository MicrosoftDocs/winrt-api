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
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

> [!NOTE]
> Note that this class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use this class, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use this class if you are developing new apps for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -parameters
### -param sender
A reference to the SMS device object that sent the message.

### -param e
An object that holds the binary and text representations of the message.


## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging