---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IDragProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDragProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IDragProvider

## -description
Enables a Microsoft UI Automation element to describe itself as an element that can be dragged as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) call and [PatternInterface.Drag](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
The **Drag** control pattern is used to support draggable controls, or controls with draggable items. For more info on what this pattern is for, see [Drag Control Pattern](http://msdn.microsoft.com/library/9853e9cb-d04b-4f67-8e9e-7f1f99bacea7).

[IDragProvider](idragprovider.md) is implemented by the existing Windows Runtime automation peers for a [ListView](../windows.ui.xaml.controls/listview.md) item ([ListViewItemAutomationPeer](../windows.ui.xaml.automation.peers/listviewitemautomationpeer.md)) or [GridView](../windows.ui.xaml.controls/gridview.md) item ([GridViewItemAutomationPeer](../windows.ui.xaml.automation.peers/gridviewitemautomationpeer.md)). This supports the Windows Runtime scenario of dragging list items so that they can be reordered. The peer for the host view of the items ([ListViewAutomationPeer](../windows.ui.xaml.automation.peers/listviewautomationpeer.md) or [GridViewAutomationPeer](../windows.ui.xaml.automation.peers/gridviewautomationpeer.md)) support the [IDropTargetProvider](idroptargetprovider.md) pattern.

Use [DragPatternIdentifiers](../windows.ui.xaml.automation/dragpatternidentifiers.md) if you want to reference the [IDragProvider](idragprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent.md).

## -examples

## -see-also
[DragPatternIdentifiers](../windows.ui.xaml.automation/dragpatternidentifiers.md), [IDragProvider (COM interface)](http://msdn.microsoft.com/library/fac4a56d-17bc-42e6-a03e-ee45d717de37), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Drag Control Pattern](http://msdn.microsoft.com/library/9853e9cb-d04b-4f67-8e9e-7f1f99bacea7)