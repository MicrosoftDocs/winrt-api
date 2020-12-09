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

The event handler receives an [ApplicationData](applicationdata.md) object that provides access to the changed roaming data containers. For more information, see [Roaming data](/windows/uwp/design/app-settings/store-and-retrieve-app-data#roaming-data).

## -examples

This example registers for the DataChanged event.

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

```cppcx
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

```vb
Private Sub InitHandlers()
    AddHandler Windows.Storage.ApplicationData.Current.DataChanged, AddressOf DataChangeHandler
End Sub

Private Sub DataChangeHandler(ByVal appData As Windows.Storage.ApplicationData, ByVal o As Object)
    ' TODO: Refresh your data
End Sub
```

## -see-also
[Roaming data](/windows/uwp/design/app-settings/store-and-retrieve-app-data#roaming-data)
