---
-api-id: T:Windows.System.Threading.ThreadPoolTimer
-api-type: winrt class
---

<!-- Class syntax.
public class ThreadPoolTimer : Windows.System.Threading.IThreadPoolTimer
-->

# Windows.System.Threading.ThreadPoolTimer

## -description
Represents a timer created with [CreateTimer](threadpooltimer_createtimer.md) or [CreatePeriodicTimer](threadpooltimer_createperiodictimer.md).

> [!NOTE]
> The ThreadPool API is supported for desktop as well as Windows Store apps.

## -remarks
The [CreatePeriodicTimer](threadpooltimer_createperiodictimer.md) or [CreateTimer](threadpooltimer_createtimer.md) method can be used to create this object.



> [!NOTE]
> A [TimeSpan](../windows.foundation/timespan.md) value of zero (or any value less than 1 millisecond) will cause the periodic timer to behave as a single-shot timer.

## -examples
The following code shows the creation of a periodic timer by passing in a [TimerElapsedHandler](timerelapsedhandler.md) delegate method. The delegate method should periodically check the **Canceled** property of the *operation* parameter, and exit gracefully if the work item has been cancelled.

```csharp
int period = 1000;

ThreadPoolTimer PeriodicTimer = 
    ThreadPoolTimer.CreatePeriodicTimer(ExampleTimerElapsedHandler,
                                        TimeSpan.FromMilliseconds(period));
```

When your app is done using the timer, it should be cancelled. The following code cancels the periodic timer created in the previous example.

```csharp
if (PeriodicTimer != null)
{
    PeriodicTimer.Cancel();
}
```



## -see-also