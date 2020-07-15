---
-api-id: M:Windows.Data.Xml.Dom.XmlNamedNodeMap.GetNamedItemNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.IXmlNode GetNamedItemNS(System.Object namespaceUri, System.String name)
-->

# Windows.Data.Xml.Dom.XmlNamedNodeMap.GetNamedItemNS

## -description
Retrieves the attribute with the specified namespace and name.

## -parameters
### -param namespaceUri
The namespace name of the attribute.

### -param name
The name of the attribute.

## -returns
The attribute with the specified namespace and name. This method returns Null if the attribute node is not in this collection.

## -remarks

## -examples

```csharp
var node = attributes.GetNamedItemNS("http://schemas.microsoft.com/winfx/2006/xaml", "Name");
```

```cppwinrt
auto node = attributes.GetNamedItemNS(winrt::box_value(L"http://schemas.microsoft.com/winfx/2006/xaml"), L"Name");
```

## -see-also
