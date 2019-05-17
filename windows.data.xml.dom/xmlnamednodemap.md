---
-api-id: T:Windows.Data.Xml.Dom.XmlNamedNodeMap
-api-type: winrt class
---

<!-- Class syntax.
public class XmlNamedNodeMap : Windows.Data.Xml.Dom.IXmlNamedNodeMap, Windows.Foundation.Collections.IIterable<Windows.Data.Xml.Dom.IXmlNode>, Windows.Foundation.Collections.IVectorView<Windows.Data.Xml.Dom.IXmlNode>
-->

# Windows.Data.Xml.Dom.XmlNamedNodeMap

## -description
Encapsulates iteration through the collection of attribute nodes.

## -remarks
### Collection member lists

For JavaScript, XmlNamedNodeMap has the members shown in the member lists. In addition, XmlNamedNodeMap supports members of **Array.prototype** and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

XmlNamedNodeMap is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<IXmlNode>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with an [IXmlNode](ixmlnode.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
