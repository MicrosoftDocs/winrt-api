---
-api-id: T:Windows.Devices.Sms.SmsMessageFilter
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsMessageFilter : int
-->

# SmsMessageFilter

## -description
This enumerated type specifies which messages in the device message store an operation is performed on.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> This class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows. If you do use this class, then you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Don't use this class if you're developing a new app for Windows. Instead, use the APIs in this namespace that don't require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -enum-fields
### -field All:0
All messages in the device message store.

### -field Unread:1
All unread received messages.

### -field Read:2
All read received messages.

### -field Sent:3
All sent and saved messages.

### -field Draft:4
All unsent and saved messages.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
