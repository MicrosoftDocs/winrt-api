---
-api-id: P:Windows.Data.Xml.Dom.XmlLoadSettings.MaxElementDepth
-api-type: winrt property
---

<!-- Property syntax
public uint MaxElementDepth { get;  set; }
-->

# Windows.Data.Xml.Dom.XmlLoadSettings.MaxElementDepth

## -description
Gets and sets the limits of the element depth of an XML document to be loaded into a DOM object.

## -property-value
The depth value. The default value is 256.

## -remarks
A zero (0) value means no limits on the element depth of an XML document. A non-zero value specifies the maximum depth.

An entity counts as one level of nesting. For example, if you have an entity that references an XML document that includes two nested XML elements, set the value to 3.

When the DOM object is cloned, the value of this property is propagated to the cloned object. When the size of an XML document exceeds the limit set by this property, a load error will result when the document is parsed.

This property helps to avoid denial of service attacks in which a document is submitted that has excessive element depth. Failure to limit the element depth leaves you open to the exploit where a relatively small XML document can cause denial of service. The **MaxElementDepth** property mitigates this threat. If you are concerned about denial of service, you should set this property to a value that allows you to load your documents yet limits depth to a reasonable level.

## -examples

## -see-also
