---
-api-id: T:Windows.Devices.Sms.SmsBinaryMessage
-api-type: winrt class
---

<!-- Class syntax.
public class SmsBinaryMessage : Windows.Devices.Sms.ISmsBinaryMessage, Windows.Devices.Sms.ISmsMessage
-->

# Windows.Devices.Sms.SmsBinaryMessage

## -description
Represents an SMS message in raw PDU format. The data format differs depending on whether the message format (indicated by the value of the [Format](smsbinarymessage_format.md) property) is GSM or CDMA.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> This class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows. If you do use this class, then you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Don't use this class if you're developing a new app for Windows. Instead, use the APIs in this namespace that don't require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
