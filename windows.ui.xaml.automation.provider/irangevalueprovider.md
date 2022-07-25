---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IRangeValueProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IRangeValueProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IRangeValueProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that can be set to a value within a range. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.RangeValue](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [RangeValue Control Pattern](/windows/desktop/WinAuto/uiauto-implementingrangevalue).

IRangeValueProvider is implemented by the existing Windows Runtime class [RangeBaseAutomationPeer](../windows.ui.xaml.automation.peers/rangebaseautomationpeer.md). This is the base class for peers for [Slider](../windows.ui.xaml.controls/slider.md), [ScrollBar](../windows.ui.xaml.controls.primitives/scrollbar.md) and [ProgressBar](../windows.ui.xaml.controls/progressbar.md). [ProgressBarAutomationPeer](../windows.ui.xaml.automation.peers/progressbarautomationpeer.md) adds an override such that it won't support the pattern if the value of [IsIndeterminate](../windows.ui.xaml.controls/progressbar_isindeterminate.md) on the owner control is **false**.

Use [RangeValuePatternIdentifiers](../windows.ui.xaml.automation/rangevaluepatternidentifiers.md) if you want to reference the IRangeValueProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[RangeValuePatternIdentifiers](../windows.ui.xaml.automation/rangevaluepatternidentifiers.md), [IRangeValueProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irangevalueprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [RangeValue Control Pattern](/windows/desktop/WinAuto/uiauto-implementingrangevalue)
