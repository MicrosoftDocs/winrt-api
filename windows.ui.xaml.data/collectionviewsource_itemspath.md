---
-api-id: P:Windows.UI.Xaml.Data.CollectionViewSource.ItemsPath
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.PropertyPath ItemsPath { get;  set; }
-->

# Windows.UI.Xaml.Data.CollectionViewSource.ItemsPath

## -description
Gets or sets the property path to follow from the top level item to find groups within the [CollectionViewSource](collectionviewsource.md).



## -xaml-syntax
```xaml
<CollectionViewSource ItemsPath="propertyPathString" .../>
```


## -xaml-values
<dl><dt>propertyPathString</dt><dd>propertyPathStringA property path that references a property in an object-property relationship, through "dot-down" syntax.</dd>
</dl>
## -property-value
The property path to follow from the top level item to find groups. The default is a [PropertyPath](../windows.ui.xaml/propertypath.md) created from an empty string. This path implies that the object itself is the collection.

## -remarks

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
