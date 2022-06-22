---
-api-id: T:Windows.UI.Xaml.Automation.TransformPattern2Identifiers
-api-type: winrt class
---

<!-- Class syntax.
public class TransformPattern2Identifiers : Windows.UI.Xaml.Automation.ITransformPattern2Identifiers
-->

# Windows.UI.Xaml.Automation.TransformPattern2Identifiers

## -description
Contains values used as identifiers by [ITransformProvider2](../windows.ui.xaml.automation.provider/itransformprovider2.md).



## -remarks
[ITransformProvider2](../windows.ui.xaml.automation.provider/itransformprovider2.md) extends the [ITransformProvider](../windows.ui.xaml.automation.provider/itransformprovider.md) interface to enable Microsoft UI Automation providers to expose properties to support the viewport zooming functionality of a control.

Classes such as TransformPattern2Identifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [ITransformProvider2](../windows.ui.xaml.automation.provider/itransformprovider2.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer_finditembyproperty_1997743353.md) in an items container peer. This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [ITransformProvider2](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itransformprovider2) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[ITransformProvider2](../windows.ui.xaml.automation.provider/itransformprovider2.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces)
