---
-api-id: E:Windows.UI.Xaml.Data.ICollectionView.CurrentChanging
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.UI.Xaml.Data.CurrentChangingEventHandler CurrentChanging
-->

# Windows.UI.Xaml.Data.ICollectionView.CurrentChanging

## -description
When implementing this interface, fire this event before changing the current item. The event handler can cancel this event.



## -remarks
The CurrentChanging event occurs when the [CurrentItem](icollectionview_currentitem.md) property value is changing. The [CurrentChangingEventArgs](currentchangingeventargs.md) parameter passed to the event handler specifies information about the change. If [IsCancelable](currentchangingeventargs_iscancelable.md) is **true**, the event handler can cancel the change by setting [Cancel](currentchangingeventargs_cancel.md) to **true**. If the change is canceled, [CurrentItem](icollectionview_currentitem.md) is not changed. Setting [Cancel](currentchangingeventargs_cancel.md) to **true** when [IsCancelable](currentchangingeventargs_iscancelable.md) is **false** throws an exception.

Classes that implement this interface should fire the CurrentChanging event, set [IsCancelable](currentchangingeventargs_iscancelable.md) as appropriate, and then check the [Cancel](currentchangingeventargs_cancel.md) property before changing the [CurrentItem](icollectionview_currentitem.md) and firing the [CurrentChanged](icollectionview_currentchanged.md) event.

## -examples
The following code example demonstrates how to handle the CurrentChanging event. In this example, the XAML shows the content of a page with a [GridView](../windows.ui.xaml.controls/gridview.md) bound to a [CollectionViewSource](collectionviewsource.md). The code-behind shows the [CollectionViewSource](collectionviewsource.md) initialization, which includes setting its [Source](collectionviewsource_source.md) and retrieving its [View](collectionviewsource_view.md) in order to attach the CurrentChanging event handler.



[!code-xaml[Xaml](../windows.ui.xaml.data/code/CurrentChangingExample/csharp/BlankPage.xaml#SnippetXaml)]

[!code-csharp[Code](../windows.ui.xaml.data/code/CurrentChangingExample/csharp/BlankPage.xaml.cs#SnippetCode)]

## -see-also
