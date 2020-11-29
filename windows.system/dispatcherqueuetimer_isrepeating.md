---
-api-id: P:Windows.System.DispatcherQueueTimer.IsRepeating
-api-type: winrt property
---

<!-- Property syntax.
public bool IsRepeating { get;  set; }
-->

# Windows.System.DispatcherQueueTimer.IsRepeating

## -description
Indicates whether the timer is repeating.

Equivalent WinUI property: [Microsoft.System.DispatcherQueueTimer.IsRepeating](/windows/winui/api/microsoft.system.dispatcherqueuetimer.isrepeating).

## -property-value
**True** indicates that the timer fires every **DispatcherQueueTimer.Interval**; **false** means that it fires once, after **DispatcherQueueTimer.Interval** elapses.

## -remarks
If you change the **IsRepeating** value while the timer is running, the timer will restart with the new value.

## -see-also

## -examples
