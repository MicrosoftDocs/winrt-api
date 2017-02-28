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
The Windows Runtime  [Hub](../windows.ui.xaml.controls/hub.md) class creates a new [HubAutomationPeer](hubautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [HubAutomationPeer](hubautomationpeer.md) if you are deriving a custom class from [Hub](../windows.ui.xaml.controls/hub.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **HubAutomationPeer**

[HubAutomationPeer](hubautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) reports that the peer provides pattern support for [PatternInterface.Scroll](patterninterface.md) ([IScrollProvider](../windows.ui.xaml.automation.provider/iscrollprovider.md)). This uses peer forwarding to get the peer from the [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) part that exists in the compositing for a [Hub](../windows.ui.xaml.controls/hub.md) control. If the default template isn't being used and there is no [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) part, no pattern can be returned.
+ [GetClassName](automationpeer_getclassname.md) returns "Hub".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.Group](automationcontroltype.md).
+ [GetName](automationpeer_getname.md) attempts to get a string from the owner control's [Header](../windows.ui.xaml.controls/hub_header.md) property. Otherwise, the framework peer behavior of using [AutomationProperties.Name](../windows.ui.xaml.automation/automationproperties_name.md) applies.
+ [GetChildren](automationpeer_getchildren.md) returns a set of peers where the peer for the [Header](../windows.ui.xaml.controls/hub_header.md) is first, followed by a peer for each [HubSection](../windows.ui.xaml.controls/hubsection.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [HubSectionAutomationPeer](hubsectionautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)