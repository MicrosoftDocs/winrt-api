---
-api-id: M:Windows.Data.Xml.Dom.XmlDocument.CreateElementNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlElement CreateElementNS(System.Object namespaceUri, System.String qualifiedName)
-->

# Windows.Data.Xml.Dom.XmlDocument.CreateElementNS

## -description
Creates an element node using the specified namespace and name.

## -parameters
### -param namespaceUri
The name of the desired namespace or a null value if no namespace is desired.

### -param qualifiedName
The name for the new element node. It is case-sensitive. This name is subsequently available as the element node's [NodeName](xmlelement_nodename.md) property.

## -returns
The newly created object.

## -remarks

## -examples

```csharp
var element = document.CreateElementNS("http://www.w3.org/2000/svg", "svg");
```

```cppwinrt
auto element = document.CreateElementNS(winrt::box_value(L"http://www.w3.org/2000/svg"), L"svg");
```

## -see-also
