---
-api-id: P:Windows.UI.Xaml.UIElement.IsHoldingEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsHoldingEnabled { get;  set; }
-->

# Windows.UI.Xaml.UIElement.IsHoldingEnabled

## -description
Gets or sets a value that determines whether the [Holding](uielement_holding.md) event can originate from that element.



## -xaml-syntax
```xaml
<uiElement IsHoldingEnabled="bool" />
```


## -property-value
**true** if a [Holding](uielement_holding.md) event can originate from this element; otherwise, **false**.

## -remarks
The default is **true** (event enabled). If you set to **false**, the [UIElement](uielement.md) will no longer source the [Holding](uielement_holding.md) event. This might be desirable if a parent element such as a list control should instead process the action as a manipulation, or if you want to specify that only some child items emit a [Holding](uielement_holding.md) event that a parent handles after bubbling.

Another reason to suppress gesture events is if you are handling pointer-level events and don't want gesture recognition logic to impact how the pointer events are fired. For example, if the gesture recognition engine has to test for [Tapped](uielement_tapped.md), then it must delay firing a [PointerMoved](uielement_pointermoved.md) event for small movements, because the user might lift the touch point soon and the input event would normally be gesture-recognized as a tap. Also, [Holding](uielement_holding.md) states might interfere with other pointer events, or generate theme animations, because of the progression through the [Holding](uielement_holding.md) states that must be reported by gesture recognition.



## -examples

## -see-also
[Holding](uielement_holding.md), [OnHolding](../windows.ui.xaml.controls/control_onholding_1052914744.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input)
