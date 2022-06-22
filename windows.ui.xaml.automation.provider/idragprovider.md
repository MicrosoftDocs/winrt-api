---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IDragProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDragProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IDragProvider

## -description
Enables a Microsoft UI Automation element to describe itself as an element that can be dragged as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Drag](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
The **Drag** control pattern is used to support draggable controls, or controls with draggable items. For more info on what this pattern is for, see [Drag Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdrag).

IDragProvider is implemented by the existing Windows Runtime automation peers for a [ListView](../windows.ui.xaml.controls/listview.md) item ([ListViewItemAutomationPeer](../windows.ui.xaml.automation.peers/listviewitemautomationpeer.md)) or [GridView](../windows.ui.xaml.controls/gridview.md) item ([GridViewItemAutomationPeer](../windows.ui.xaml.automation.peers/gridviewitemautomationpeer.md)). This supports the Windows Runtime scenario of dragging list items so that they can be reordered. The peer for the host view of the items ([ListViewAutomationPeer](../windows.ui.xaml.automation.peers/listviewautomationpeer.md) or [GridViewAutomationPeer](../windows.ui.xaml.automation.peers/gridviewautomationpeer.md)) support the [IDropTargetProvider](idroptargetprovider.md) pattern.

Use [DragPatternIdentifiers](../windows.ui.xaml.automation/dragpatternidentifiers.md) if you want to reference the IDragProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[DragPatternIdentifiers](../windows.ui.xaml.automation/dragpatternidentifiers.md), [IDragProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idragprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Drag Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdrag)
