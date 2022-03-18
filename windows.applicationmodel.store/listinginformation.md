---
-api-id: T:Windows.ApplicationModel.Store.ListingInformation
-api-type: winrt class
---

<!-- Class syntax.
public class ListingInformation : Windows.ApplicationModel.Store.IListingInformation, Windows.ApplicationModel.Store.IListingInformation2
-->

# Windows.ApplicationModel.Store.ListingInformation

## -description
Provides the listing info that describes the app in the Microsoft Store.

## -remarks
The info that this object returns comes from the listing info you enter when you submit the app to the Microsoft Store.

You access this object through the [LoadListingInformationAsync](currentappsimulator_loadlistinginformationasync_1372253086.md) method of the [CurrentAppSimulator](currentappsimulator.md) object during testing, or the [LoadListingInformationAsync](currentapp_loadlistinginformationasync_1372253086.md) method of the [CurrentApp](currentapp.md) object when the app is distributed through the Microsoft Store.

> [!NOTE]
> The [CurrentApp](currentapp.md) object obtains its data from the Microsoft Store, so you must have a Microsoft Store developer account and the app must be published in the Microsoft Store. If you don't have a Microsoft Store developer account, you can test the functions of this class by using the [CurrentAppSimulator](currentappsimulator.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | CurrencyCode |
| 1511 | 10586 | FormattedBasePrice |
| 1511 | 10586 | IsOnSale |
| 1511 | 10586 | SaleEndDate |

## -examples
This code example shows how to get the ListingInformation from simulated app data and then get the [ProductListing](productlisting.md) object for one of the features offered by the app.

```csharp
// get the license info for this app from the simulator
ListingInformation listing = await CurrentAppSimulator.LoadListingInformationAsync();

// get the price of the app from the listing info.
String thisAppsPrice = listing.FormattedPrice;

```

## -see-also
[ProductListing](productlisting.md), [ProductListings](listinginformation_productlistings.md)
