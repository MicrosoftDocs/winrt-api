---
-api-id: N:Windows.Devices.Sms
-api-type: winrt namespace
---

# Windows.Devices.Sms

## -description

Provides the ability to send and receive Short Message Service (SMS) messages, filter incoming messages, and send messages silently, as well as to query properties about a Mobile Broadband SMS Device. Use this API to implement Mobile Operator (MO) applications that use app-directed SMS to implement MO features such as visual voice mail apps.

This is not the recommended API if you are developing an alternative to the built-in messaging app. Instead, you should use the [Windows.AppModel.Chat](../windows.applicationmodel.chat/windows_applicationmodel_chat.md) API for developing messaging apps. The Chat API maintains a common data store for messages so that all of the apps that use the Chat API show a consistent view of messages. **Windows.Devices.Sms** offers no such data store, and in fact using it can interfere with SMS messages being delivered to apps that use the Chat API.

Note that this functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

Note that several classes in this namespace are supported only for the maintenance of legacy desktop apps that used it in earlier versions of Windows; and if you do use the legacy support classes, you must specify the **Windows.Devices.Sms.LegacySmsApiContract** in your app's manifest. Do not use the legacy support classes if you are developing a new app for Windows 10. Instead, use the members of this namespace that do not require the **Windows.Devices.Sms.LegacySmsApiContract**.

## -remarks

To have your background task be notified when an SMS has been received, handle the [Windows.ApplicationModel.Background.SmsMessageReceivedTrigger](../windows.applicationmodel.background/smsmessagereceivedtrigger.md).

## -examples

## -see-also

[App capability declarations](/windows/uwp/packaging/app-capability-declarations), [SMS send and receive sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SmsSendAndReceive), [SMS send and receive sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SmsSendAndReceive)

## -capabilities

cellularMessaging, sms
