---
-api-id: M:Windows.Data.Xml.Dom.XmlText.SelectSingleNodeNS(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.IXmlNode SelectSingleNodeNS(System.String xpath, System.Object namespaces)
-->

# Windows.Data.Xml.Dom.XmlText.SelectSingleNodeNS

## -description
Applies the specified pattern-matching operation to this node's context and returns the first matching node.

## -parameters
### -param xpath
Specifies an XPath expression.

### -param namespaces
Contains a string that specifies the namespaces to use in XPath expressions when it is necessary to define new namespaces externally. Namespaces are defined in the XML style, as a space-separated list of namespace declaration attributes. You can use this property to set the default namespace as well.

## -returns
The first node that matches the given pattern-matching operation. If no nodes match the expression, this method returns a null value.

## -remarks
Prefixes in the query are resolved using the specified namespace declarations.

## -examples

```csharp
var input = node.SelectSingleNodeNS("//*[@x:Name='Input']", "xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'");
```

```cppwinrt
auto input = node.SelectSingleNodeNS(L"//*[@x:Name='Input']", winrt::box_value(L"xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'"));
```

## -see-also
