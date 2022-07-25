---
-api-id: T:Windows.UI.Xaml.Automation.Peers.FlipViewItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class FlipViewItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IFlipViewItemAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.FlipViewItemAutomationPeer

## -description
Exposes a [FlipViewItem](../windows.ui.xaml.controls/flipviewitem.md) to Microsoft UI Automation.



## -remarks
The Windows Runtime  [FlipViewItem](../windows.ui.xaml.controls/flipviewitem.md) class creates a new FlipViewItemAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from FlipViewItemAutomationPeer if you are deriving a custom class from [FlipViewItem](../windows.ui.xaml.controls/flipviewitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **FlipViewItemAutomationPeer**

FlipViewItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer doesn't have any patterns. However, the content of the [FlipViewItem](../windows.ui.xaml.controls/flipviewitem.md) might have a specific peer, for example if it is a [TextBox](../windows.ui.xaml.controls/textbox.md). The parent [FlipView](../windows.ui.xaml.controls/flipview.md) has the support for any selection-related automation behavior.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "FlipViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [FlipView](../windows.ui.xaml.controls/flipview.md), [FlipViewItem](../windows.ui.xaml.controls/flipviewitem.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
