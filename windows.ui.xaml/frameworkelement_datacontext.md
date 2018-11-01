---
-api-id: P:Windows.UI.Xaml.FrameworkElement.DataContext
-api-type: winrt property
---

<!-- Property syntax
public object DataContext { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.DataContext

## -description
Gets or sets the data context for a [FrameworkElement](frameworkelement.md) when it participates in data binding.

## -xaml-syntax
```xaml
<frameworkElement DataContext="binding"/>
- or -
<frameworkElement DataContext="{StaticResource keyedObject}"/>
 
```


## -xaml-values
<dl><dt>binding</dt><dd>bindingA binding expression that can reference an existing data context, or a property in the data context. See Data binding overview or {Binding} markup extension.</dd>
<dt>keyedObject</dt><dd>keyedObjectThe x:Key attribute value of an object that exists in an in-scope Resources collection. Typically, this is an object element instantiation of a custom type defined elsewhere in your code, and requires a custom XAML namespace mapping in the ResourceDictionary.</dd>
</dl>
## -property-value
The object to use as data context.

## -remarks
*Data context* is a concept where objects can inherit data binding information from successive parent objects in an object relationship hierarchy.

The most important aspect of data context is the data source that is used for data binding. A typical use of [DataContext](frameworkelement_datacontext.md) is to set it directly to a data source object. This data source might be an instance of a class such as a business object. Or you can create a data source as an observable collection, so that the data context enables detecting changes in the backing collection. If the data source is defined by a library that is also included in the project, setting a [DataContext](frameworkelement_datacontext.md) is often combined with instantiating the data source as a keyed resource in a [ResourceDictionary](resourcedictionary.md), and then setting the [DataContext](frameworkelement_datacontext.md) in XAML with a [{StaticResource} markup extension](http://msdn.microsoft.com/library/d50349b5-4588-4ebd-9458-75f629ccc395) reference.

Another technique for setting [DataContext](frameworkelement_datacontext.md) is to add it to the root of the runtime object tree, as part of app initialization logic, just after calling **InitializeComponent**. This technique is shown in [Data binding overview](http://msdn.microsoft.com/library/a9d54dec-cd1b-4043-ade4-32cd4977d1bf).

In addition to specifying the source, a data context can also store additional characteristics of a binding declaration, such as a path into the data source.

Setting a [DataContext](frameworkelement_datacontext.md) is convenient for setting several bindings of different properties on the same object to a shared data context. However, it is valid for a [DataContext](frameworkelement_datacontext.md) to be undefined, and for all the necessary binding qualifications to exist in separate binding statements.

How you implement the object data source varies depending on your requirements and your programming language. For more info, see [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

A common scenario for C# and Microsoft Visual Basic data contexts is to use a CLR-defined business object that supports change notification. For a business object, the custom class used as data context typically implements [INotifyPropertyChanged](../windows.ui.xaml.data/inotifypropertychanged.md), so that updates to the data can update a one-way or two-way binding. If the data source is a collection of business objects, it can implement [INotifyCollectionChanged](../windows.ui.xaml.interop/inotifycollectionchanged.md) plus list support ([IList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1) or [List<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1)), or derive from [ObservableCollection<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1).

## -examples
This example sets the [DataContext](frameworkelement_datacontext.md) directly to an instance of a custom class.



[!code-csharp[DataContext](../windows.ui.xaml.controls.primitives/code/Binding_Simple/csharp/Page.xaml.cs#SnippetDataContext)]

[!code-vb[DataContext](../windows.ui.xaml.controls.primitives/code/Binding_Simple/vbnet/BlankPage.xaml.vb#SnippetDataContext)]

## -see-also
[Binding](../windows.ui.xaml.data/binding.md), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011), [ObservableCollection<T>](https://docs.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1)
jectModel.ObservableCollection`1)
