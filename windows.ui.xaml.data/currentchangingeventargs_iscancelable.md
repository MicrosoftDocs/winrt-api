---
-api-id: P:Windows.UI.Xaml.Data.CurrentChangingEventArgs.IsCancelable
-api-type: winrt property
---

<!-- Property syntax
public bool IsCancelable { get; }
-->

# Windows.UI.Xaml.Data.CurrentChangingEventArgs.IsCancelable

## -description
Gets a value that indicates whether the [CurrentItem](icollectionview_currentitem.md) change can be canceled.

Equivalent WinUI property: [Microsoft.UI.Xaml.Data.CurrentChangingEventArgs.IsCancelable](/windows/winui/api/microsoft.ui.xaml.data.currentchangingeventargs.iscancelable).

## -property-value
**true** if the event can be canceled; **false** if the event cannot be canceled.

## -remarks
If the IsCancelable property value is **false**, setting the [Cancel](currentchangingeventargs_cancel.md) property to **true** will throw an InvalidOperationException.

## -examples

## -see-also
