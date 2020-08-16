---
-api-id: M:Windows.Data.Xml.Dom.XmlNamedNodeMap.RemoveNamedItemNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.IXmlNode RemoveNamedItemNS(System.Object namespaceUri, System.String name)
-->

# Windows.Data.Xml.Dom.XmlNamedNodeMap.RemoveNamedItemNS

## -description
Removes an item that is specified by a namespace and local name.

## -parameters
### -param namespaceUri
The namespace name of the attribute.

### -param name
The name of the attribute.

## -returns
The node removed from the collection. This method returns Null if the named node is not an attribute.

## -remarks

## -examples

```csharp
var removedNode = attributes.RemoveNamedItemNS("http://schemas.microsoft.com/winfx/2006/xaml", "Name");
```

```cppwinrt
auto removedNode = attributes.RemoveNamedItemNS(winrt::box_value(L"http://schemas.microsoft.com/winfx/2006/xaml"), L"Name");
```

## -see-also
