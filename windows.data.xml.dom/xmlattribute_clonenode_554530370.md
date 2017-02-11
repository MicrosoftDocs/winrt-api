---
-api-id: M:Windows.Data.Xml.Dom.XmlAttribute.CloneNode(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.IXmlNode CloneNode(System.Boolean deep)
-->

# Windows.Data.Xml.Dom.XmlAttribute.CloneNode

## -description
Clones a new node.

## -parameters
### -param deep
A flag that indicates whether to recursively clone all nodes that are descendants of this node. If true, this method creates a clone of the complete tree below this node. If false, this method clones this node and its attributes only.

## -returns
The newly created clone node.

## -remarks
If you want the cloned attribute to include the value of the attribute, you must use deep clone; otherwise only the attribute name is cloned.

## -examples

## -see-also
