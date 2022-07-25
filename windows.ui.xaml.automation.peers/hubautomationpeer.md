---
-api-id: T:Windows.UI.Xaml.Automation.Peers.HubAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class HubAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IHubAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.HubAutomationPeer

## -description
Exposes [Hub](../windows.ui.xaml.controls/hub.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [Hub](../windows.ui.xaml.controls/hub.md) class creates a new HubAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from HubAutomationPeer if you are deriving a custom class from [Hub](../windows.ui.xaml.controls/hub.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **HubAutomationPeer**

HubAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.Scroll](patterninterface.md) ([IScrollProvider](../windows.ui.xaml.automation.provider/iscrollprovider.md)). This uses peer forwarding to get the peer from the [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) part that exists in the compositing for a [Hub](../windows.ui.xaml.controls/hub.md) control. If the default template isn't being used and there is no [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) part, no pattern can be returned.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Hub".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Group](automationcontroltype.md).
+ [GetName](automationpeer_getname_1386609741.md) attempts to get a string from the owner control's [Header](../windows.ui.xaml.controls/hub_header.md) property. Otherwise, the framework peer behavior of using [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) applies.
+ [GetChildren](automationpeer_getchildren_555647254.md) returns a set of peers where the peer for the [Header](../windows.ui.xaml.controls/hub_header.md) is first, followed by a peer for each [HubSection](../windows.ui.xaml.controls/hubsection.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [HubSectionAutomationPeer](hubsectionautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
