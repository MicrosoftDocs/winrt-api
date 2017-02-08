---
-api-id: M:Windows.Data.Xml.Dom.XmlDocument.ImportNode(Windows.Data.Xml.Dom.IXmlNode,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.IXmlNode ImportNode(Windows.Data.Xml.Dom.IXmlNode node, System.Boolean deep)
-->

# Windows.Data.Xml.Dom.XmlDocument.ImportNode

## -description
Imports a node from another document to this document.

## -parameters
### -param node
The object to be cloned.

### -param deep
If true, any children of node will be cloned as well. If false, no children of the node will be cloned.

## -returns
The imported node.

## -remarks
The returned node has no parent (the  is null). The source node is not altered or removed from the original document; this method creates a new copy of the source node.

## -examples

## -see-also
