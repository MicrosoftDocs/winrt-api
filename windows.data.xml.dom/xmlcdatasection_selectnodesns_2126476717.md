---
-api-id: M:Windows.Data.Xml.Dom.XmlCDataSection.SelectNodesNS(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlNodeList SelectNodesNS(System.String xpath, System.Object namespaces)
-->

# Windows.Data.Xml.Dom.XmlCDataSection.SelectNodesNS

## -description
Applies the specified pattern-matching operation to this node's context and returns the list of matching nodes as an [XmlNodeList](xmlnodelist.md). This method is not applicable to this class and will throw an exception.

## -parameters
### -param xpath
Specifies an XPath expresssion.

### -param namespaces
Contains a string that specifies namespaces for use in XPath expressions when it is necessary to define new namespaces externally. Namespaces are defined in the XML style, as a space-separated list of namespace declaration attributes. You can use this property to set the default namespace as well.

## -returns
The collection of nodes selected by applying the given pattern-matching operation. If no nodes are selected, returns an empty collection.

## -remarks
Prefixes in the query are resolved using the specified namespace declarations.

## -examples

```csharp
var nodes = node.SelectNodesNS("//mux:TreeView", "xmlns:mux='using:Microsoft.UI.Xaml.Controls'");
```

```cppwinrt
auto nodes = node.SelectNodesNS(L"//mux:TreeView", winrt::box_value(L"xmlns:mux='using:Microsoft.UI.Xaml.Controls'"));
```

## -see-also
