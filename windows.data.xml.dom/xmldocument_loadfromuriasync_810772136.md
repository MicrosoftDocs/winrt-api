---
-api-id: M:Windows.Data.Xml.Dom.XmlDocument.LoadFromUriAsync(Windows.Foundation.Uri,Windows.Data.Xml.Dom.XmlLoadSettings)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Data.Xml.Dom.XmlDocument> LoadFromUriAsync(Windows.Foundation.Uri uri, Windows.Data.Xml.Dom.XmlLoadSettings loadSettings)
-->

# Windows.Data.Xml.Dom.XmlDocument.LoadFromUriAsync

## -description
Asynchronously loads an XML document from the specified location. The document is parsed using the provided settings.

## -parameters
### -param uri
A URL that specifies the location of the XML file.

### -param loadSettings
Customizes parser behavior.

## -returns
An object that must be used to start the operation.

## -remarks
This operation does not start until a call is made to the IAsyncOperation::StartOperation method.

## -examples

## -see-also
[LoadFromUriAsync(Uri)](xmldocument_loadfromuriasync_878810410.md)