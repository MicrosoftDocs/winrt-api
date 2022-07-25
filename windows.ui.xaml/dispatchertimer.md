---
-api-id: T:Windows.UI.Xaml.DispatcherTimer
-api-type: winrt class
---

<!-- Class syntax.
public class DispatcherTimer : Windows.UI.Xaml.IDispatcherTimer
-->

# Windows.UI.Xaml.DispatcherTimer

## -description
Provides a timer that is integrated into the **Dispatcher** queue, which is processed at a specified interval of time and at a specified priority.



## -remarks
The DispatcherTimer can be used to run code on the same thread that produces the UI thread. Code running on this thread has the privilege to create and modify objects that can only be created and modified on the UI thread. To specify that code should run on the UI thread, set the [Interval](dispatchertimer_interval.md) property and then call the [Start](dispatchertimer_start_1587696324.md) method. The [Tick](dispatchertimer_tick.md) event fires after the time specified in [Interval](dispatchertimer_interval.md) has elapsed. [Tick](dispatchertimer_tick.md) continues firing at the same [Interval](dispatchertimer_interval.md) until the [Stop](dispatchertimer_stop_1201535524.md) method is called, the app terminates, or the app is suspended (fires [Suspending](application_suspending.md)).

One scenario for DispatcherTimer is to check properties on sensors where changes to the sensor values are not purely event-driven, or the events don't give you the granularity you want. You can see this in the [Accelerometer sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/Accelerometer).

Other scenarios for DispatcherTimer include checking for state changes that don't have related events, or for periodic UI updates that can't use a storyboarded animation or a two-way binding.

> [!TIP]
> If you're migrating Microsoft Silverlight or Windows Presentation Foundation (WPF) code, the DispatcherTimer and the related **Dispatcher** was in a separate **System.Windows.Threading** namespace. There is no **Windows.UI.Xaml.Threading** namespace in the Windows Runtime, so this class is in [Windows.UI.Xaml](windows_ui_xaml.md).

If you aren't doing anything with the UI thread in your **Tick** handlers and just need a timer, you could also use [ThreadPoolTimer](../windows.system.threading/threadpooltimer.md) instead. Also, for techniques like [ThreadPoolTimer](../windows.system.threading/threadpooltimer.md) or a .NET [Task](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true), you aren't totally isolated from the UI thread. You could still assign to the UI thread asynchronously using [CoreDispatcher.RunAsync](../windows.ui.core/coredispatcher_runasync_447339746.md).

## -examples
This example code implements a simple console-style timer that writes data to a [TextBlock](../windows.ui.xaml.controls/textblock.md) named `TimerLog` (XAML that defines `TimerLog` is not shown). The [Interval](dispatchertimer_interval.md) value is set to 1, and the log displays the actual elapsed time for each [Tick](dispatchertimer_tick.md).

[!code-csharp[1](../windows.ui.xaml/code/DispatcherTimer/csharp/MainPage.xaml.cs#Snippet1)]

```cppwinrt
// MainPage.cpp
...
#include <chrono>
...
void MainPage::StartTimerAndRegisterHandler()
{
    Windows::UI::Xaml::DispatcherTimer timer;
    timer.Interval(std::chrono::milliseconds{ 500 });
    auto registrationtoken = timer.Tick({this, &MainPage::OnTick });
    timer.Start();
}

void MainPage::OnTick(Windows::Foundation::IInspectable const& /* sender */,
    Windows::Foundation::IInspectable const& /* e */)
{
    // do something on each tick here ...
}
```

```cppcx
// .cpp definition, .h not shown
void MainPage::StartTimerAndRegisterHandler() {
    auto timer = ref new Windows::UI::Xaml::DispatcherTimer();
    TimeSpan ts;
    ts.Duration = 500;
    timer->Interval = ts;
    timer->Start();
    auto registrationtoken = timer->Tick += ref new EventHandler<Object^>(this,&MainPage::OnTick);
}
void MainPage::OnTick(Object^ sender, Object^ e) {
    // do something on each tick here ...
}
```

## -see-also
[CoreDispatcher](../windows.ui.core/coredispatcher.md), [ThreadPoolTimer](../windows.system.threading/threadpooltimer.md)
