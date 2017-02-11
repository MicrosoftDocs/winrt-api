---
-api-id: P:Windows.Web.Syndication.SyndicationFeed.IconUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri IconUri { get;  set; }
-->

# Windows.Web.Syndication.SyndicationFeed.IconUri

## -description
Gets or sets the Uniform Resource Identifier (URI) for the image for the feed. This property represents the **atom:icon** element.

## -property-value
The **atom:icon** element. It is the absolute Uniform Resource Identifier (URI) resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative Uniform Resource Identifier (URI) string and there is no **xml:base** attribute, this property will be null because the relative Uniform Resource Identifier (URI) is not supported by the runtime Uniform Resource Identifier (URI) class.

## -remarks

## -examples

## -see-also
