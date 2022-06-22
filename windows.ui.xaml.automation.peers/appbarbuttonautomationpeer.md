---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer, Windows.UI.Xaml.Automation.Peers.IAppBarButtonAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer

## -description
Exposes [AppBarButton](../windows.ui.xaml.controls/appbarbutton.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [AppBarButton](../windows.ui.xaml.controls/appbarbutton.md) class creates a new AppBarButtonAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from AppBarButtonAutomationPeer if you are deriving a custom class from [AppBarButton](../windows.ui.xaml.controls/appbarbutton.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **AppBarButtonAutomationPeer**

AppBarButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "AppBarButton".
+ [GetName](automationpeer_getname_1386609741.md) does not use the [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) behavior that returns a string based on **Content**. Instead, it looks for a label / **LabeledBy** value. Otherwise, values from apps should come from [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) usages in XAML UI definitions, not from values forwarded from the control by the peer.
This peer has the base class [ButtonAutomationPeer](buttonautomationpeer.md) and inherits its behavior other than the overrides indicated above. This includes the pattern support for [IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md) and the [GetPattern](automationpeer_getpattern_2046576749.md) behavior that returns that pattern when requested, and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ButtonAutomationPeer](buttonautomationpeer.md), [IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md), [AppBarButton](../windows.ui.xaml.controls/appbarbutton.md)
