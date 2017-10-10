---
-api-id: E:Windows.ApplicationModel.Calls.PhoneLine.LineChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler LineChanged<Windows.ApplicationModel.Calls.PhoneLine,  object>
-->

# Windows.ApplicationModel.Calls.PhoneLine.LineChanged

## -description
Occurs when and properties for the associated [PhoneLine](phoneline.md) instance change. This can occur when meta data changes like the voice mail count, the network state, or the cellular details.

## -remarks
The following example demonstrates how to monitor for and update the network state.



[!code-csharp[MonitorLineChanges](../windows.applicationmodel.calls/code/ApplicationModel.Calls/cs/Scenario1.cs#SnippetMonitorLineChanges)]

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
