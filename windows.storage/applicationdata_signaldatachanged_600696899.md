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
You can use the [SignalDataChanged](applicationdata_signaldatachanged_600696899.md) method to fire a [DataChanged](applicationdata_datachanged.md) event that you can use to signal other code in your app to reload the local state.

The system automatically fires the [DataChanged](applicationdata_datachanged.md) event when the roaming state changes. After those changes are roamed to other devices, any instance of your app that is running on those devices will also be able to respond to the [DataChanged](applicationdata_datachanged.md) event by refreshing their roaming state.

## -examples

## -see-also
[Quickstart: Roaming application data (JavaScript)](http://msdn.microsoft.com/library/60f40214-c201-4afe-a2f5-0ef3a7de0076), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe)