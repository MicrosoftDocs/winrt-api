---
-api-id: P:Windows.System.Threading.ThreadPoolTimer.Period
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Period { get; }
-->

# Windows.System.Threading.ThreadPoolTimer.Period

## -description
Gets the timeout value of a periodic timer created with [CreatePeriodicTimer](threadpooltimer_createperiodictimer_1185775417.md).

## -property-value
The timeout value. When the timeout value elapses, the timer expires, its [TimerElapsedHandler](timerelapsedhandler.md) delegate is called, and the timer reactivates. This behavior continues until the timer is canceled. 

> **C++**
> This amount of time is specified in ticks (100-nanosecond units) using the [Windows::Foundation::TimeSpan](../windows.foundation/timespan.md) structure.



> **JavaScript and C#**
> This amount of time is specified using the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. It can be specified in ticks, or it can be specified in milliseconds, seconds, and so on.

## -remarks
A periodic timer begins counting down as soon as the timer object is created. When the timer expires, it is reactivated and begins counting down again.

## -examples

## -see-also
