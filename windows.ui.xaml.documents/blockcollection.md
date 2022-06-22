---
-api-id: T:Windows.UI.Xaml.Documents.BlockCollection
-api-type: winrt class
---

<!-- Class syntax.
public class BlockCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Documents.Block>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Documents.Block>
-->

# Windows.UI.Xaml.Documents.BlockCollection

## -description
Represents a collection of [Block](block.md) elements.



## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through a BlockCollection object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable<Block>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast the collection object to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [Block](block.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true), [Block](block.md), [Blocks](../windows.ui.xaml.controls/richtextblock_blocks.md)
