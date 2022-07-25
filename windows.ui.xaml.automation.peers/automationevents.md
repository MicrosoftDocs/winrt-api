---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AutomationEvents
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.Peers.AutomationEvents : int
-->

# AutomationEvents

## -description
Specifies the event that is raised by the element through the associated [AutomationPeer](automationpeer.md). Used by [RaiseAutomationEvent](automationpeer_raiseautomationevent_2027563412.md).

## -enum-fields
### -field ToolTipOpened:0
The event that is raised when a tooltip is opened.

### -field ToolTipClosed:1
The event that is raised when a tooltip is closed.

### -field MenuOpened:2
The event that is raised when a menu is opened.

### -field MenuClosed:3
The event that is raised when a menu is closed.

### -field AutomationFocusChanged:4
The event that is raised when the focus has changed. See [SetFocus](automationpeer_setfocus_192955311.md).

### -field InvokePatternOnInvoked:5
The event that is raised when a control is activated. See [Invoke](buttonautomationpeer_invoke_1893356988.md).

### -field SelectionItemPatternOnElementAddedToSelection:6
The event that is raised when an item is added to a collection of selected items. See [AddToSelection](radiobuttonautomationpeer_addtoselection_1271464825.md).

### -field SelectionItemPatternOnElementRemovedFromSelection:7
The event that is raised when an item is removed from a collection of selected items. See [RemoveFromSelection](radiobuttonautomationpeer_removefromselection_1451724986.md).

### -field SelectionItemPatternOnElementSelected:8
The event that is raised when a single item is selected (which clears any previous selection). See [Select](radiobuttonautomationpeer_select_431777312.md).

### -field SelectionPatternOnInvalidated:9
The event that is raised when a selection in a container has changed significantly.

### -field TextPatternOnTextSelectionChanged:10
The event that is raised when the text selection is modified.

### -field TextPatternOnTextChanged:11
The event that is raised when textual content is modified.

### -field AsyncContentLoaded:12
The event that is raised when content is loaded asynchronously.

### -field PropertyChanged:13
The event that is raised when a property has changed.

### -field StructureChanged:14
The event that is raised when the UI Automation tree structure is changed.

### -field DragStart:15
The event that is raised when a drag operation originates from a peer.

### -field DragCancel:16
The event that is raised when a drag operation is canceled from a peer.

### -field DragComplete:17
The event that is raised when a drag operation finishes from a peer.

### -field DragEnter:18
The event that is raised when a drag operation targets a peer.

### -field DragLeave:19
The event that is raised when a drag operation switches targets away from a peer.

### -field Dropped:20
The event that is raised when a drag operation drops on a peer.

### -field LiveRegionChanged:21
The event that is raised as notification when a live region refreshes its content without having focus.

### -field InputReachedTarget:22
The event that is raised when user input has reached its target.

### -field InputReachedOtherElement:23
The event that is raised when user input has reached the other element.

### -field InputDiscarded:24
The event that is raised when user input has been discarded.

### -field WindowClosed:25
The event that is raised when a window is closed.

### -field WindowOpened:26
The event that is raised when a window is opened.

### -field ConversionTargetChanged:27
The event that is raised when the conversion target has changed.

### -field TextEditTextChanged:28
The event that is raised when the text was changed in an edit control.

### -field LayoutInvalidated:29
The event that is raised when the window layout has become invalidated. This event is also used for [Auto-suggest accessibility](/windows/uwp/accessibility/accessible-text-requirements#auto-suggest_accessibility).


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | LayoutInvalidated |

## -examples

## -see-also
[RaiseAutomationEvent](automationpeer_raiseautomationevent_2027563412.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
