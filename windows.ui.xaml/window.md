---
-api-id: T:Windows.UI.Xaml.Window
-api-type: winrt class
---

<!-- Class syntax.
public class Window : Windows.UI.Xaml.IWindow, Windows.UI.Xaml.IWindow2
-->

# Windows.UI.Xaml.Window

## -description
Represents an application window.



## -remarks
This class represents the window of the current [Application](application.md). In the same manner as the static [Application](application_application_1221375020.md) property, the static [Current](application_current.md) property will return the app window object. From this object, an app can utilize the [Dispatcher](window_dispatcher.md) or determine the size of the Window from the [Bounds](window_bounds.md) property. The most common usage for Window is setting a [UIElement](uielement.md) to the [Content](window_content.md) that represents the app UI. This is usually done as part of app activation (for example in the [OnLaunched](application_onlaunched_859642554.md) override.) You can change this window content throughout the lifetime of the window.

There is no XAML representation of the Window class because it is not a control.

A Window object is just surfacing information from [CoreWindow](../windows.ui.core/corewindow.md), which in turn is referencing the window created by the system.

Make sure to call [Activate](window_activate_1797342875.md) on any Window you use on initial activation. If you use the default app templates from Microsoft Visual Studio, calling [Window.Activate](window_activate_1797342875.md) is part of the initial code in the app.xaml code-behind file.

The LayoutAwarePage class that is part of some application templates in Microsoft Visual Studio has handling for the [SizeChanged](window_sizechanged.md) event, which is used for keeping track of visual states that match values of [ApplicationViewState](../windows.ui.viewmanagement/applicationviewstate.md). LayoutAwarePage also has code that checks [Bounds](window_bounds.md) and uses this value to influence how page-wide input events are handled.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Compositor |
| 1903 | 18362 | UIContext |

### Additional interface members

<table><tr><td><a href="/windows/apps/api-reference/interface-members/ixamlsourcetransparency-isbackgroundtransparent">IXamlSourceTransparency.IsBackgroundTransparent</a></td><td>Gets or sets a value that specifies whether the background of all DesktopWindowXamlSource objects on the current thread is transparent.</td></tr></table>

## -examples
The following code example shows the [OnLaunched](application_onlaunched_859642554.md) method override generated for the blank application template in Microsoft Visual Studio. This code demonstrates typical usage patterns for the [Current](window_current.md) and [Content](window_content.md) properties and the [Activate](window_activate_1797342875.md) method.

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs args)
{
    // Create a Frame to act navigation context and navigate to the first page
    var rootFrame = new Frame();
    rootFrame.Navigate(typeof(BlankPage));

    // Place the frame in the current Window and ensure that it is active
    Window.Current.Content = rootFrame;
    Window.Current.Activate();
}

```

```vb
Protected Overrides Sub OnLaunched(args As 
    Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)

    ' Create a Frame to act navigation context and navigate to the first page
    Dim rootFrame As New Frame()
    rootFrame.Navigate(GetType(BlankPage))

    ' Place the frame in the current Window and ensure that it is active
    Window.Current.Content = rootFrame
    Window.Current.Activate()
End Sub

```



## -see-also
[OnLaunched](application_onlaunched_859642554.md), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [CoreWindow](../windows.ui.core/corewindow.md)
