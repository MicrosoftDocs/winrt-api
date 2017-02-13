---
-api-id: M:Windows.UI.Xaml.Window.SetTitleBar(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public void SetTitleBar(Windows.UI.Xaml.UIElement value)
-->

# Windows.UI.Xaml.Window.SetTitleBar

## -description
Makes a XAML element interact with the system as if it’s the title bar.

## -parameters
### -param value
Custom XAML content that should act as the title bar. To use multiple objects, wrap them in a container element such as one derived from [Panel](../windows.ui.xaml.controls/panel.md).

## -remarks
This method lets you specify a XAML element that interacts with the system as if it’s the app window's title bar. When you use this method, you typically set the [CoreApplicationViewTitleBar.ExtendViewIntoTitleBar](../windows.applicationmodel.core/coreapplicationviewtitlebar_extendviewintotitlebar.md) property to **true** in order to hide the default system title bar. However, even when the default system title bar is not hidden, this can be used to make additional regions in your app behave like the title bar.



Use the [CoreApplicationView.TitleBar](../windows.applicationmodel.core/coreapplicationview_titlebar.md) property to get the instance of [CoreApplicationViewTitleBar](../windows.applicationmodel.core/coreapplicationviewtitlebar.md) for your app window, like this.

```csharp
// Requires using Windows.ApplicationModel.Core
CoreApplicationView coreView = CoreApplication.GetCurrentView();
CoreApplicationViewTitleBar coreTitleBar = coreView.TitleBar;
coreTitleBar.ExtendViewIntoTitleBar = true;

// -- OR --

CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
```

> [!NOTE]
> This method has no effect when an app is run on a mobile device, because apps are always full-screen on mobile devices and do not have a window title bar.

### Input

When you call this method to set a XAML [UIElement](uielement.md) as the title bar, it lets Windows handle input to the title bar [UIElement](uielement.md) the same way it handles input to the default system title bar. For example, a user can move the window by dragging the XAML [UIElement](uielement.md), or invoke the window context menu by right-clicking it.

This means that your app no longer receives pointer input when the user interacts with the target [UIElement](uielement.md) or its children using touch, mouse, or pen. However, you must still handle (or prevent) keyboard input, and determine whether content in the title bar can receive focus by tabbing to it with the keyboard.

### Layout and appearance

You must update the visual content and layout of the target [UIElement](uielement.md) in response to title bar changes, like visibility and size.

To match the visibility of the system title bar, handle the [CoreApplicationViewTitleBar.IsVisibleChanged](../windows.applicationmodel.core/coreapplicationviewtitlebar_isvisiblechanged.md) event and respect the [CoreApplicationViewTitleBar.IsVisible](../windows.applicationmodel.core/coreapplicationviewtitlebar_isvisible.md) property by showing and hiding your custom title bar as appropriate. This ensures that your custom title bar content is correctly hidden when the system title bar is hidden; for example, when the user chooses to display your app in full-screen mode.

To ensure that your title bar matches the size of other title bar elements like the always-present system Minimize, Maximize, and Close buttons, handle the [CoreApplicationViewTitleBar.LayoutMetricsChanged](../windows.applicationmodel.core/coreapplicationviewtitlebar_layoutmetricschanged.md) event and respect the [CoreApplicationViewTitleBar.Height](../windows.applicationmodel.core/coreapplicationviewtitlebar_height.md), [SystemOverlayLeftInset](../windows.applicationmodel.core/coreapplicationviewtitlebar_systemoverlayleftinset.md), and [SystemOverlayRightInset](../windows.applicationmodel.core/coreapplicationviewtitlebar_systemoverlayrightinset.md) properties.

The default title bar buttons, such as Minimize, Maximize, and Close, are always shown by the system, so you might also want to modify their color to match your custom XAML title bar content. To do this, use the [Windows.UI.ViewManagement.ApplicationView.TitleBar](../windows.ui.viewmanagement/applicationview_titlebar.md) property to get the instance of [ApplicationViewTitleBar](../windows.ui.viewmanagement/applicationviewtitlebar.md) for your app window. You can then set the various color properties on [ApplicationViewTitleBar](../windows.ui.viewmanagement/applicationviewtitlebar.md) to modify the default buttons.

## -examples

## -see-also
