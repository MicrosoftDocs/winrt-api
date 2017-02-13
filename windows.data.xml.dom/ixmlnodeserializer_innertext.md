---
-api-id: P:Windows.Data.Xml.Dom.IXmlNodeSerializer.InnerText
-api-type: winrt property
---

<!-- Property syntax
public string InnerText { get;  set; }
-->

# Windows.Data.Xml.Dom.IXmlNodeSerializer.InnerText

## -description
Gets and sets the text from inside the XML.

## -property-value
The text from inside the XML. Returns an empty string if there is no text.

## -remarks

## -examples
```xml
var doc = new Window.Data.Xml.Dom.XmlDocument();
doc.loadXml('<root>\r\n  <foo>hello</foo>\r\n  <bar>world</bar>\r\n  </root>');
var xml = doc.getXml();
var txt = doc.InnerText;

```

The XML in this example is as follows.

```
<root>
  <foo>hello</foo>
  <bar>world</bar>
</root>

```

The *txt* variable receives the following value from the **InnerText** member:

```
hello world
```



## -see-also
