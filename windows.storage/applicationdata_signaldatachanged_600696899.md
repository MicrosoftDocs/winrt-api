---
-api-id: M:Windows.Storage.ApplicationData.SignalDataChanged
-api-type: winrt method
---

<!-- Method syntax
public void SignalDataChanged()
-->

# Windows.Storage.ApplicationData.SignalDataChanged

## -description
Sends a [DataChanged](applicationdata_datachanged.md) event to all registered event handlers.

## -remarks
You can use the SignalDataChanged method to fire a [DataChanged](applicationdata_datachanged.md) event that you can use to signal other code in your app to reload the local state.

The system automatically fires the [DataChanged](applicationdata_datachanged.md) event when the roaming state changes. After those changes are roamed to other devices, any instance of your app that is running on those devices will also be able to respond to the [DataChanged](applicationdata_datachanged.md) event by refreshing their roaming state.

## -examples

## -see-also

[Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data)
