---
-api-id: T:Windows.UI.Xaml.Automation.Peers.FlyoutPresenterAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class FlyoutPresenterAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IFlyoutPresenterAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.FlyoutPresenterAutomationPeer

## -description
Exposes [FlyoutPresenter](../windows.ui.xaml.controls/flyoutpresenter.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [FlyoutPresenter](../windows.ui.xaml.controls/flyoutpresenter.md) class creates a new [FlyoutPresenterAutomationPeer](flyoutpresenterautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [FlyoutPresenterAutomationPeer](flyoutpresenterautomationpeer.md) if you are deriving a custom class from [FlyoutPresenter](../windows.ui.xaml.controls/flyoutpresenter.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **FlyoutPresenterAutomationPeer**

[FlyoutPresenterAutomationPeer](flyoutpresenterautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname.md) returns "Flyout".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.Pane](automationcontroltype.md).
+ [GetPattern](automationpeer_getpattern.md) reports that the peer provides pattern support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](http://msdn.microsoft.com/library/e522b8d5-c6f6-4f71-a8c8-4332f2824f72)).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [FlyoutPresenter](../windows.ui.xaml.controls/flyoutpresenter.md)