---
-api-id: T:Windows.UI.Shell.WindowTabCollection
-api-type: winrt class
---

# Windows.UI.Shell.WindowTabCollection

<!--
public sealed class WindowTabCollection : System.Collections.Generic.IEnumerable<Windows.UI.Shell.WindowTab>, System.Collections.Generic.IList<Windows.UI.Shell.WindowTab>
-->

## -description

Represents an ordered collection of [WindowTab](windowtab.md) values.

## -remarks

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A `WindowTabCollection` is enumerable, so you can use language-specific syntax such as `foreach` in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<WindowTab>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [WindowTab](windowtab.md) constraint.
<!--End NET note for IEnumerable support-->

## -see-also

[WindowTabManager.Tabs](windowtabmanager_tabs.md)

## -examples

