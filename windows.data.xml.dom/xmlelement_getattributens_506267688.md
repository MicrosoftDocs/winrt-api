---
-api-id: M:Windows.Data.Xml.Dom.XmlElement.GetAttributeNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetAttributeNS(System.Object namespaceUri, System.String localName)
-->

# Windows.Data.Xml.Dom.XmlElement.GetAttributeNS

## -description
Returns the value of the attribute.

## -parameters
### -param namespaceUri
The namespace of the attribute to get.

### -param localName
The name of the attribute without the namespace prefix.

## -returns
The string value of the attribute.

## -remarks

## -examples

```csharp
var width = element.GetAttributeNS("http://www.w3.org/2000/svg", "width");
```

```cppwinrt
auto width = element.GetAttributeNS(winrt::box_value(L"http://www.w3.org/2000/svg"), L"width");
```

## -see-also
