---
-api-id: P:Windows.System.Threading.ThreadPoolTimer.Delay
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Delay { get; }
-->

# Windows.System.Threading.ThreadPoolTimer.Delay

## -description
Gets the timeout value of a single-use timer created with [CreateTimer](threadpooltimer_createtimer_1268637445.md).

## -property-value
The timeout value. When the timeout value elapses, the timer expires and its [TimerElapsedHandler](timerelapsedhandler.md) delegate is called.

> **C++**
> This amount of time is specified in ticks (100-nanosecond units) using the [Windows::Foundation::TimeSpan](../windows.foundation/timespan.md) structure.



> **JavaScript and C#**
> This amount of time is specified using the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. It can be specified in ticks, or it can be specified in milliseconds, seconds, and so on.

## -remarks
A timer begins counting down as soon as the timer object is created.

## -examples

## -see-also
