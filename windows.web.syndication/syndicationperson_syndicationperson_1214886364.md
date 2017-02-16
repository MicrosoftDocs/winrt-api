---
-api-id: M:Windows.Web.Syndication.SyndicationPerson.#ctor(System.String,System.String,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public SyndicationPerson(System.String name, System.String email, Windows.Foundation.Uri uri)
-->

# Windows.Web.Syndication.SyndicationPerson.SyndicationPerson

## -description
Creates a [SyndicationPerson](syndicationperson.md) object with the specified **Name**, **Email**, and **Uri** property values.

## -parameters
### -param name
The name of the [SyndicationPerson](syndicationperson.md). This parameter represents the **atom:name** element.

### -param email
Gets or sets the email address of the person. This property represents the **atom:email** element.

### -param uri
Gets or sets the Uniform Resource Identifier (URI) of the person. This property represents the **atom:uri** element. It is the absolute URI resolved against the **xml:base** attribute, if it is present. If the **href** attribute is a relative URI string and there is no **xml:base** attribute, this property is NULL because relative URI is not supported by the runtime URI class.

## -remarks

## -examples

## -see-also
[SyndicationPerson(String)](syndicationperson_syndicationperson_290278668.md)