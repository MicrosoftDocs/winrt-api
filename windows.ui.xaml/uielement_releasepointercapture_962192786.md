---
-api-id: M:Windows.UI.Xaml.UIElement.ReleasePointerCapture(Windows.UI.Xaml.Input.Pointer)
-api-type: winrt method
---

<!-- Method syntax
public void ReleasePointerCapture(Windows.UI.Xaml.Input.Pointer value)
-->

# Windows.UI.Xaml.UIElement.ReleasePointerCapture

## -description

Releases pointer captures for capture of one specific pointer by this [UIElement](uielement.md).



## -parameters

### -param value

The pointer reference. Use either saved references from previous captures, or pointer event data, to obtain this reference.

## -remarks

Programmatically releasing the pointer capture with ReleasePointerCapture is not the only way that an element might lose pointer capture. For example, user-driven events such as releasing the pointer (touch point up, mouse button released) can cause the pointer capture to be canceled. 
<!--In this case you don't have to include any code in a  <xref targtype="event_winrt" rid="w_ui_xaml.uielement_pointerreleased"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">PointerReleased</xref> handler that explicitly calls <xref targtype="method_winrt" rid="w_ui_xaml.uielement_releasepointercapture">ReleasePointerCapture</xref>. Release of pointer capture will just happen implicitly because the pointer capture was canceled by a user-driven state change from the originating pointer device. -->
You can listen for the [PointerCaptureLost](uielement_pointercapturelost.md)event to determine when this happens.

Another way that pointer capture might be canceled is if a pointer moves out of one app and into another app while the two apps are side-by-side.

You should only call ReleasePointerCapture if your app code has previously called [CapturePointer](uielement_capturepointer_916768934.md), and has a reference to the particular [Pointer](../windows.ui.xaml.input/pointer.md) instance where you want to release the pointer capture. You'd typically get that [Pointer](../windows.ui.xaml.input/pointer.md) reference through an event such as [PointerReleased](uielement_pointerreleased.md) or perhaps [PointerMoved](uielement_pointermoved.md).

Your app code might call [CapturePointer](uielement_capturepointer_916768934.md) from a different [UIElement](uielement.md) than the one that has any current pointer capture. If so, that cancels any pointer capture previously made by other elements. 
<!--Again, you won't have to explicitly call <xref targtype="method_winrt" rid="w_ui_xaml.uielement_releasepointercapture"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">ReleasePointerCapture</xref>, release of pointer capture will just happen implicitly when another <xref targtype="class_winrt" rid="w_ui_xaml.uielement">UIElement</xref> calls <xref targtype="method_winrt" rid="w_ui_xaml.uielement_capturepointer">CapturePointer</xref>.-->
A [UIElement](uielement.md)can capture multiple pointers to handle multiple touch points such as for manipulations, but only one [UIElement](uielement.md)in an app can have any pointer captures at any one time. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

## -examples

This example shows calling ReleasePointerCapture based on handling [PointerReleased](uielement_pointerreleased.md).
<!--You get this for free without a handler AFAIK. The real action of the handler is to clear the text field. Query out on why there's such emphasis on calling ReleasePointerCapture when by the time the pointer's released, the capture has already been canceled.-->
It also shows code for capturing the pointer initially, and a pattern for tracking and counting pointer references.

[!code-csharp[Scenario2Code](../windows.ui.xaml/code/input/csharp/Scenario2.xaml.cs#SnippetScenario2Code)]

[!code-vb[Scenario2Code](../windows.ui.xaml/code/input/vbnet/Scenario2.xaml.vb#SnippetScenario2Code)]

## -see-also

[Windows.UI.Xaml.UIElement.ReleasePointerCaptures](uielement_releasepointercaptures_190109337.md), [CapturePointer](uielement_capturepointer_916768934.md), [PointerReleased](uielement_pointerreleased.md), [PointerCaptureLost](uielement_pointercapturelost.md), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
