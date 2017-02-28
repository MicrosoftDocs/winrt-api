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
The Windows Runtime  [GroupItem](../windows.ui.xaml.controls/groupitem.md) class creates a new [GroupItemAutomationPeer](groupitemautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [GroupItemAutomationPeer](groupitemautomationpeer.md) if you are deriving a custom class from [GroupItem](../windows.ui.xaml.controls/groupitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **GroupItemAutomationPeer**

[GroupItemAutomationPeer](groupitemautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) reports that the peer doesn't have any control pattern support. Items within the group contents might have their own peers.
+ [GetClassName](automationpeer_getclassname.md) returns "GroupItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) returns [AutomationControlType.Group](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren.md) has an implementation that walks children in the group and layout container and returns peers for those items.
+ [GetName](automationpeer_getname.md) returns a string value based on examining the current **Content**. This is implemented so that consumers of the control don't always need to provide an [AutomationProperties.Name](../windows.ui.xaml.automation/automationproperties_name.md) value in app code, and can use a generated-from-content value for the automation **Name** directly from the UI definition. For more info on how this works, see [Basic accessibility information](http://msdn.microsoft.com/library/9641c926-68c9-4842-8b55-c38c39a9e5c5).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[GroupItem](../windows.ui.xaml.controls/groupitem.md), [GroupStyle](../windows.ui.xaml.controls/groupstyle.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)