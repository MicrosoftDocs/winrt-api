---
-api-id: T:Windows.UI.Xaml.Automation.Peers.SliderAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class SliderAutomationPeer : Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.ISliderAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.SliderAutomationPeer

## -description
Exposes [Slider](../windows.ui.xaml.controls/slider.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [Slider](../windows.ui.xaml.controls/slider.md) class creates a new [SliderAutomationPeer](sliderautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [SliderAutomationPeer](sliderautomationpeer.md) if you are deriving a custom class from [Slider](../windows.ui.xaml.controls/slider.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **SliderAutomationPeer**

[SliderAutomationPeer](sliderautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) defers to base peers. [GetPattern](automationpeer_getpattern.md) returns a pattern for [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md) though the base [RangeBaseAutomationPeer](rangebaseautomationpeer.md).
+ [GetClassName](automationpeer_getclassname.md) returns "Slider".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.Slider](automationcontroltype.md).
+  [GetClickablePoint](automationpeer_getclickablepoint.md) returns a "not a number"  [Point](../windows.foundation/point.md) value that indicates that there isn't just one such point; clicking at various points along the range has different results.
+ [GetOrientation](automationpeer_getorientation.md) reports a value that parallels the [Orientation](../windows.ui.xaml.controls/slider_orientation.md) of the [Slider](../windows.ui.xaml.controls/slider.md) owner.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[Slider](../windows.ui.xaml.controls/slider.md), [RangeBaseAutomationPeer](rangebaseautomationpeer.md), [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)