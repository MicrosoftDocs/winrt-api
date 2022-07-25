---
-api-id: P:Windows.UI.Xaml.UIElement.IsDoubleTapEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsDoubleTapEnabled { get;  set; }
-->

# Windows.UI.Xaml.UIElement.IsDoubleTapEnabled

## -description
Gets or sets a value that determines whether the [DoubleTapped](uielement_doubletapped.md) event can originate from that element.



## -xaml-syntax
```xaml
<uiElement IsDoubleTapEnabled="bool" />
```


## -property-value
**true** if a [DoubleTapped](uielement_doubletapped.md) event can originate from this element; otherwise, **false**.

## -remarks
The default is **true** (event enabled). If you set to **false**, the [UIElement](uielement.md) will no longer source the [DoubleTapped](uielement_doubletapped.md) event. This might be desirable if a parent element such as a list control should instead process the action as a manipulation, or if you want to specify that only some child items emit a [DoubleTapped](uielement_doubletapped.md) event that a parent handles after bubbling.

Another reason to suppress gesture events is if you are handling pointer-level events and don't want gesture recognition logic to impact how the pointer events are fired. For example, if the gesture recognition engine has to test for [Tapped](uielement_tapped.md), then it must delay firing a [PointerMoved](uielement_pointermoved.md) event for small movements, because the user might lift the touch point soon and the input event would normally be gesture-recognized as a tap.

## -examples

## -see-also
[DoubleTapped](uielement_doubletapped.md), [OnDoubleTapped](../windows.ui.xaml.controls/control_ondoubletapped_1132552853.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input)
