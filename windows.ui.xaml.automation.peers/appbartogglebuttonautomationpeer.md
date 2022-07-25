---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AppBarToggleButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarToggleButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer, Windows.UI.Xaml.Automation.Peers.IAppBarToggleButtonAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.AppBarToggleButtonAutomationPeer

## -description
Exposes [AppBarToggleButton](../windows.ui.xaml.controls/appbartogglebutton.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [AppBarToggleButton](../windows.ui.xaml.controls/appbartogglebutton.md) class creates a new AppBarToggleButtonAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from AppBarToggleButtonAutomationPeer if you are deriving a custom class from [AppBarToggleButton](../windows.ui.xaml.controls/appbartogglebutton.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **AppBarToggleButtonAutomationPeer**

AppBarToggleButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "AppBarToggleButton".
+ [GetName](automationpeer_getname_1386609741.md) does not use the [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) behavior that returns a string based on **Content**. Instead, it looks for a label / **LabeledBy** value. Otherwise, values from apps should come from [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) usages in XAML UI definitions, not from values forwarded from the control by the peer.
This peer has the base class [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md) and inherits its behavior other than the overrides indicated above. This includes the pattern support for [IToggleProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itoggleprovider) and the [GetPattern](automationpeer_getpattern_2046576749.md) behavior that returns that pattern when requested, and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md). For more info, see [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ToggleButtonAutomationPeer](togglebuttonautomationpeer.md), [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md), [AppBarToggleButton](../windows.ui.xaml.controls/appbartogglebutton.md)
