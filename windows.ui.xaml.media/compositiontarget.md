---
-api-id: T:Windows.UI.Xaml.Media.CompositionTarget
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionTarget : Windows.UI.Xaml.Media.ICompositionTarget
-->

# Windows.UI.Xaml.Media.CompositionTarget

## -description
Represents the composited display surface for an app. This class is mainly for Microsoft DirectX content interop scenarios.

## -remarks
[CompositionTarget](compositiontarget.md) has one member, [Rendering](compositiontarget_rendering.md). [Rendering](compositiontarget_rendering.md) is a static event that is fired by the XAML rendering system overall, not by the [Application](../windows.ui.xaml/application.md), [Window](../windows.ui.xaml/window.md), [Page](../windows.ui.xaml.controls/page.md) or any other specific object part of an app. [CompositionTarget](compositiontarget.md) 's sole purpose is to provide this hook into the rendering process. That's mainly relevant only to Microsoft DirectX content interop scenarios where you want to know when the XAML rendering happens, so that you can execute some Microsoft DirectX code in response. For scenarios that don't involve Microsoft DirectX content you probably won't need [Rendering](compositiontarget_rendering.md) and can just rely on the XAML rendering system running and performing all your composition and layout.

## -examples

## -see-also
[DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f), [Optimize animations and media](http://msdn.microsoft.com/library/de5b084c-dac1-430b-a15b-5b3d5fb698f7), [ shooting game sample](http://go.microsoft.com/fwlink/p/?linkid=238717)