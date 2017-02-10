---
-api-id: T:Windows.UI.ViewManagement.UIViewSettings
-api-type: winrt class
---

<!-- Class syntax.
public class UIViewSettings : Windows.UI.ViewManagement.IUIViewSettings
-->

# Windows.UI.ViewManagement.UIViewSettings

## -description
Represents UI states and behaviors associated with the device mode (Tablet or Desktop) and input device type.

> [!NOTE]
> Some devices (PC, laptop, tablet) support both Desktop and Tablet mode.

Users can switch between running in Tablet mode and Desktop mode by going to **Settings &gt; System &gt; Tablet mode** and setting **Make Windows more touch-friendly when using your device as a tablet**.

## -remarks
To get an instance of this class, call [GetForCurrentView](uiviewsettings_getforcurrentview.md).

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
