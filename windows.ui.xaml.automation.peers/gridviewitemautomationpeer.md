---
-api-id: T:Windows.UI.Xaml.Automation.Peers.GridViewItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class GridViewItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IGridViewItemAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.GridViewItemAutomationPeer

## -description
Exposes a [GridViewItem](../windows.ui.xaml.controls/gridviewitem.md) to Microsoft UI Automation.



## -remarks
The Windows Runtime  [GridViewItem](../windows.ui.xaml.controls/gridviewitem.md) class creates a new GridViewItemAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from GridViewItemAutomationPeer if you are deriving a custom class from [GridViewItem](../windows.ui.xaml.controls/gridviewitem.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **GridViewItemAutomationPeer**

GridViewItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) defers to base peers. [GetPattern](automationpeer_getpattern_2046576749.md) returns a pattern for [IDragProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idragprovider) though an internal base class. The content of the [GridViewItem](../windows.ui.xaml.controls/gridviewitem.md) might also have a specific peer, for example if it is a [TextBox](../windows.ui.xaml.controls/textbox.md). The parent [GridView](../windows.ui.xaml.controls/gridview.md) has the support for any selection-related automation behavior.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "GridViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
<!--Is actually a mystery how, because I don't see this done in the code, but it tests out-->
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [GridView](../windows.ui.xaml.controls/gridview.md), [GridViewItemDataAutomationPeer](gridviewitemdataautomationpeer.md), [GridViewItem](../windows.ui.xaml.controls/gridviewitem.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
