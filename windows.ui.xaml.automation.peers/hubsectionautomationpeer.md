---
-api-id: T:Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class HubSectionAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IHubSectionAutomationPeer, Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
-->

# Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer

## -description
Exposes [HubSection](../windows.ui.xaml.controls/hubsection.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [HubSection](../windows.ui.xaml.controls/hubsection.md) class creates a new HubSectionAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from HubSectionAutomationPeer if you are deriving a custom class from [HubSection](../windows.ui.xaml.controls/hubsection.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **HubSectionAutomationPeer**

HubSectionAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "HubSection".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
+ [GetName](automationpeer_getname_1386609741.md) attempts to get a string from the owner control's [Header](../windows.ui.xaml.controls/hubsection_header.md) property. Otherwise, the framework peer behavior of using [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) applies.
+ [GetChildren](automationpeer_getchildren_555647254.md) returns a set of peers where the peer for the [Header](../windows.ui.xaml.controls/hubsection_header.md) is first. This is followed by peers for the content in [HeaderTemplate](../windows.ui.xaml.controls/hubsection_headertemplate.md). If [IsHeaderInteractive](../windows.ui.xaml.controls/hubsection_isheaderinteractive.md) is **true** for the section, there's also a peer representing the chevron glyph button that's added by templates. Then peers are included for the content being presented in the section.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

> For Windows Phone 8.x apps, [GetPattern](automationpeer_getpattern_2046576749.md) reports support for the **ScrollItem** pattern, and implements the [ScrollIntoView](hubsectionautomationpeer_scrollintoview_1265805467.md) method for it.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [HubAutomationPeer](hubautomationpeer.md), [Hub](../windows.ui.xaml.controls/hub.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
