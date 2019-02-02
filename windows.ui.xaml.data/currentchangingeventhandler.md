---
-api-id: T:Windows.UI.Xaml.Data.CurrentChangingEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void CurrentChangingEventHandler(System.Object sender, Windows.UI.Xaml.Data.CurrentChangingEventArgs e)
-->
# Windows.UI.Xaml.Data.CurrentChangingEventHandler

## -description
Represents a method that can handle the [CurrentChanging](icollectionview_currentchanging.md) event of an [ICollectionView](icollectionview.md) implementation.

## -parameters
### -param sender
The source of the event.

### -param e
The event data.


## -remarks
The [ICollectionView.CurrentChanging](icollectionview_currentchanging.md) event occurs when the [CurrentItem](icollectionview_currentitem.md) property value is changing. The [CurrentChangingEventArgs](currentchangingeventargs.md) parameter passed to the event handler specifies information about the change.

If [IsCancelable](currentchangingeventargs_iscancelable.md) is **true**, the event handler can cancel the change by setting [Cancel](currentchangingeventargs_cancel.md) to **true**. If the change is canceled, [CurrentItem](icollectionview_currentitem.md) is not changed. Setting [Cancel](currentchangingeventargs_cancel.md) to **true** when [IsCancelable](currentchangingeventargs_iscancelable.md) is **false** raises an exception.

## -examples
The following code example demonstrates how to handle the [CurrentChanging](icollectionview_currentchanging.md) event. In this example, the XAML shows the content of a page with a [GridView](../windows.ui.xaml.controls/gridview.md) bound to a [CollectionViewSource](collectionviewsource.md). The code-behind shows the [CollectionViewSource](collectionviewsource.md) initialization, which includes setting its [Source](collectionviewsource_source.md) and retrieving its [View](collectionviewsource_view.md) in order to attach the [CurrentChanging](icollectionview_currentchanging.md) event handler.



[!code-xml[Xaml](../windows.ui.xaml.data/code/CurrentChangingExample/csharp/BlankPage.xaml#SnippetXaml)]

[!code-csharp[Code](../windows.ui.xaml.data/code/CurrentChangingExample/csharp/BlankPage.xaml.cs#SnippetCode)]

## -see-also
[XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)
