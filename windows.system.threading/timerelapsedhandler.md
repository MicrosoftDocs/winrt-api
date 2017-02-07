---
-api-id: T:Windows.System.Threading.TimerElapsedHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void TimerElapsedHandler(Windows.System.Threading.ThreadPoolTimer timer)
-->
# Windows.System.Threading.TimerElapsedHandler

## -description
Represents a method that is called when a timer created with [CreateTimer](threadpooltimer_createtimer.md) or [CreatePeriodicTimer](threadpooltimer_createperiodictimer.md) expires.

## -parameters
### -param timer
The timer to associate with this method. When this timer expires, the method is called.


## -remarks
When a timer is canceled, pending [TimerElapsedHandler](timerelapsedhandler.md) delegates are also canceled. [TimerElapsedHandler](timerelapsedhandler.md) delegates that are already running are allowed to finish.

## -examples

## -see-also