---
-api-id: M:Windows.System.Threading.ThreadPoolTimer.CreateTimer(Windows.System.Threading.TimerElapsedHandler,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.ThreadPoolTimer CreateTimer(Windows.System.Threading.TimerElapsedHandler handler, Windows.Foundation.TimeSpan delay)
-->

# Windows.System.Threading.ThreadPoolTimer.CreateTimer

## -description
Creates a single-use timer.

## -parameters
### -param handler
The method to call when the timer expires.

### -param delay
The amount of time until the timer expires.

> **C++**
> This amount of time is specified in ticks (100-nanosecond units) using the [Windows::Foundation::TimeSpan](../windows.foundation/timespan.md) structure.



> **JavaScript and C#**
> This amount of time is specified using the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. It can be specified in ticks, or it can be specified in milliseconds, seconds, and so on.

## -returns
An instance of a single-use timer.

## -remarks

## -examples

## -see-also
[CreateTimer(TimerElapsedHandler, TimeSpan, TimerDestroyedHandler)](threadpooltimer_createtimer_758918903.md)