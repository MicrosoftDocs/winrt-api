---
-api-id: M:Windows.Data.Xml.Dom.XmlDocument.CreateAttributeNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlAttribute CreateAttributeNS(System.Object namespaceUri, System.String qualifiedName)
-->

# Windows.Data.Xml.Dom.XmlDocument.CreateAttributeNS

## -description
Creates a new attribute with the specified namespace and name.

## -parameters
### -param namespaceUri
The name of the desired namespace or a null value if no namespace is desired.

### -param qualifiedName
The name of the new attribute object. This name is subsequently available as the new node's [NodeName](xmlattribute_nodename.md) property.

## -returns
The newly created attribute.

## -remarks

## -examples

```csharp
var attribute = document.CreateAttributeNS("http://www.w3.org/2000/svg", "width");
```

```cppwinrt
auto attribute = document.CreateAttributeNS(winrt::box_value(L"http://www.w3.org/2000/svg"), L"width");
```

## -see-also
