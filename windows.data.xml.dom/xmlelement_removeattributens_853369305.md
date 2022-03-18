---
-api-id: M:Windows.Data.Xml.Dom.XmlElement.RemoveAttributeNS(System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void RemoveAttributeNS(System.Object namespaceUri, System.String localName)
-->

# Windows.Data.Xml.Dom.XmlElement.RemoveAttributeNS

## -description
Removes the specified attribute from this element in the specified namespace.

## -parameters
### -param namespaceUri
The namespace of attribute to be removed.

### -param localName
The name of the attribute without the namespace prefix.

## -remarks

## -examples

```csharp
element.RemoveAttributeNS("http://www.w3.org/2000/svg", "width");
```

```cppwinrt
element.RemoveAttributeNS(winrt::box_value(L"http://www.w3.org/2000/svg"), L"width");
```

## -see-also
