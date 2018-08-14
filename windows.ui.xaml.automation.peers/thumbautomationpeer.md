---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ThumbAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ThumbAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IThumbAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ThumbAutomationPeer

## -description
Exposes [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) class creates a new [ThumbAutomationPeer](thumbautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) is sealed, so the normal scenario of deriving from the [Thumb](../windows.ui.xaml.controls.primitives/thumb.md) class and its existing peer isn't applicable to [ThumbAutomationPeer](thumbautomationpeer.md).

### Default peer implementation and overrides in **ThumbAutomationPeer**

[ThumbAutomationPeer](thumbautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Thumb".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Thumb](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns a value based on the template parent. If there is a template parent then it returns **true**, otherwise the value is **false**.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[Thumb](../windows.ui.xaml.controls.primitives/thumb.md), [Slider](../windows.ui.xaml.controls/slider.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)