---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.GetAppPurchaseCampaignIdAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetAppPurchaseCampaignIdAsync()
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.GetAppPurchaseCampaignIdAsync

## -description
Retrieves the promotion campaign ID for the current app.

## -returns
The advertising campaign ID for your app.

## -remarks
Starting in Windows 10, you can seed the installation URL for your app with an ID that represents a custom promotion campaign. This enables you to publicize the installation URL in different locations and use the campaign ID to determine which location the customer clicked on the installation URL. Use the GetAppPurchaseCampaignIdAsync method to retrieve the campaign ID for the current app. For more information about custom app promotion campaigns, see [Create a custom app promotion campaign](/windows/uwp/publish/create-a-custom-app-promotion-campaign).

## -examples

## -see-also
[Create a custom app promotion campaign](/windows/uwp/publish/create-a-custom-app-promotion-campaign)
