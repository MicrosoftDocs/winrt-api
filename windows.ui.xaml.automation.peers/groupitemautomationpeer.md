---
-api-id: T:Windows.UI.Xaml.Automation.Peers.GroupItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class GroupItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IGroupItemAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.GroupItemAutomationPeer

## -description
Exposes a [GroupItem](../windows.ui.xaml.controls/groupitem.md) to Microsoft UI Automation.


## -remarks
The Windows Runtime  [GroupItem](../windows.ui.xaml.controls/groupitem.md) class creates a new GroupItemAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from GroupItemAutomationPeer if you are deriving a custom class from [GroupItem](../windows.ui.xaml.controls/groupitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **GroupItemAutomationPeer**

GroupItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer doesn't have any control pattern support. Items within the group contents might have their own peers.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "GroupItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Group](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren_555647254.md) has an implementation that walks children in the group and layout container and returns peers for those items.
+ [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. This is implemented so that consumers of the control don't always need to provide an [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) value in app code, and can use a generated-from-content value for the automation **Name** directly from the UI definition. For more info on how this works, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[GroupItem](../windows.ui.xaml.controls/groupitem.md), [GroupStyle](../windows.ui.xaml.controls/groupstyle.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
