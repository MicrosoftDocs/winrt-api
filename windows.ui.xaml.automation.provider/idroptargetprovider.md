---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IDropTargetProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDropTargetProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IDropTargetProvider

## -description
Enables a Microsoft UI Automation element to describe itself as an element that can receive a drop of a dragged element as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.DropTarget](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
A drop target reports the action if the user drops the dragged item on the peer's owner as drop target. These action results are called *effects*. The effects are descriptive strings, not visual effects in a UI and design sense. For more info on what this pattern is for, see [DropTarget Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdroptarget).

IDropTargetProvider is implemented by the existing Windows Runtime automation peers for a [ListView](../windows.ui.xaml.controls/listview.md) or [GridView](../windows.ui.xaml.controls/gridview.md) ([ListViewAutomationPeer](../windows.ui.xaml.automation.peers/listviewautomationpeer.md), [GridViewAutomationPeer](../windows.ui.xaml.automation.peers/gridviewautomationpeer.md)). This supports the Windows Runtime scenario of dragging list items so that they can be reordered. There are a limited number of Windows Runtime classes that can be a drag source; these sources support the [IDragProvider](idragprovider.md) pattern for automation purposes.

Use [DropTargetPatternIdentifiers](../windows.ui.xaml.automation/droptargetpatternidentifiers.md) if you want to reference the IDropTargetProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[DropTargetPatternIdentifiers](../windows.ui.xaml.automation/droptargetpatternidentifiers.md), [IDropTargetProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idroptargetprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [DropTarget Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdroptarget)
