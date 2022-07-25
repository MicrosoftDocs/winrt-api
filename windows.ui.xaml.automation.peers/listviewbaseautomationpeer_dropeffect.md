---
-api-id: P:Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.DropEffect
-api-type: winrt property
---

<!-- Property syntax
public string DropEffect { get; }
-->

# Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.DropEffect

## -description
Gets a string that indicates what will happen when the item is dropped.



## -property-value
A string that indicates what will happen when the item is dropped.

## -remarks
This property is relevant for draggable items when the drop targets are ambiguous. In this case the [ListViewBase](listviewbaseautomationpeer.md) drag origin suggests an effect of being dropped via this property. The drop target can choose to use the DropEffect value instead of the default drop effect of the target.

## -examples

## -see-also
