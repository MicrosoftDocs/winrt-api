---
-api-id: T:Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class FlipViewItemDataAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer, Windows.UI.Xaml.Automation.Peers.IFlipViewItemDataAutomationPeer, Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
-->

# Windows.UI.Xaml.Automation.Peers.FlipViewItemDataAutomationPeer

## -description
Exposes the data content of a [FlipViewItem](../windows.ui.xaml.controls/flipviewitem.md) to Microsoft UI Automation.



## -remarks
 FlipViewItemDataAutomationPeer is generated from [FlipViewAutomationPeer](flipviewautomationpeer.md) logic, not an associated control class.

### Default peer implementation and overrides in **FlipViewItemDataAutomationPeer**

FlipViewItemDataAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer supports [PatternInterface.ScrollItem](patterninterface.md) ([IScrollItemProvider](../windows.ui.xaml.automation.provider/iscrollitemprovider.md)). The base [SelectorItemAutomationPeer](selectoritemautomationpeer.md) supports [PatternInterface.SelectionItem](patterninterface.md) ([ISelectionItemProvider](../windows.ui.xaml.automation.provider/iselectionitemprovider.md)) and the base [ItemAutomationPeer](itemautomationpeer.md) supports [PatternInterface.VirtualizedItem](patterninterface.md) ([IVirtualizedItemProvider](../windows.ui.xaml.automation.provider/ivirtualizeditemprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "FlipViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
+ Although [ItemAutomationPeer](itemautomationpeer.md) reported [IVirtualizedItemProvider](../windows.ui.xaml.automation.provider/ivirtualizeditemprovider.md) support, the base didn't have a working [Realize](itemautomationpeer_realize_1392015295.md) implementation. [ComboBoxItemDataAutomationPeer](comboboxitemdataautomationpeer.md) implements this to call [ScrollIntoView](flipviewitemdataautomationpeer_scrollintoview_1265805467.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FlipViewAutomationPeer](flipviewautomationpeer.md), [FlipView](../windows.ui.xaml.controls/flipview.md), [SelectorItemAutomationPeer](selectoritemautomationpeer.md), [IVirtualizedItemProvider](../windows.ui.xaml.automation.provider/ivirtualizeditemprovider.md), [ISelectionItemProvider](../windows.ui.xaml.automation.provider/iselectionitemprovider.md), [IScrollItemProvider](../windows.ui.xaml.automation.provider/iscrollitemprovider.md)
