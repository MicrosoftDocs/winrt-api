---
-api-id: T:Windows.UI.Xaml.Controls.ScrollViewer
-api-type: winrt class
---

<!-- Class syntax.
public class ScrollViewer : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IScrollViewer, Windows.UI.Xaml.Controls.IScrollViewer2, Windows.UI.Xaml.Controls.IScrollViewer3
-->

# Windows.UI.Xaml.Controls.ScrollViewer

## -description
Represents a scrollable area that can contain other visible elements.


## -xaml-syntax
```xaml
<ScrollViewer .../>
-or-
<ScrollViewer ...>
content
</ScrollViewer>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls).

ScrollViewer is a container control that lets the user pan and zoom its content.

<img alt="Scroll viewer control" src="images/controls/ScrollViewerBasic.png" />

A ScrollViewer enables content to be displayed in a smaller area than its actual size. When the content of the ScrollViewer is not entirely visible, the ScrollViewer displays scrollbars that the user can use to move the content areas that is visible. The area that includes all of the content of the ScrollViewer is the extent. The visible area of the content is the viewport.

It's typical for a ScrollViewer control to exist as a composite part of other controls. A ScrollViewer part along with the [ScrollContentPresenter](scrollcontentpresenter.md) class for support will display a viewport along with scrollbars only when the host control's layout space is being constrained smaller than the expanded content size. This is often the case for lists, so [ListView](listview.md) and [GridView](gridview.md) templates always include a ScrollViewer. [TextBox](textbox.md) and [RichEditBox](richeditbox.md) also include a ScrollViewer in their templates.

When a ScrollViewer part in a control exists, the host control often has built-in event handling for certain input events and manipulations that enable the content to scroll. For example, a [GridView](gridview.md) interprets a swipe gesture and this causes the content to scroll horizontally. The input events and raw manipulations that the host control receives are considered handled by the control, and lower-level events such as [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) won't be raised and won't bubble to any parent containers either. You can change some of the built-in control handling by overriding a control class and the **On**_Event_ virtual methods for events, or by retemplating the control. But in either case it's not trivial to reproduce the original default behavior, which is typically there so that the control reacts in expected ways to events and to a user's input actions and gestures. So you should consider whether you really need that input event to fire. You might want to investigate whether there are other input events or gestures that are not being control-handled, and use those in your app or control interaction design.

To make it possible for controls that include a ScrollViewer to influence some of the behavior and properties that are from within the ScrollViewer part, ScrollViewer defines a number of XAML attached properties that can be set in styles and used in template bindings.

If you need to handle pointer events for a [UIElement](../windows.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectmanipulation()](../windows.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation()](../windows.ui.xaml/uielement_trystartdirectmanipulation_1983346775.md).

### Pen interaction

Starting with Windows 10, version 1709 (SDK 16299), the default behavior of an active pen in a UWP app is to scroll/pan (just like touch, touchpad, and passive pen). The ScrollViewer consumes pointer events unless you specify that you want to handle the events yourself, and don't want them to be used for manipulation. 

In versions of Windows 10 prior to 1709, the default behavior was to select text.

If your app should use an active pen for text selection, you can override pen scrolling and revert to the previous behavior. To do this, handle the [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event and set the [ManipulationMode](../windows.ui.xaml/uielement_manipulationmode.md) property to specify that the system should not handle pen interaction to scroll your main ScrollViewer. You also handle the [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md) and [PointerCanceled](../windows.ui.xaml/uielement_pointercanceled.md) events to turn the default system behavior back on when the Pen is removed.

This  example shows how to:

+ Register the events using the [AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md) method with the *handledEventsToo* parameter set to **true**.
+ Check if the pointer device is a [Pen](../windows.devices.input/pointerdevicetype.md).
+ In the [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event handler, turn off system manipulation support in the ScrollViewer.
+ In the [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md) and [PointerCanceled](../windows.ui.xaml/uielement_pointercanceled.md) event handlers, turn back on system manipulation support.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <ScrollViewer x:Name="myScrollViewer">
        <Image Source="Assets/StoreLogo.png"/>
    </ScrollViewer>
</Grid>
```

```csharp
public MainPage()
{
    this.InitializeComponent();

    this.myScrollViewer.AddHandler(UIElement.PointerPressedEvent, 
        new PointerEventHandler(myScrollViewer_PointerPressed), 
        true /*handledEventsToo*/);
    this.myScrollViewer.AddHandler(UIElement.PointerReleasedEvent, 
        new PointerEventHandler(myScrollViewer_PointerReleased), 
        true /*handledEventsToo*/);
    this.myScrollViewer.AddHandler(UIElement.PointerCanceledEvent, 
        new PointerEventHandler(myScrollViewer_PointerCanceled), 
        true /*handledEventsToo*/);
}

private void myScrollViewer_PointerPressed(object sender, PointerRoutedEventArgs e)
{
    if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
    {
        (myScrollViewer.Content as UIElement).ManipulationMode &= ~ManipulationModes.System;
    }
}

private void myScrollViewer_PointerReleased(object sender, PointerRoutedEventArgs e)
{
    if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
    {
        (myScrollViewer.Content as UIElement).ManipulationMode |= ManipulationModes.System;
    }
}

private void myScrollViewer_PointerCanceled(object sender, PointerRoutedEventArgs e)
{
    if (e.Pointer.PointerDeviceType == Windows.Devices.Input.PointerDeviceType.Pen)
    {
        (myScrollViewer.Content as UIElement).ManipulationMode |= ManipulationModes.System;
    }
}
```

