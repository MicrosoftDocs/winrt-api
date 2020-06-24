---
-api-id: M:Windows.Data.Xml.Dom.XmlElement.GetAttributeNodeNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlAttribute GetAttributeNodeNS(System.Object namespaceUri, System.String localName)
-->

# Windows.Data.Xml.Dom.XmlElement.GetAttributeNodeNS

## -description
Returns the specified attribute from the specified namespace.

## -parameters
### -param namespaceUri
The namespace of the attribute to get.

### -param localName
The name of the attribute without the namespace prefix.

## -returns
The returned attribute pointer.

## -remarks

## -examples

```csharp
var width = element.GetAttributeNodeNS("http://www.w3.org/2000/svg", "width");
```

```cppwinrt
auto width = element.GetAttributeNodeNS(winrt::box_value(L"http://www.w3.org/2000/svg"), L"width");
```

## -see-also
