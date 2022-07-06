---
-api-id: P:Windows.UI.Xaml.Data.CurrentChangingEventArgs.Cancel
-api-type: winrt property
---

<!-- Property syntax
public bool Cancel { get;  set; }
-->

# Windows.UI.Xaml.Data.CurrentChangingEventArgs.Cancel

## -description
Gets or sets a value that indicates whether the [CurrentItem](icollectionview_currentitem.md) change should be canceled.



## -property-value
**true** if the event should be canceled; otherwise, **false**. The default is **false**.

## -remarks
If the [IsCancelable](currentchangingeventargs_iscancelable.md) property value is **false**, setting the Cancel property to **true** will throw an **InvalidOperationException**.

## -examples

## -see-also
