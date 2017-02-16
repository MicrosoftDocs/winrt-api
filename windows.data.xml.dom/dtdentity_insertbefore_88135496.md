---
-api-id: M:Windows.Data.Xml.Dom.DtdEntity.InsertBefore(Windows.Data.Xml.Dom.IXmlNode,Windows.Data.Xml.Dom.IXmlNode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Xml.Dom.IXmlNode InsertBefore(Windows.Data.Xml.Dom.IXmlNode newChild, Windows.Data.Xml.Dom.IXmlNode referenceChild)
-->

# Windows.Data.Xml.Dom.DtdEntity.InsertBefore

## -description
Inserts a child node to the left of the specified node, or at the end of the child node list.

## -parameters
### -param newChild
The address of the new node to be inserted. The node passed here must be a valid child of the current XML DOM document node. For example, if the current node is an attribute, you cannot pass another attribute in the *newChild * parameter, because an attribute cannot have an attribute as a child. If *newChild* is a DOCUMENT_FRAGMENT node type, all its children are inserted in order before *referenceChild*.

If *newChild* is already in the tree, it is first removed before it is reinserted before the *referenceChild* node. Read-only nodes, such as NODE_DOCUMENT_TYPE and NODE_ENTITY nodes, cannot be passed in the *newChild* parameter.

### -param referenceChild
The reference node. The node specified is where the *newChild* node is to be inserted to the left as the preceding sibling in the child list. The node passed here must be a either a child node of the current node or null. If the value is null, the *newChild* node is inserted at the end of the child list. If the *referenceChild* node is not a child of the current node, an error is returned.

## -returns
On success, the child node that was inserted. If null, no object is created.

## -remarks

## -examples

## -see-also
