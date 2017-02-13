---
-api-id: P:Windows.Data.Xml.Dom.XmlLoadSettings.ProhibitDtd
-api-type: winrt property
---

<!-- Property syntax
public bool ProhibitDtd { get;  set; }
-->

# Windows.Data.Xml.Dom.XmlLoadSettings.ProhibitDtd

## -description
Gets or sets a value that specifies whether to prohibit or allow the inclusion of a DTD in the XML DOM document.

## -property-value
True to prohibit the inclusion of a DTD in the XML DOM document; false to allow the inclusion. The default value is true.

## -remarks
This property allows you to prohibit DTD use and can help prevent a denial of service attack in some situations. For example, an application might become unresponsive if a large number of entity references are included with the DTD and require resolution when the document XML is parsed and loaded.

## -examples

## -see-also
