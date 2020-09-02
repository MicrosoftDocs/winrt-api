---
-api-id: P:Windows.Services.Store.StorePurchaseProperties.ExtendedJsonData
-api-type: winrt property
---

<!-- Property syntax
public string ExtendedJsonData { get;  set; }
-->

# Windows.Services.Store.StorePurchaseProperties.ExtendedJsonData

## -description
Gets or sets a JSON-formatted string that contains extended data to pass with the purchase request to the Microsoft Store.

## -property-value
A JSON-formatted string that contains extended data to pass with the purchase request to the Microsoft Store.

## -remarks
Use the **ExtendedJsonData** property to access the complete data for the [StorePurchaseProperties](storepurchaseproperties.md) object as a JSON-formatted string in your code. For more information about the structure of the data, see [Data schemas for Store products](/windows/uwp/monetize/data-schemas-for-store-products).

If you want to associate the purchase request with a custom campaign, you can add a field named ```DevOfferId``` to the JSON string that is returned by this property and then assign the updated string to this property. You can then retrieve this value later by accessing the [DeveloperOfferId](storecollectiondata_developerofferid.md) property of a [StoreCollectionData](storecollectiondata.md) object. Here is an example JSON string that includes a ```DevOfferId``` field: ```"{\"DevOfferId\": \"your campaign ID\" }"```.

## -examples

## -see-also
[Data schemas for Store products](/windows/uwp/monetize/data-schemas-for-store-products)
