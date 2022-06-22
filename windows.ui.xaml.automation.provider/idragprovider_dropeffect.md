---
-api-id: P:Windows.UI.Xaml.Automation.Provider.IDragProvider.DropEffect
-api-type: winrt property
---

<!-- Property syntax
public string DropEffect { get; }
-->

# Windows.UI.Xaml.Automation.Provider.IDragProvider.DropEffect

## -description
Gets a string that indicates what will happen when the item is dropped.



## -property-value
A string that indicates what will happen when the item is dropped.

## -remarks
This property describes the default effect that happens when a grabbed element is dropped on a target, such as moving or copying the element. This property is null if this element doesn't implement the source-only style of drag-and-drop; that is, if the drop target defines its own drop effects. This property can be a short string such as "move", or a longer one such as "insert into Main group". The string is always localized.


<!--I changed the tagging here because strings are normally in literal tags.-->

## -examples

## -see-also
