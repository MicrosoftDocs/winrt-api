---
-api-id: P:Windows.Graphics.Printing.PrintTaskRequest.Deadline
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.DateTime Deadline { get; }
-->

# Windows.Graphics.Printing.PrintTaskRequest.Deadline

## -description
Gets a [DateTime](../windows.foundation/datetime.md) value that indicates how long an app has to respond to the [PrintTaskRequested](printmanager_printtaskrequested.md) event. If the system has not received a response from the [PrintTaskRequested](printmanager_printtaskrequested.md) event handler by the time the deadline is reached, then the print task is ignored.

## -property-value
A value that indicates how long an app has to respond to the [PrintTaskRequested](printmanager_printtaskrequested.md) event.

## -remarks

## -examples

## -see-also
[DateTime](../windows.foundation/datetime.md)