---
-api-id: E:Windows.UI.Xaml.Media.CompositionTarget.Rendered
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler Rendered<RenderedEventArgs>
-->

# Windows.UI.Xaml.Media.CompositionTarget.Rendered

## -description
Occurs immediately after the core rendering process renders a frame. This event enables you to determine how long each frame takes to render.

## -remarks
The [Rendered](compositiontarget_rendered.md) event can be used to help measure application responsiveness.

The Visual Studio [Application Timeline](https://docs.microsoft.com/en-us/visualstudio/profiling/application-timeline) profiler should be used when developing and testing your application since it gives more detailed information on your application's resource consumption including time spent preparing UI frames.

The [Rendered](compositiontarget_rendered.md) event enables you to also get frame duration information at runtime without Visual Studio or a debugger attached. For example, this could be used to generate telemetry for apps after they are deployed.

A longer frame duration means your app had to perform more work before a frame could be rendered. Frame durations longer than approximately 16 milliseconds mean that your application was not able to update at the recommended frequency of 60 frames per second, and so the user may have experienced a noticeable delay in UI responsiveness. 

If you do see long frame durations then consider profiling your application using the Visual Studio Application Timeline and implementing the recommended [Performance best practices for Windows Store apps](https://docs.microsoft.com/en-us/previous-versions/windows/apps/hh750313(v=win.10)).

Handlers for [Rendered](compositiontarget_rendered.md) run on the UI thread even though they're not tied to any specific UI element. It's a good idea to remove any [Rendered](compositiontarget_rendered.md) handlers when you no longer need them, and add them only when you do need them.

## -see-also
Visual Studio [Application Timeline](https://docs.microsoft.com/en-us/visualstudio/profiling/application-timeline), [Performance best practices for Windows Store apps](https://docs.microsoft.com/en-us/previous-versions/windows/apps/hh750313(v=win.10))

## -examples
