---
-api-id: M:Windows.UI.Xaml.DispatcherTimer.Stop
-api-type: winrt method
---

<!-- Method syntax
public void Stop()
-->

# Windows.UI.Xaml.DispatcherTimer.Stop

## -description
Stops the [DispatcherTimer](dispatchertimer.md).



## -remarks
If Stop is called when the timer interval has just elapsed, it's possible that the timer already queued a Tick event. This event will still be raised.

## -examples

## -see-also
