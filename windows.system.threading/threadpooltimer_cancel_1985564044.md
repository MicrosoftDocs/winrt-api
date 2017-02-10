---
-api-id: M:Windows.System.Threading.ThreadPoolTimer.Cancel
-api-type: winrt method
---

<!-- Method syntax
public void Cancel()
-->

# Windows.System.Threading.ThreadPoolTimer.Cancel

## -description
Cancels a timer.

## -remarks
When a timer is canceled, pending [TimerElapsedHandler](timerelapsedhandler.md) delegates are also canceled. [TimerElapsedHandler](timerelapsedhandler.md) delegates that are already running are allowed to finish.

## -examples

## -see-also
