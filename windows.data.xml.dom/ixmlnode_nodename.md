---
-api-id: P:Windows.Data.Xml.Dom.IXmlNode.NodeName
-api-type: winrt property
---

<!-- Property syntax
public string NodeName { get; }
-->

# Windows.Data.Xml.Dom.IXmlNode.NodeName

## -description
Returns the qualified name for attribute, document type, element, entity, or notation nodes. Returns a fixed string for all other node types.

## -property-value
The qualified node name, which varies depending on the node type.

## -remarks
This value depends on the [NodeType](ixmlnode_nodetype.md) property. The following table describes this dependency.

<table>
   <tr><th>NodeType</th><th>NodeName</th></tr>
   <tr><td>Element</td><td>tagName</td></tr>
   <tr><td>Attribute</td><td>name of attribute</td></tr>
   <tr><td>Text</td><td>#text</td></tr>
   <tr><td>CDATASection</td><td>#cdata-section</td></tr>
   <tr><td>EntityReference</td><td>name of entity referenced</td></tr>
   <tr><td>Entity</td><td>entity name</td></tr>
   <tr><td>ProcessingInstruction</td><td>target</td></tr>
   <tr><td>Comment</td><td>#comment</td></tr>
   <tr><td>Document</td><td>#document</td></tr>
   <tr><td>DocumentType</td><td>document type name</td></tr>
   <tr><td>DocumentFragment</td><td>#document-fragment</td></tr>
   <tr><td>Notation</td><td>notation name</td></tr>
</table>

## -examples

## -see-also
