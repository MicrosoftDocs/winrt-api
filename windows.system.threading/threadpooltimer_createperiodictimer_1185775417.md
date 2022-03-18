---
-api-id: M:Windows.System.Threading.ThreadPoolTimer.CreatePeriodicTimer(Windows.System.Threading.TimerElapsedHandler,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.ThreadPoolTimer CreatePeriodicTimer(Windows.System.Threading.TimerElapsedHandler handler, Windows.Foundation.TimeSpan period)
-->

# Windows.System.Threading.ThreadPoolTimer.CreatePeriodicTimer

## -description
Creates a periodic timer.

## -parameters
### -param handler
The method to call when the timer expires.

### -param period
The amount of time until the timer expires. The timer reactivates each time the period elapses, until the timer is canceled.

> **C++**
> This amount of time is specified in ticks (100-nanosecond units) using the [Windows::Foundation::TimeSpan](../windows.foundation/timespan.md) structure.



> **JavaScript and C#**
> This amount of time is specified using the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. It can be specified in ticks, or it can be specified in milliseconds, seconds, and so on.

## -returns
An instance of a periodic timer.

## -remarks

## -examples

## -see-also
[CreatePeriodicTimer(TimerElapsedHandler, TimeSpan, TimerDestroyedHandler)](threadpooltimer_createperiodictimer_537693899.md)