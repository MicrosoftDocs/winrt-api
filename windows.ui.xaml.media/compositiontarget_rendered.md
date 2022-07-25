---
-api-id: E:Windows.UI.Xaml.Media.CompositionTarget.Rendered
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler Rendered<RenderedEventArgs>
-->

# Windows.UI.Xaml.Media.CompositionTarget.Rendered

## -description
Occurs immediately after the core rendering process renders a frame. This event lets you determine how long each frame takes to render.



## -remarks

> [!TIP]
> We recommend that you use the Visual Studio [Application Timeline](/visualstudio/profiling/application-timeline) profiler when developing and testing your application. It gives more detailed information on your application's resource consumption, including time spent preparing UI frames.

You can use the Rendered event to measure frame duration and application responsiveness at runtime without Visual Studio or a debugger attached. For example, this could be used to generate telemetry for apps after they are deployed, or to adjust the amount of custom DirectX rendering work an application is doing each frame.

A longer frame duration means your app had to perform more work before a frame could be rendered. Frame durations longer than approximately 16 milliseconds mean that your application is not able to update at the recommended frequency of 60 frames per second, and so the user might experience a noticeable delay in UI responsiveness.

If you do see long frame durations then consider profiling your application using the Visual Studio Application Timeline and implementing the recommended [Performance best practices](/windows/uwp/debug-test-perf/performance-and-xaml-ui).

Handlers for Rendered run on the UI thread even though they're not tied to any specific UI element. It's a good idea to remove any Rendered handlers when you no longer need them, and add them only when you do need them.


## -see-also
Visual Studio [Application Timeline](/visualstudio/profiling/application-timeline), [Performance best practices for Windows Store apps](/windows/uwp/debug-test-perf/performance-and-xaml-ui)

## -examples
