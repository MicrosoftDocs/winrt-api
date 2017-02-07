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
[ScrollViewer](scrollviewer.md) is a container control that lets the user pan and zoom its content.

<img alt="Scroll viewer control" src="images/controls/ScrollViewerBasic.png" />

A [ScrollViewer](scrollviewer.md) enables content to be displayed in a smaller area than its actual size. When the content of the [ScrollViewer](scrollviewer.md) is not entirely visible, the [ScrollViewer](scrollviewer.md) displays scrollbars that the user can use to move the content areas that is visible. The area that includes all of the content of the [ScrollViewer](scrollviewer.md) is the extent. The visible area of the content is the viewport.

It's typical for a [ScrollViewer](scrollviewer.md) control to exist as a composite part of other controls. A [ScrollViewer](scrollviewer.md) part along with the [ScrollContentPresenter](scrollcontentpresenter.md) class for support will display a viewport along with scrollbars only when the host control's layout space is being constrained smaller than the expanded content size. This is often the case for lists, so [ListView](listview.md) and [GridView](gridview.md) templates always include a [ScrollViewer](scrollviewer.md). [TextBox](textbox.md) and [RichEditBox](richeditbox.md) also include a [ScrollViewer](scrollviewer.md) in their templates.

When a [ScrollViewer](scrollviewer.md) part in a control exists, the host control often has built-in event handling for certain input events and manipulations that enable the content to scroll. For example, a [GridView](gridview.md) interprets a swipe gesture and this causes the content to scroll horizontally. The input events and raw manipulations that the host control receives are considered handled by the control, and lower-level events such as [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) won't be raised and won't bubble to any parent containers either. You can change some of the built-in control handling by overriding a control class and the **On*** virtual methods for events, or by retemplating the control. But in either case it's not trivial to reproduce the original default behavior, which is typically there so that the control reacts in expected ways to events and to a user's input actions and gestures. So you should consider whether you really need that input event to fire. You might want to investigate whether there are other input events or gestures that are not being control-handled, and use those in your app or control interaction design.

To make it possible for controls that include a [ScrollViewer](scrollviewer.md) to influence some of the behavior and properties that are from within the [ScrollViewer](scrollviewer.md) part, [ScrollViewer](scrollviewer.md) defines a number of XAML attached properties that can be set in styles and used in template bindings.

### ScrollViewer XAML attached properties

[ScrollViewer](scrollviewer.md) defines the following XAML attached properties:

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
These XAML attached properties are intended for cases where the [ScrollViewer](scrollviewer.md) is implicit, such as when the [ScrollViewer](scrollviewer.md) exists in the default template for a [ListView](listview.md) or [GridView](gridview.md), and you want to be able to influence the scrolling behavior of the control without accessing template parts. For cases where a [ScrollViewer](scrollviewer.md) is explicit in your XAML, as is shown in the example code in the Examples section, you don't need to use attached property syntax. Just use attribute syntax, for example `<ScrollViewer ZoomMode="Enabled" />`.

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetHorizontalScrollMode](scrollviewer_gethorizontalscrollmode.md) and [SetHorizontalScrollMode](scrollviewer_sethorizontalscrollmode.md) methods support and provide the equivalent code-only support for [ScrollViewer.HorizontalScrollMode](scrollviewer_horizontalscrollmode.md). Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [ScrollViewer](scrollviewer.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ScrollViewerScrollBarSeparatorBackground</td><td>Background color of the scrollbar separator</td></tr>
</table>


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 462116-->
### Windows 8 behavior

### Gesture handling by track pad devices
For Windows 8, track pad device gestures that were input-handled by a [ScrollViewer](scrollviewer.md) control part were interpreted as mouse wheel input, and thus would fire a [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event. Starting with Windows 8.1, [ScrollViewer](scrollviewer.md) uses an underlying manipulation logic that interprets track pad gestures as actions that the [ScrollViewer](scrollviewer.md) responds to, and thus the gesture is considered handled by the control and the [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event is not fired anymore.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) being fired in fewer cases. Also, the behavior that's now built-in to [ScrollViewer](scrollviewer.md) may be duplicating what your handler would have done.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 461907-->
### App UI for On-Screen Keyboard

Windows 8 had an internally implemented logic that would associate a [ScrollViewer](scrollviewer.md) with the overall app UI whenever the user invokes the On-Screen Keyboard. This On-Screen Keyboard is a specific accessibility feature that users request through the Ease of Access Center. It's not the same as the soft keyboard that can appear in app UI for text input controls, if the system detects no keyboard device. What the internal [ScrollViewer](scrollviewer.md) does here is to make it possible to scroll the area where the app is, if scrolling it is forced because the keyboard is taking UI space.

Starting with Windows 8.1, the system still has UI/layout behavior when the On-Screen Keyboard appears, but it no longer uses this internally created [ScrollViewer](scrollviewer.md). Instead it uses a dedicated internal control that app code can't change or inspect.

Most aspects of this behavior change don't affect apps at all. However, your app might have anticipated this behavior, by providing an implicit [Style](../windows.ui.xaml/style.md) for [ScrollViewer](scrollviewer.md) that's meant to change the layout, or by walking the tree with [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) to find this internally created [ScrollViewer](scrollviewer.md) and alter it at run-time. For an app that is compiled for Windows 8.1 that code won't be useful.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 461907-->

## -examples
The following XAML creates a large [TextBlock](textblock.md) inside a [ScrollViewer](scrollviewer.md), along with another copy of the [TextBlock](textblock.md) for comparison.



[!code-xml[1](../windows.ui.xaml.data/code/System.Windows.Controls.ScrollViewer/csharp/Page.xaml#Snippet1)]

## -see-also
[ContentControl](contentcontrol.md), [ScrollViewer styles and templates](http://msdn.microsoft.com/library/238f91fc-ed6e-4311-883c-2e2ee0186d0b)
