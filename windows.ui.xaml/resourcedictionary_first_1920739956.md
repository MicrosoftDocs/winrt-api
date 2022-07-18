---
-api-id: M:Windows.UI.Xaml.ResourceDictionary.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.Foundation.Collections.IKeyValuePair<object, object>> First()
-->

# Windows.UI.Xaml.ResourceDictionary.First

## -description
Returns an iterator for the items in the collection.



## -returns
The iterator. The iterator's current position is at the 0-index position, or at the collection end if the collection is empty.

## -remarks
<!--Begin NET note for IEnumerable support-->
You can iterate through a [ResourceDictionary](resourcedictionary.md) in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<KeyValuePair>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a **KeyValuePair&lt;Object,Object&gt;** constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
