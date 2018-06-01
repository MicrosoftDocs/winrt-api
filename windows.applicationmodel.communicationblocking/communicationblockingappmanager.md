---
-api-id: T:Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingAppManager
-api-type: winrt class
---

<!-- Class syntax.
public class CommunicationBlockingAppManager 
-->

# Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingAppManager

## -description

Determines the application to use as a blocking application.

## -remarks

A user can install multiple applications that are capable of filtering messages and calls. However, only one of these blocking applications can be active at a time. This class is used to determine the active blocking application.

When an application is selected to be the active call blocking app, it will be notified by [CommunicationBlockingAppSetAsActiveTrigger](../windows.applicationmodel.background/communicationblockingappsetasactivetrigger.md)

## -examples

## -see-also

[Communication blocking and filtering sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624164)