---
-api-id: P:Windows.Web.Syndication.SyndicationItem.EditUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri EditUri { get; }
-->

# Windows.Web.Syndication.SyndicationItem.EditUri

## -description
Gets the Uniform Resource Identifier (URI) of an editable resource.

## -property-value
The **atom:link** element with **rel="edit"**.

## -remarks
This property represents the **atom:link** element with the attribute **rel=”edit”**. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null since the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.

## -examples

## -see-also
