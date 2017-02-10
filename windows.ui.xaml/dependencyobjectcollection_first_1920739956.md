---
-api-id: M:Windows.UI.Xaml.DependencyObjectCollection.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.UI.Xaml.DependencyObject> First()
-->

# Windows.UI.Xaml.DependencyObjectCollection.First

## -description
Returns the iterator for iteration over the items in the collection.

## -returns
The iterator object. The iterator's current position is at the 0-index position, or at the collection end if the collection is empty.

## -remarks
<!--Begin NET note for IEnumerable support-->
You can iterate through a [DependencyObjectCollection](dependencyobjectcollection.md) in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<DependencyObject>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [DependencyObject](dependencyobject.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
