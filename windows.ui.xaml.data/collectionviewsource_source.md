---
-api-id: P:Windows.UI.Xaml.Data.CollectionViewSource.Source
-api-type: winrt property
---

<!-- Property syntax
public object Source { get;  set; }
-->

# Windows.UI.Xaml.Data.CollectionViewSource.Source

## -description
Gets or sets the collection object from which to create this view.

## -xaml-syntax
```xaml
<CollectionViewSource Source="bindingReference" .../>
```


## -xaml-values
<dl><dt>bindingReference</dt><dd>bindingReferenceA {Binding} markup extension usage that points to the data source being proxied.</dd>
</dl>
## -property-value
The collection to create the view from.

## -remarks
When you set this property, a view is generated automatically unless the source collection implements [ICollectionViewFactory](icollectionviewfactory.md). Otherwise, the view is retrieved through the [CreateView](icollectionviewfactory_createview_164792513.md) method. You can retrieve the view through the [View](collectionviewsource_view.md) property.

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](https://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)
