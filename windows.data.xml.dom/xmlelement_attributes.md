---
-api-id: P:Windows.Data.Xml.Dom.XmlElement.Attributes
-api-type: winrt property
---

<!-- Property syntax
public Windows.Data.Xml.Dom.XmlNamedNodeMap Attributes { get; }
-->

# Windows.Data.Xml.Dom.XmlElement.Attributes

## -description
Gets the list of attributes of this node.

## -property-value
The attributes for this node.

## -remarks
This property returns a [XmlNamedNodeMap](xmlnamednodemap.md) for the nodes that can return attributes. These are the Element, Entity, and Notation nodes. This property is NULL for all other node types. For the valid node types, the [XmlNamedNodeMap](xmlnamednodemap.md) is always returned; when there are no attributes on the element, the list length is set to zero.

The following table describes the attributes for the node types.

<table>
   <tr><th>NodeType</th><th>Attributes</th></tr>
   <tr><td>Element</td><td>IXmlNamedNodeMap</td></tr>
   <tr><td>Attribute</td><td>NULL</td></tr>
   <tr><td>Text</td><td>NULL</td></tr>
   <tr><td>CDATASection</td><td>NULL</td></tr>
   <tr><td>EntityReference</td><td>NULL</td></tr>
   <tr><td>Entity</td><td>NULL</td></tr>
   <tr><td>ProcessingInstruction</td><td>NULL</td></tr>
   <tr><td>Comment</td><td>NULL</td></tr>
   <tr><td>Document</td><td>NULL</td></tr>
   <tr><td>DocumentType</td><td>NULL</td></tr>
   <tr><td>DocumentFragment</td><td>NULL</td></tr>
   <tr><td>Notation</td><td>NULL</td></tr>
</table>

## -examples

## -see-also
