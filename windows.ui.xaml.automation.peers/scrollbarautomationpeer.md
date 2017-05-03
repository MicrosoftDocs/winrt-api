---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ScrollBarAutomationPeer : Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IScrollBarAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ScrollBarAutomationPeer

## -description
Exposes [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) class creates a new [ScrollBarAutomationPeer](scrollbarautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) is sealed, so the normal scenario of deriving from the [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) class and its existing peer isn't applicable to [ScrollBarAutomationPeer](scrollbarautomationpeer.md).

### Default peer implementation and overrides in **ScrollBarBarAutomationPeer**

[ScrollBarAutomationPeer](scrollbarautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) defers to base peers. [GetPattern](automationpeer_getpattern.md) returns a pattern for [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md) though the base [RangeBaseAutomationPeer](rangebaseautomationpeer.md).
+ [GetClassName](automationpeer_getclassname.md) returns "ScrollBar".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.ScrollBar](automationcontroltype.md).
+ [GetClickablePoint](automationpeer_getclickablepoint.md) returns a "not a number"[Point](../windows.foundation/point.md) value that indicates that there isn't just one such point; clicking at various points along the range has different results.
+ [GetOrientation](automationpeer_getorientation.md) reports a value that parallels the [Orientation](../windows.ui.xaml.controls.primitives/scrollbar_orientation.md) of the [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) owner.
+ [IsContentElement](automationpeer_iscontentelement.md) returns **false**.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[RangeBaseAutomationPeer](rangebaseautomationpeer.md), [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md), [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)