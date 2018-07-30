---
-api-id: E:Windows.Storage.ApplicationData.DataChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DataChanged<Windows.Storage.ApplicationData,  object>
-->

# Windows.Storage.ApplicationData.DataChanged

## -description
Occurs when roaming application data is synchronized.

## -remarks

## -examples
This example registers for the [DataChanged | datachanged](applicationdata_datachanged.md) event.

```csharp
void InitHandlers()
{
   Windows.Storage.ApplicationData.Current.DataChanged += 
      new TypedEventHandler<ApplicationData, object>(DataChangeHandler);
}

void DataChangeHandler(Windows.Storage.ApplicationData appData, object o)
{
   // TODO: Refresh your data
}
```

```cppwinrt
void MainPage::InitHandlers()
{
    Windows::Storage::ApplicationData::Current().DataChanged({ this, &MainPage::DataChangeHandler });
}

void MainPage::DataChangeHandler(Windows::Storage::ApplicationData const& /* appData */, Windows::Foundation::IInspectable const& /* object */)
{
    // TODO: Refresh your data.
}
```

```cpp
void MainPage::InitHandlers()
{
   Windows::Storage::ApplicationData::Current->DataChanged += 
      ref new TypedEventHandler<Windows::Storage::ApplicationData^, Object^>
      (this, &MainPage::DataChangeHandler);
}

void MainPage::DataChangeHandler(Windows::Storage::ApplicationData^ appData, Object^)
{
   // TODO: Refresh your data
}
```

```javascript
var applicationData = Windows.Storage.ApplicationData.current;

function initialize() 
{
    applicationData.addEventListener("datachanged", datachangeHandler);
}

function dataChangeHandler(eventArgs)
{
    // TODO: Refresh your data
}
```

```vb
Private Sub InitHandlers()
    AddHandler Windows.Storage.ApplicationData.Current.DataChanged, AddressOf DataChangeHandler
End Sub

Private Sub DataChangeHandler(ByVal appData As Windows.Storage.ApplicationData, ByVal o As Object)
    ' TODO: Refresh your data
End Sub
```

## -see-also
[Quickstart: Roaming application data (JavaScript)](http://msdn.microsoft.com/library/60f40214-c201-4afe-a2f5-0ef3a7de0076), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe)