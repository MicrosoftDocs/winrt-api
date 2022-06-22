---
-api-id: P:Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs.InRecycleQueue
-api-type: winrt property
---

<!-- Property syntax
public bool InRecycleQueue { get; }
-->

# Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs.InRecycleQueue

## -description
Gets a value that indicates whether this container is in the recycle queue of the [ListViewBase](listviewbase.md) and is not being used to visualize a data item.



## -property-value
**true** if the container is in the recycle queue of the [ListViewBase](listviewbase.md); otherwise, **false**.

## -remarks
You can check this property in a [ContainerContentChanging](listviewbase_containercontentchanging.md) event to determine if you should release references to the data item. If this property is **true**, [ItemIndex](containercontentchangingeventargs_itemindex.md) is -1 and [Item](containercontentchangingeventargs_item.md) is **null**.


<!--Needs review for accuracy.-->

## -examples

## -see-also
