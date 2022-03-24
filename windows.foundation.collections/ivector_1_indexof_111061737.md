---
-api-id: M:Windows.Foundation.Collections.IVector`1.IndexOf(`0,System.UInt32@)
-api-type: winrt method
---

<!-- Method syntax
public bool IndexOf(T value, System.UInt32 index)
-->

# Windows.Foundation.Collections.IVector<T>.IndexOf

## -description
Retrieves the index of a specified item in the vector.

## -parameters
### -param value
The item to find in the vector.

### -param index
If the item is found, this is the zero-based index of the item; otherwise, this parameter is 0.

## -returns
**true** if the item is found; otherwise, **false**.

## -remarks
When programming with .NET, this interface is hidden, and you should use the [System.Collections.Generic.IList\<T\>](/dotnet/api/system.collections.generic.ilist-1) interface.

If the *index* parameter is 0, it indicates that the item is the first item in the array or that the item was not found. To determine whether the item found is the first item, check the return value of this method before you check the *index* parameter. If the return value is **true** and *index* is 0, then the item is the first item in the array. If the return value is **false**, then the item was not found and *index* is 0.

## -examples

## -see-also
[IVector&lt;T&gt;](ivector_1.md)