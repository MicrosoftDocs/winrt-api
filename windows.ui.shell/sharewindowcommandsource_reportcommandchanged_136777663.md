---
-api-id: M:Windows.UI.Shell.ShareWindowCommandSource.ReportCommandChanged
-api-type: winrt method
---

# Windows.UI.Shell.ShareWindowCommandSource.ReportCommandChanged

<!--
public void ReportCommandChanged ();
-->

## -description

Indicates to the Windows Shell that the sharing state of your communications app has changed.

Call this method whenever your communications app's sharing state changes. If you successfully share a new window in a call or meeting, or you remove an already shared window (whether that's via your own UI, or triggered by a Windows Taskbar action), you must notify your [ShareWindowCommandSource](sharewindowcommandsource.md) instance of that change by calling **ReportCommandChanged**.

The Shell will then flush any information it has received as part of any [ShareWindowCommandSource.CommandRequested](sharewindowcommandsource_commandrequested.md) event, and will update its visible share commands to match the current state of your app.

## -remarks

## -see-also
[ShareWindowCommandSource](sharewindowcommandsource.md), [ShareWindowCommandSource.CommandRequested](sharewindowcommandsource_commandrequested.md)

## -examples
