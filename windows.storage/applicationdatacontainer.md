---
-api-id: T:Windows.Storage.ApplicationDataContainer
-api-type: winrt class
---

<!-- Class syntax.
public class ApplicationDataContainer : Windows.Storage.IApplicationDataContainer
-->

# Windows.Storage.ApplicationDataContainer

## -description
Represents a container for app settings. The methods and properties of this class support creating, deleting, enumerating, and traversing the container hierarchy.

## -remarks
> [!NOTE]
> There is no settings container for the temporary app data store.

The [Values](applicationdatacontainer_values.md) property gets an [ApplicationDataContainerSettings](applicationdatacontainersettings.md) object that provides access to the settings stored in the container.

## -examples
Call the [ApplicationDataContainer.CreateContainer | createContainer](applicationdatacontainer_createcontainer.md) method to create a settings container,  or to return an existing container. This example creates a settings container named `exampleContainer` and adds a setting named `exampleSetting`. The **Always | always** value from the [ApplicationDataCreateDisposition](applicationdatacreatedisposition.md) enumeration indicates that the container should be created if it does not already exist.

Use the [ApplicationDataContainer.Values | values](applicationdatacontainer_values.md) property to access the `exampleSetting` setting in the `exampleContainer` container.

Call the [ApplicationDataContainer.DeleteContainer | deleteContainer](applicationdatacontainer_deletecontainer.md) method to delete the `exampleContainer` settings container when you have finished with it.

```csharp
Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

// Create a setting in a container

Windows.Storage.ApplicationDataContainer container = 
   localSettings.CreateContainer("exampleContainer", Windows.Storage.ApplicationDataCreateDisposition.Always);

if (localSettings.Containers.ContainsKey("exampleContainer"))
{
   localSettings.Containers["exampleContainer"].Values["exampleSetting"] = "Hello, Windows!";
}

// Read data from a setting in a container

bool hasContainer = localSettings.Containers.ContainsKey("exampleContainer");
bool hasSetting = false;

if (hasContainer)
{
   hasSetting = localSettings.Containers["exampleContainer"].Values.ContainsKey("exampleSetting");
}

// Delete a container

localSettings.DeleteContainer("exampleContainer");
```

```cppwinrt
Windows::Storage::ApplicationDataContainer localSettings{
    Windows::Storage::ApplicationData::Current().LocalSettings() };

// Create a setting in a container.
Windows::Storage::ApplicationDataContainer container{
    localSettings.CreateContainer(L"exampleContainer", Windows::Storage::ApplicationDataCreateDisposition::Always) };

if (localSettings.Containers().HasKey(L"exampleContainer"))
{
    auto values{ localSettings.Containers().Lookup(L"exampleContainer").Values() };
    values.Insert(L"exampleSetting", winrt::box_value(L"Hello, Windows!"));
}

// Read data from a setting in a container.
bool hasContainer{ localSettings.Containers().HasKey(L"exampleContainer") };
bool hasSetting{ false };

if (hasContainer)
{
    auto values{ localSettings.Containers().Lookup(L"exampleContainer").Values() };
    hasSetting = values.HasKey(L"exampleSetting");
}

// Delete a container.
localSettings.DeleteContainer(L"exampleContainer");
```

```cpp
ApplicationDataContainer^ localSettings = ApplicationData::Current->LocalSettings;

// Create a setting in a container

ApplicationDataContainer^ container = 
   localSettings->CreateContainer("exampleContainer", ApplicationDataCreateDisposition::Always);

if (localSettings->Containers->HasKey("exampleContainer"))
{
   auto values = localSettings->Containers->Lookup("exampleContainer")->Values;
   values->Insert("exampleSetting", "Hello, Windows!");
}

// Read data from a setting in a container

bool hasContainer = localSettings->Containers->HasKey("exampleContainer");
bool hasSetting = false;

if (hasContainer)
{
   auto values = localSettings->Containers->Lookup("exampleContainer")->Values;
   hasSetting = values->HasKey("exampleSetting");
}

// Delete a container

localSettings->DeleteContainer("exampleContainer");
```

```javascript
var applicationData = Windows.Storage.ApplicationData.current;

var localSettings = applicationData.localSettings;

// Create a setting in a container

var container = localSettings.createContainer("exampleContainer", 
    Windows.Storage.ApplicationDataCreateDisposition.Always);

if (localSettings.containers.hasKey("exampleContainer"))
{
    localSettings.containers.lookup("exampleContainer").values["exampleSetting"] = "Hello, Windows!";
}

// Read data from a setting in a container

var hasContainer = localSettings.containers.hasKey("exampleContainer");

if (hasContainer)
{
    // Access data in: 
    //   localSettings.containers.lookup("exampleContainer").values.hasKey("exampleSetting");
}

// Delete a container

localSettings.deleteContainer("exampleContainer");
```

```vb
Dim localSettings As Windows.Storage.ApplicationDataContainer = Windows.Storage.ApplicationData.Current.LocalSettings

' Create a setting in a container

Dim container As Windows.Storage.ApplicationDataContainer = 
   localSettings.CreateContainer("exampleContainer", Windows.Storage.ApplicationDataCreateDisposition.Always)

If localSettings.Containers.ContainsKey("exampleContainer") Then
    localSettings.Containers("exampleContainer").Values("exampleSetting") = "Hello, Windows!"
End If

' Read data from a setting in a container

Dim hasContainer As Boolean = localSettings.Containers.ContainsKey("exampleContainer")
Dim hasSetting As Boolean = False

If hasContainer Then
    hasSetting = localSettings.Containers("exampleContainer").Values.ContainsKey("exampleSetting")
End If

' Delete a container

localSettings.DeleteContainer("exampleContainer")
```

## -see-also
[Quickstart: Local application data (JavaScript)](http://msdn.microsoft.com/library/87dfe8e5-2d01-45cf-bcb1-25f54219a439), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Quickstart: Roaming application data (JavaScript)](http://msdn.microsoft.com/library/60f40214-c201-4afe-a2f5-0ef3a7de0076), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [ApplicationData](applicationdata.md), [ApplicationDataCompositeValue](applicationdatacompositevalue.md), [ApplicationDataContainerSettings](applicationdatacontainersettings.md), [Application data sample](http://go.microsoft.com/fwlink/p/?linkid=231478), [Application data sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620486)