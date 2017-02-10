---
-api-id: P:Windows.Web.Syndication.SyndicationItem.EditMediaUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri EditMediaUri { get; }
-->

# Windows.Web.Syndication.SyndicationItem.EditMediaUri

## -description
Gets the Uniform Resource Identifier (URI) of an editable media resource.

## -property-value
The **atom:link** element with the attribute **rel=”edit-media”**.

## -remarks
This property represents the **atom:link** element with the attribute **rel=”edit-media”**. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null since the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.

## -examples

## -see-also
