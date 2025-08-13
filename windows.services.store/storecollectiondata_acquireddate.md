---
-api-id: P:Windows.Services.Store.StoreCollectionData.AcquiredDate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime AcquiredDate { get; }
-->

# Windows.Services.Store.StoreCollectionData.AcquiredDate

## -description
Gets the date on which the product SKU was acquired by the user from the Microsoft Store.

## -property-value
The date on which the product SKU was acquired by the user from the Microsoft Store.

## -remarks
This property represents the date when the user first acquired the product SKU from the Microsoft Store, such as through a purchase, redemption, or free download. This is different from the installation date, which represents when the app package was installed on the device. The acquired date remains the same even if the app is uninstalled and reinstalled, while the installation date would change.

The **AcquiredDate** is only available for products that the user has an entitlement to use. To access this property, you must first retrieve the user's collection of owned products using [StoreContext.GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md) or [StoreContext.GetUserCollectionWithPagingAsync](storecontext_getusercollectionwithpagingasync_1326616908.md).

## -examples
The following example shows how to get the acquired date for products in the user's collection.

```csharp
private async void GetUserCollectionAcquiredDates()
{
    // Get the StoreContext for the current user
    StoreContext storeContext = StoreContext.GetDefault();
    
    // Get the user's collection of owned products
    string[] productKinds = { "Application", "Durable" };
    StoreProductQueryResult queryResult = await storeContext.GetUserCollectionAsync(productKinds);
    
    if (queryResult.ExtendedError == null)
    {
        foreach (StoreProduct product in queryResult.Products)
        {
            // Check each SKU for collection data
            foreach (StoreSku sku in product.Skus)
            {
                if (sku.CollectionData != null)
                {
                    // The user has an entitlement for this SKU
                    DateTime acquiredDate = sku.CollectionData.AcquiredDate;
                    System.Diagnostics.Debug.WriteLine($"Product: {product.Title}");
                    System.Diagnostics.Debug.WriteLine($"SKU: {sku.Title}");
                    System.Diagnostics.Debug.WriteLine($"Acquired on: {acquiredDate}");
                }
            }
        }
    }
    else
    {
        // Handle error
        System.Diagnostics.Debug.WriteLine($"Error getting user collection: {queryResult.ExtendedError}");
    }
}
```

## -see-also
[StoreCollectionData](storecollectiondata.md), [StoreSku.CollectionData](storesku_collectiondata.md), [StoreContext.GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md), [StoreContext.GetUserCollectionWithPagingAsync](storecontext_getusercollectionwithpagingasync_1326616908.md)
