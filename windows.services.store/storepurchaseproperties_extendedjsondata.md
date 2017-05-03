---
-api-id: P:Windows.Services.Store.StorePurchaseProperties.ExtendedJsonData
-api-type: winrt property
---

<!-- Property syntax
public string ExtendedJsonData { get;  set; }
-->

# Windows.Services.Store.StorePurchaseProperties.ExtendedJsonData

## -description
Gets or sets a JSON-formatted string that contains extended data to pass with the purchase request to the Windows Store.

## -property-value
A JSON-formatted string that contains extended data to pass with the purchase request to the Windows Store.

## -remarks
If you want to associate the purchase request with a custom campaign, you can include a field named ```DevOfferId``` in the JSON string that you assign to this property, and you can then retrieve this value later by using the [DeveloperOfferId](storecollectiondata_developerofferid.md) property of a [StoreCollectionData](storecollectiondata.md) object. Here is an example JSON string that includes a ```DevOfferId``` field: ```"{\"DevOfferId\": \"your campaign ID\" }"```.

## -examples

## -see-also
