---
-api-id: P:Windows.Networking.BackgroundTransfer.ContentPrefetcher.IndirectContentUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri IndirectContentUri { get;  set; }
-->

# Windows.Networking.BackgroundTransfer.ContentPrefetcher.IndirectContentUri

## -description
Specifies the location of a well-formed XML file that contains a list of resources to be prefetched.

## -property-value
A [Uri](../windows.foundation/uri.md) for a web resource.

## -remarks
The specified resource will be downloaded at the beginning of a prefetch task for an app. Fetching this URL must return a well formatted XML list of additional resources to prefetch.



This resource must be of type application/xml and must adhere to the following schema:

```
<?xml version="1.0" encoding="utf-8"?>
<xs:schema attributeFormDefault="unqualified" elementFormDefault="qualified" xmlns:xs="http://www.w3.org/2001/XMLSchema">
  <xs:element name="PrefetchUris">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs="1" name="uri" type="xs:anyURI" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>
```



For example:

```
<?xml version="1.0" encoding="utf-8"?>
<prefetchUris>
	<uri>http://example.com/2013-02-28-headlines.json</uri>
	<uri>http://example.com/2013-02-28-img1295.jpg</uri> 
	<uri>http://example.com/2013-02-28-img1296.jpg</uri>
</prefetchUris>
```

Azure Mobile Services is an option for developers wishing to host a prefetch XML file. To learn more about Azure Mobile Services, see the [Microsoft Azure Mobile Apps site](https://azure.microsoft.com/services/app-service/mobile/).

## -examples

## -see-also
[Uri](../windows.foundation/uri.md)
