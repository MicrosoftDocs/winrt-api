---
-api-id: M:Windows.System.Threading.ThreadPoolTimer.CreateTimer(Windows.System.Threading.TimerElapsedHandler,Windows.Foundation.TimeSpan,Windows.System.Threading.TimerDestroyedHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Threading.ThreadPoolTimer CreateTimer(Windows.System.Threading.TimerElapsedHandler handler, Windows.Foundation.TimeSpan delay, Windows.System.Threading.TimerDestroyedHandler destroyed)
-->

# Windows.System.Threading.ThreadPoolTimer.CreateTimer

## -description
Creates a single-use timer and specifies a method to call after the timer is complete. The timer is complete when the timer has expired and the final call to *handler* has finished.

## -parameters
### -param handler
The method to call when the timer expires.

### -param delay
The amount of time until the timer expires.

> **C++**
> This amount of time is specified in ticks (100-nanosecond units) using the [Windows::Foundation::TimeSpan](../windows.foundation/timespan.md) structure.



> **JavaScript and C#**
> This amount of time is specified using the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. It can be specified in ticks, or it can be specified in milliseconds, seconds, and so on.

### -param destroyed
The method to call after the timer is complete.

## -returns
An instance of a single-use timer.

## -remarks

## -examples

## -see-also
[CreateTimer(TimerElapsedHandler, TimeSpan)](threadpooltimer_createtimer_1268637445.md)