---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListViewItemAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ListViewItemAutomationPeer

## -description
Exposes a [ListViewItem](../windows.ui.xaml.controls/listviewitem.md) to Microsoft UI Automation.



## -remarks
The Windows Runtime  [ListViewItem](../windows.ui.xaml.controls/listviewitem.md) class creates a new ListViewItemAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ListViewItemAutomationPeer if you are deriving a custom class from [ListViewItem](../windows.ui.xaml.controls/listviewitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ListViewItemAutomationPeer**

ListViewItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) defers to base peers. [GetPattern](automationpeer_getpattern_2046576749.md) returns a pattern for [IDragProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idragprovider) though an internal base class. The content of the [ListViewItem](../windows.ui.xaml.controls/listviewitem.md) might also have a specific peer, for example if it is a [TextBox](../windows.ui.xaml.controls/textbox.md). The parent [ListView](../windows.ui.xaml.controls/listview.md) has the support for any selection-related automation behavior.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ListViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
<!--mysterious do not see the code that does this-->
+ Because a [ListViewItem](../windows.ui.xaml.controls/listviewitem.md) is a [ContentControl](../windows.ui.xaml.controls/contentcontrol.md), [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. This is implemented so that consumers of the control don't always need to provide an [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) value in app code, and can use a generated-from-content value for the automation **Name** directly from the UI definition. For more info on how this works, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ListView](../windows.ui.xaml.controls/listview.md), [ListViewItem](../windows.ui.xaml.controls/listviewitem.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