### ScrollViewer XAML attached properties

ScrollViewer defines the following XAML attached properties:

+ [ScrollViewer.BringIntoViewOnFocusChange](scrollviewer_bringintoviewonfocuschange.md)
+ [ScrollViewer.HorizontalScrollBarVisibility](scrollviewer_horizontalscrollbarvisibility.md)
+ [ScrollViewer.HorizontalScrollMode](scrollviewer_horizontalscrollmode.md)
+ [ScrollViewer.IsDeferredScrollingEnabled](scrollviewer_isdeferredscrollingenabled.md)
+ [ScrollViewer.IsHorizontalRailEnabled](scrollviewer_ishorizontalrailenabled.md)
+ [ScrollViewer.IsHorizontalScrollChainingEnabled](scrollviewer_ishorizontalscrollchainingenabled.md)
+ [ScrollViewer.IsScrollInertiaEnabled](scrollviewer_isscrollinertiaenabled.md)
+ [ScrollViewer.IsVerticalRailEnabled](scrollviewer_isverticalrailenabled.md)
+ [ScrollViewer.IsVerticalScrollChainingEnabled](scrollviewer_isverticalscrollchainingenabled.md)
+ [ScrollViewer.IsZoomChainingEnabled](scrollviewer_iszoomchainingenabled.md)
+ [ScrollViewer.IsZoomInertiaEnabled](scrollviewer_iszoominertiaenabled.md)
+ [ScrollViewer.VerticalScrollBarVisibility](scrollviewer_verticalscrollbarvisibilityproperty.md)
+ [ScrollViewer.VerticalScrollMode](scrollviewer_verticalscrollmode.md)
+ [ScrollViewer.ZoomMode](scrollviewer_zoommode.md)

These XAML attached properties are intended for cases where the ScrollViewer is implicit, such as when the ScrollViewer exists in the default template for a [ListView](listview.md) or [GridView](gridview.md), and you want to be able to influence the scrolling behavior of the control without accessing template parts. For cases where a ScrollViewer is explicit in your XAML, as is shown in the example code in the Examples section, you don't need to use attached property syntax. Just use attribute syntax, for example `<ScrollViewer ZoomMode="Enabled" />`.

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetHorizontalScrollMode](scrollviewer_gethorizontalscrollmode_600828222.md) and [SetHorizontalScrollMode](scrollviewer_sethorizontalscrollmode_2014527863.md) methods support and provide the equivalent code-only support for [ScrollViewer.HorizontalScrollMode](scrollviewer_horizontalscrollmode.md). Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 462116-->
### Windows 8 behavior

### Gesture handling by track pad devices
For Windows 8, track pad device gestures that were input-handled by a ScrollViewer control part were interpreted as mouse wheel input, and thus would fire a [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event. Starting with Windows 8.1, ScrollViewer uses an underlying manipulation logic that interprets track pad gestures as actions that the ScrollViewer responds to, and thus the gesture is considered handled by the control and the [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event is not fired anymore.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) being fired in fewer cases. Also, the behavior that's now built-in to ScrollViewer may be duplicating what your handler would have done.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 461907-->
### App UI for On-Screen Keyboard

Windows 8 had an internally implemented logic that would associate a ScrollViewer with the overall app UI whenever the user invokes the On-Screen Keyboard. This On-Screen Keyboard is a specific accessibility feature that users request through the Ease of Access Center. It's not the same as the soft keyboard that can appear in app UI for text input controls, if the system detects no keyboard device. What the internal ScrollViewer does here is to make it possible to scroll the area where the app is, if scrolling it is forced because the keyboard is taking UI space.

Starting with Windows 8.1, the system still has UI/layout behavior when the On-Screen Keyboard appears, but it no longer uses this internally created ScrollViewer. Instead it uses a dedicated internal control that app code can't change or inspect.

Most aspects of this behavior change don't affect apps at all. However, your app might have anticipated this behavior, by providing an implicit [Style](../windows.ui.xaml/style.md) for ScrollViewer that's meant to change the layout, or by walking the tree with [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) to find this internally created ScrollViewer and alter it at run-time. For an app that is compiled for Windows 8.1 that code won't be useful.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | AnchorRequested |
| 1809 | 17763 | CanContentRenderOutsideBounds |
| 1809 | 17763 | CurrentAnchor |
| 1809 | 17763 | GetCanContentRenderOutsideBounds |
| 1809 | 17763 | HorizontalAnchorRatio |
| 1809 | 17763 | ReduceViewportForCoreInputViewOcclusions |
| 1809 | 17763 | RegisterAnchorCandidate |
| 1809 | 17763 | SetCanContentRenderOutsideBounds |
| 1809 | 17763 | UnregisterAnchorCandidate |
| 1809 | 17763 | VerticalAnchorRatio |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Scroll viewer](/windows/apps/design/controls/scroll-controls).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the ScrollViewer in action](winui2gallery:/item/ScrollViewer)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

The following XAML creates a large [TextBlock](textblock.md) inside a ScrollViewer, along with another copy of the [TextBlock](textblock.md) for comparison.

[!code-xaml[1](../windows.ui.xaml.data/code/System.Windows.Controls.ScrollViewer/csharp/Page.xaml#Snippet1)]

## -see-also
[Scroll viewer controls overview](/windows/uwp/design/controls-and-patterns/scroll-controls)
