---
-api-id: P:Windows.UI.Xaml.UIElement.Opacity
-api-type: winrt property
---

<!-- Property syntax
public double Opacity { get;  set; }
-->

# Windows.UI.Xaml.UIElement.Opacity

## -description
Gets or sets the degree of the object's opacity.



## -xaml-syntax
```xaml
<uiElement Opacity="double" .../>
```


## -property-value
A value between 0 and 1.0 that declares the opacity factor, with 1.0 meaning full opacity and 0 meaning transparent. The default value is 1.0.

## -remarks
When Opacity is set on objects that are nested, the effective opacity for rendering is the product of all applicable opacity factors. For example, if an object that has `Opacity=0.5` is contained in a [Canvas](../windows.ui.xaml.controls/canvas.md) that is also `Opacity=0.5`, the effective Opacity value for rendering is `0.25`. Opacity values greater than 1.0 are treated as 1.0 when the value is used, although obtaining the property value will still give you the original greater-than-one value. Opacity values set as less than 0 are treated as 0 when the value is used. In the factoring logic, setting an Opacity to 2 to cancel out the effects of being contained by an object with 0.5 Opacity does not work; the 2 value is treated as 1.0 even before the nested-object factoring is calculated.

Opacity is a property that's sometimes animated in visual state storyboards, with zero duration. For example, the focus rectangle for "FocusStates" visual states is set with `Opacity="0"` in the original control template, because you don't want this rectangle to appear in a default non-focused states. But the visual states define a zero-duration "Focused" state that sets Opacity to 1 when the control using these templates and states has detected that it's keyboard-focused. For more info on this usage of Opacity, see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)).

### Opacity and hit-testing

An Opacity value of 0 does not exclude an object from hit testing. This behavior can be useful for creating imagemap-style overlays that are drawn on top of the rest of the UI. For example, you can use a [Canvas](../windows.ui.xaml.controls/canvas.md) that has two children: a [Rectangle](../windows.ui.xaml.shapes/rectangle.md) that has a [Height](frameworkelement_height.md), a [Width](frameworkelement_width.md) and an Opacity of 0, and the layout root of the rest of the UI that should draw underneath. By default children of a [Canvas](../windows.ui.xaml.controls/canvas.md) draw on top of each other in the same absolute coordinate system. Make sure that the [ZIndex](/uwp/api/windows.ui.xaml.controls.canvas.zindex) value of the [Rectangle](../windows.ui.xaml.shapes/rectangle.md) is higher than the other element's [ZIndex](/uwp/api/windows.ui.xaml.controls.canvas.zindex) (or declare the [Rectangle](../windows.ui.xaml.shapes/rectangle.md) after the other element in XAML element order to get the same result.) Wire your hit-testing logic (combines [PointerRoutedEventArgs.GetCurrentPoint](../windows.ui.input/pointerpoint_getcurrentpoint_131721878.md) and [VisualTreeHelper.FindElementsInHostCoordinates](../windows.ui.xaml.media/visualtreehelper_findelementsinhostcoordinates_1478853318.md)) to the [PointerPressed](uielement_pointerpressed.md) event for the [Rectangle](../windows.ui.xaml.shapes/rectangle.md).

Alternatively, in order to exclude an object from hit testing, you should set [IsHitTestVisible](uielement_ishittestvisible.md) to **false**, rather than using Opacity.

## -examples
This example uses a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) and [DoubleAnimation](../windows.ui.xaml.media.animation/doubleanimation.md) to target Opacity. This animates the Opacity to create an app-specific decorative fade-in animation over a one second duration.



[!code-xaml[Animation_ovw_intro](../windows.ui.xaml/code/animation_ovw_intro/csharp/Page.xaml#SnippetAnimation_ovw_intro)]

[!code-vb[Animation_ovw_intro](../windows.ui.xaml/code/animation_ovw_intro/vbnet/Page.xaml.vb#SnippetAnimation_ovw_intro_code)]

## -see-also
[Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
