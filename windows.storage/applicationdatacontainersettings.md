---
-api-id: T:Windows.Storage.ApplicationDataContainerSettings
-api-type: winrt class
---

<!-- Class syntax.
public class ApplicationDataContainerSettings : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMap<System.String, System.Object>, Windows.Foundation.Collections.IObservableMap<System.String, System.Object>, Windows.Foundation.Collections.IPropertySet
-->

# Windows.Storage.ApplicationDataContainerSettings

## -description
Provides access to the settings in a settings container. The [ApplicationDataContainer.Values](applicationdatacontainer_values.md) property returns an object that can be cast to this type.

## -remarks
To get an app's local settings, do the following things. These steps are demonstrated in the [LocalSettings](applicationdata_localsettings.md) example.


1. Get the value of the static [ApplicationData.Current](applicationdata_current.md) property. This property returns a data store of type [ApplicationData](applicationdata.md).
1. Get the value of the data store's [LocalSettings](applicationdata_localsettings.md) property. This property returns a data container of type [ApplicationDataContainer](applicationdatacontainer.md).
1. Read the [Values](applicationdatacontainer_values.md) property of the data container. This property returns a group of settings of type **IPropertySet**, which can be cast to the [ApplicationDataContainerSettings](applicationdatacontainersettings.md) type.


### Collection member lists

Note that for JavaScript, [ApplicationDataContainerSettings](applicationdatacontainersettings.md) supports using an index to access items.

## -examples

## -see-also
[Quickstart: Local application data (JavaScript)](https://msdn.microsoft.com/library/87dfe8e5-2d01-45cf-bcb1-25f54219a439), [Store and retrieve settings and other app data](https://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Quickstart: Roaming application data (JavaScript)](https://msdn.microsoft.com/library/60f40214-c201-4afe-a2f5-0ef3a7de0076), [Store and retrieve settings and other app data](https://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [ApplicationData](applicationdata.md), [ApplicationDataCompositeValue](applicationdatacompositevalue.md), [ApplicationDataContainer](applicationdatacontainer.md), [Application data sample](https://go.microsoft.com/fwlink/p/?linkid=231478), [Application data sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620486)
