---
-api-id: P:Windows.Data.Xml.Dom.XmlAttribute.Specified
-api-type: winrt property
---

<!-- Property syntax
public bool Specified { get; }
-->

# Windows.Data.Xml.Dom.XmlAttribute.Specified

## -description
Gets a value that indicates whether the attribute is explicitly specified or derived from a default value in the document type definition (DTD) or schema.

## -property-value
True if the attribute is explicitly specified; false if the attribute is derived from a default value.

## -remarks
If you change the value of the attribute (even if it has the same value as the default value) then this property is automatically set to true. To re-specify the attribute as the default value from the DTD, you must delete the attribute. The implementation will then make a new attribute available with this property set to false and the default value (if one exists).

## -examples

## -see-also
