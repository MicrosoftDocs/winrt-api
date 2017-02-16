---
-api-id: M:Windows.Web.Http.Headers.HttpRequestHeaderCollection.Lookup(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string Lookup(System.String key)
-->

# Windows.Web.Http.Headers.HttpRequestHeaderCollection.Lookup

## -description
Finds an item in the [HttpRequestHeaderCollection](httprequestheadercollection.md) if it exists.

## -parameters
### -param key
The key of the item to lookup.

## -returns
The value, if an item with the specified key exists. Use the **HasKey** method to determine whether the key exists.

## -remarks
Use the [HasKey](httprequestheadercollection_haskey.md) method to determine whether the key exists in the [HttpRequestHeaderCollection](httprequestheadercollection.md).

When programming with .NET, this method is hidden and developers should use the [Item](httprequestheadercollection_item.md) indexer.

## -examples

## -see-also
