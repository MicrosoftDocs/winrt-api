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
1. Read the [Values](applicationdatacontainer_values.md) property of the data container. This property returns a group of settings of type **IPropertySet**, which can be cast to the ApplicationDataContainerSettings type.


### Collection member lists

Note that for JavaScript, ApplicationDataContainerSettings supports using an index to access items.

## -examples

## -see-also

[Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data), [ApplicationData](applicationdata.md), [ApplicationDataCompositeValue](applicationdatacompositevalue.md), [ApplicationDataContainer](applicationdatacontainer.md), [Application data sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationData)
