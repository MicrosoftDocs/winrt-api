---
-api-id: M:Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager.RequestSetAsActiveCallOriginAppAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestSetAsActiveCallOriginAppAsync()
-->

# Windows.ApplicationModel.Calls.Provider.PhoneCallOriginManager.RequestSetAsActiveCallOriginAppAsync

## -description
Calls a dialog to set the current app as the default phone origin app.

## -returns
Indicates whether the app was set as the default phone origin application.

## -remarks
In order to use this API, your application needs to be registered as a phone call origin provider. If the application is not appropriately registered, this API will throw an exception. See [Windows.ApplicationModel.Calls.Provider](windows_applicationmodel_calls_provider.md) for more information about how to register as a phone call origin provider.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
