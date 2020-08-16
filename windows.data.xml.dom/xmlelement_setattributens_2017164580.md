---
-api-id: M:Windows.Data.Xml.Dom.XmlElement.SetAttributeNS(System.Object,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetAttributeNS(System.Object namespaceUri, System.String qualifiedName, System.String value)
-->

# Windows.Data.Xml.Dom.XmlElement.SetAttributeNS

## -description
Sets the value of the named attribute in the given namespace.

## -parameters
### -param namespaceUri
The namespace of the attribute being set.

### -param qualifiedName
The name of the attribute being set.

### -param value
The new value for the attribute.

## -remarks

## -examples

```csharp
element.SetAttributeNS("http://www.w3.org/2000/svg", "width", "3");
```

```cppwinrt
element.SetAttributeNS(winrt::box_value(L"http://www.w3.org/2000/svg"), L"width", L"3");
```

## -see-also
