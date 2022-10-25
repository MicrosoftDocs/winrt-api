---
-api-id: T:Windows.Devices.Sms.SmsReceivedEventDetails
-api-type: winrt class
---

<!-- Class syntax.
public class SmsReceivedEventDetails : Windows.Devices.Sms.ISmsReceivedEventDetails, Windows.Devices.Sms.ISmsReceivedEventDetails2
-->

# Windows.Devices.Sms.SmsReceivedEventDetails

## -description
Presents the details of SMS message events to the background work item that handles messages while your app is suspended.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

> [!NOTE]
> This class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows. If you do use this class, then you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Don't use this class if you're developing a new app for Windows. Instead, use the APIs in this namespace that don't require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks
Windows extends battery life by suspending applications that are not in the foreground. If your application needs to handle new SMS messages even while it is suspended, it needs to create a background work item to handle this. When a new SMS message arrives, the background work item is activated.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
