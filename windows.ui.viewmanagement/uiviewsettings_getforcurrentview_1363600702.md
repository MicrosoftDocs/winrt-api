---
-api-id: M:Windows.UI.ViewManagement.UIViewSettings.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.ViewManagement.UIViewSettings GetForCurrentView()
-->

# Windows.UI.ViewManagement.UIViewSettings.GetForCurrentView

## -description
Gets the UI states and behaviors associated with the device mode (Tablet or Desktop) for the active app.

### Tablet mode (Windows 10 only)

> [!NOTE]
> In Windows 11, [Tablet mode](/windows-hardware/design/device-experiences/continuum) is removed and new functionality is included for keyboard attach and detach postures.

Some devices (PC, laptop, tablet) support both a Desktop and [Tablet](/windows-hardware/design/device-experiences/continuum) mode.

On Windows 10 only, users can switch between running in Tablet mode and Desktop mode by going to **Settings &gt; System &gt; Tablet mode** and setting **Make Windows more touch-friendly when using your device as a tablet**.

## -returns
A [UIViewSettings](uiviewsettings.md) instance that can be used to get and set view settings properties.

## -remarks

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
