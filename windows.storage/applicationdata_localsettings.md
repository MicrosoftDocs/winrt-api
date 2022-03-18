---
-api-id: P:Windows.Storage.ApplicationData.LocalSettings
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.ApplicationDataContainer LocalSettings { get; }
-->

# Windows.Storage.ApplicationData.LocalSettings

## -description
Gets the application settings container in the local app data store.

## -property-value
The application settings container.

## -remarks
For both LocalSettings and [RoamingSettings](applicationdata_roamingsettings.md), the name of each setting can be 255 characters in length at most. Each setting can be up to 8K bytes in size and each composite setting can be up to 64K bytes in size.

The [Windows Runtime data types](/windows/desktop/WinRT/base-data-types) are supported for app settings.

## -examples
Use the LocalSettings property to get the settings in an [ApplicationDataContainer](applicationdatacontainer.md) object. Use the [ApplicationDataContainer.Values](applicationdatacontainer_values.md) property to access the settings in the `localSettings` container. This example creates and reads a setting named `exampleSetting`.

Call the [ApplicationDataContainerSettings.Remove](applicationdatacontainersettings_remove_1498489487.md) method to delete the `exampleSetting` setting when you have finished with it.

Note that to access the [RoamingSettings](applicationdata_roamingsettings.md), use the same process outlined in the example, except change the occurrences of `localSettings` to `roamingSettings`

```csharp
var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

// Create a simple setting.
localSettings.Values["exampleSetting"] = "Hello Windows";

// Read data from a simple setting.
Object value = localSettings.Values["exampleSetting"];

if (value == null)
{
    // No data.
}
else
{
    // Access data in value.
}

// Delete a simple setting.
localSettings.Values.Remove("exampleSetting");
```

```cppwinrt
Windows::Storage::ApplicationDataContainer localSettings{
    Windows::Storage::ApplicationData::Current().LocalSettings() };

// Create a simple setting.
auto values{ localSettings.Values() };
values.Insert(L"exampleSetting", Windows::Foundation::PropertyValue::CreateString(L"Hello Windows"));

// Read data from a simple setting.
winrt::hstring value{ winrt::unbox_value<winrt::hstring>(values.Lookup(L"exampleSetting")) };

// Access data in value.

// Delete a simple setting.
values.Remove(L"exampleSetting");
```

```cppcx
ApplicationDataContainer^ localSettings = ApplicationData::Current->LocalSettings;

// Create a simple setting.
auto values = localSettings->Values;
values->Insert("exampleSetting", dynamic_cast<PropertyValue^>(PropertyValue::CreateString("Hello Windows")));

// Read data from a simple setting.
String^ value = safe_cast<String^>(values->Lookup("exampleSetting"));

if (!value)
{
    // No data.
}
else
{
    // Access data in value.
}

// Delete a simple setting.
values->Remove("exampleSetting");
```

```vb
Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings

' Create a simple setting

localSettings.Values("exampleSetting") = "Hello Windows";

' Read data from a simple setting

Dim value As Object = localSettings.Values("exampleSetting")

If value Is Nothing Then
   ' No data
Else
   ' Access data in value
End If

' Delete a simple setting

localSettings.Values.Remove("exampleSetting")
```

## -see-also
[Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data), [Content indexer sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ContentIndexer)
