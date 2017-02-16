---
-api-id: M:Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingAppManager.RequestSetAsActiveBlockingAppAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestSetAsActiveBlockingAppAsync()
-->

# Windows.ApplicationModel.CommunicationBlocking.CommunicationBlockingAppManager.RequestSetAsActiveBlockingAppAsync

## -description
Calls a dialog to set the current app as the default phone communication blocking application.

## -returns
Indicates whether the app was set as the default phone origin application.

## -remarks
In order to use this API, your application needs to be registered as a communication blocking provider. If the application is not appropriately registered, this API will throw an exception. See [Windows.ApplicationModel.CommunicationBlocking](windows_applicationmodel_communicationblocking.md) for more information about how to register as a phone call origin provider.

## -examples

## -see-also
