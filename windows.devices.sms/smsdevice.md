---
-api-id: T:Windows.Devices.Sms.SmsDevice
-api-type: winrt class
---

<!-- Class syntax.
public class SmsDevice : Windows.Devices.Sms.ISmsDevice
-->

# Windows.Devices.Sms.SmsDevice

## -description
Supports the operation of a mobile broadband SMS device.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

> [!NOTE]
> Note that this class and its methods are supported for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use this class, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use this class if you are developing new apps for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks
Apps that use the [Windows.Devices.Sms](ismsdevice.md) API to send or receive text messages fail with **E_ACCESS_DENIED** if the user revokes access.

If access to the SMS device has been given to an app:
+ Calling [GetDefaultAsync](smsdevice_getdefaultasync.md) or [FromIdAsync](smsdevice_fromidasync.md) triggers a consent prompt the first time the app is run.
+ The error handlers for the asynchronous methods of [GetDefaultAsync](smsdevice_getdefaultasync.md) and [FromIdAsync](smsdevice_fromidasync.md) receive **E_ACCESS_DENIED** if the user did not grant permission in the consent prompt or if permission is revoked.
+ If the user re-enables access to SMS after revoking it, call [GetDefaultAsync](smsdevice_getdefaultasync.md) or [FromIdAsync](smsdevice_fromidasync.md) again to access SMS. For example, the error handler for **E_ACCESS_DENIED** error could display UI to instruct the user to re-enable SMS using the settings charm and to then tap a button to retry accessing SMS. The code behind the button should call [GetDefaultAsync](smsdevice_getdefaultasync.md) or [FromIdAsync](smsdevice_fromidasync.md) before making any other calls.
+ If the app is registering for the SMS background event ([Windows.ApplicationModel.Background.SystemTriggerType.SmsReceived](../windows.applicationmodel.background/systemtriggertype.md)), the app has to first call [GetDefaultAsync](smsdevice_getdefaultasync.md) or [FromIdAsync](smsdevice_fromidasync.md) again to access SMS to ensure the app has access. Calling [GetDefaultAsync](smsdevice_getdefaultasync.md) or [FromIdAsync](smsdevice_fromidasync.md) from the background task will not trigger a consent prompt. If it is a first time run or if the user did not grant permission or if permission is revoked then it will receive an **E_ACCESS_DENIED**.


The first use of the [SmsDevice](ismsdevice.md) object to call [FromIdAsync](smsdevice_fromidasync.md) or [GetDefaultAsync](smsdevice_getdefaultasync.md) by applications written in C# or C++ should be on the single-threaded apartment (STA) thread. Calls from a multi-threaded apartment (MTA) thread may result in undefined behavior.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
