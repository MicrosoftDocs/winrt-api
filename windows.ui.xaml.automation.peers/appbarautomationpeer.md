---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AppBarAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IAppBarAutomationPeer, Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider, Windows.UI.Xaml.Automation.Provider.IToggleProvider, Windows.UI.Xaml.Automation.Provider.IWindowProvider
-->

# Windows.UI.Xaml.Automation.Peers.AppBarAutomationPeer

## -description
Exposes [AppBar](../windows.ui.xaml.controls/appbar.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [AppBar](../windows.ui.xaml.controls/appbar.md) class creates a new AppBarAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from AppBarAutomationPeer if you are deriving a custom class from [AppBar](../windows.ui.xaml.controls/appbar.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **AppBarAutomationPeer**

AppBarAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.Toggle](patterninterface.md) ([IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md)).
+ ****: [GetPattern](automationpeer_getpattern_2046576749.md) also reports pattern support for [PatternInterface.ExpandCollapse](patterninterface.md) ([IExpandCollapseProvider](../windows.ui.xaml.automation.provider/iexpandcollapseprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ApplicationBar".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.AppBar](automationcontroltype.md).

> [!NOTE]
> Windows 8: returns [AutomationControlType.Custom](automationcontroltype.md)
+ The peer can fire the [PropertyChanged](automationevents.md) automation event when [ToggleState](appbarautomationpeer_togglestate.md) of the peer and owner control changes.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [AppBar](../windows.ui.xaml.controls/appbar.md), [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md)
