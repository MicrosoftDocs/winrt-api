---
-api-id: T:Windows.ApplicationModel.Calls.PhoneLineWatcher
-api-type: winrt class
---

<!-- Class syntax.
public class PhoneLineWatcher : Windows.ApplicationModel.Calls.IPhoneLineWatcher
-->

# Windows.ApplicationModel.Calls.PhoneLineWatcher

## -description
Represents a class that monitors for new/removed/updated phone lines on the device and notifies listeners about any changes.

## -remarks
A phone line is a line that a user can use to either receive inbound or place outbound phone calls. A single device can have multiple lines. For example, the system creates a separate line specifically for VoIP applications that enables initiating an outbound call.

The system automatically detects the available lines on boot and then dynamically detects lines as lines are created or changed. The [PhoneLineWatcher](phonelinewatcher.md) class provides a mechanism for applications to receive events as new phone lines are detected and react to the changes.

This class implements the watcher pattern.

You can retrieve an instance of this class by calling [RequestLineWatcher](phonecallstore_requestlinewatcher_489228512.md).

The following example shows how to enumerate through all the current phone lines. 



[!code-csharp[GetLinesCS](../windows.applicationmodel.calls/code/ApplicationModel.Calls/cs/Scenario1.cs#SnippetGetLinesCS)]

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
