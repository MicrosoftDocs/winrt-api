---
-api-id: P:Windows.Data.Xml.Dom.IXmlNode.NodeValue
-api-type: winrt property
---

<!-- Property syntax
public object NodeValue { get;  set; }
-->

# Windows.Data.Xml.Dom.IXmlNode.NodeValue

## -description
Gets or sets the text associated with the node.

## -property-value
The text associated with the node.

## -remarks
This value depends on the [NodeType](ixmlnode_nodetype.md) property. The following table describes this dependency.

<table>
   <tr><th>NodeType</th><th>NodeValue</th></tr>
   <tr><td>Element</td><td>Null</td></tr>
   <tr><td>Attribute</td><td>Value of attribute</td></tr>
   <tr><td>Text</td><td>Content of the text node</td></tr>
   <tr><td>CDATASection</td><td>Content of the CDATA Section</td></tr>
   <tr><td>EntityReference</td><td>NULL</td></tr>
   <tr><td>Entity</td><td>NULL</td></tr>
   <tr><td>ProcessingInstruction</td><td>Entire content excluding the target</td></tr>
   <tr><td>Comment</td><td>Content of the comment</td></tr>
   <tr><td>Document</td><td>NULL</td></tr>
   <tr><td>DocumentType</td><td>NULL</td></tr>
   <tr><td>DocumentFragment</td><td>NULL</td></tr>
   <tr><td>Notation</td><td>NULL</td></tr>
</table>

## -examples

## -see-also
