---
-api-id: P:Windows.UI.ViewManagement.UIViewSettings.UserInteractionMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.ViewManagement.UserInteractionMode UserInteractionMode { get; }
-->

# Windows.UI.ViewManagement.UIViewSettings.UserInteractionMode

## -description

Gets a value that indicates whether the device UI is optimized for touch input or mouse input.

## -property-value

A value that indicates the input type (mouse or touch) the device UI is optimized for.

## -remarks

This property can be used to optimize your app based on input type.

### Tablet mode

> [!Important]
> **Windows 11 and newer**
>
> Tablet Mode is not supported.
>
> Pending new functionality, please use [Convertible Slate Mode (CSM)](/windows-hardware/customize/desktop/unattend/microsoft-windows-gpiobuttons-convertibleslatemode) to detect the keyboard attach and detach events.

Some devices (PC, laptop, tablet) support both a Desktop (mouse-optimized) and a [Tablet](/windows-hardware/design/device-experiences/continuum) (touch-optimized) mode.

On Windows 10 only, users can switch between running in Tablet mode and Desktop mode by going to **Settings > System > Tablet mode** and setting **Make Windows more touch-friendly when using your device as a tablet**.

In Tablet mode, app views are auto-maximized and the title bar is hidden. The taskbar remains visible. The system raises the [CoreWindow.SizeChanged](../windows.ui.core/corewindow_sizechanged.md) event when the value of this property changes. This is exposed to XAML apps as the [Window.SizeChanged](../windows.ui.xaml/window_sizechanged.md) event and to HTML apps as the [window.resize](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa741886(v=vs.85)) event.

## -examples

Here, we show how to use the interaction mode to optimize the app layout on launch or when the device mode is changed.

```csharp
using Windows.UI.Xaml;
using Windows.UI.ViewManagement;
 
public sealed partial class MainPage : Page
{
  public MainPage()
  {
    InitializeComponent();
    // Every view gets an initial SizeChanged, so we will do all our 
    // work there. This means that our view also responds to dynamic
    // changes in user interaction mode.
    Window.Current.SizeChanged += SizeChanged;
  }
 
  private void SizeChanged(object sender, RoutedEventArgs e)
  {
    switch(UIViewSettings.GetForCurrentView().UserInteractionMode)
    {
      case UserInteractionMode.Mouse:
        VisualStateManager.GoToState(this, "MouseLayout", true);
        break;
 
      case UserInteractionMode.Touch:
      default:
        VisualStateManager.GoToState(this, "TouchLayout", true);
        break;
    }
  }
}
```

## -see-also
