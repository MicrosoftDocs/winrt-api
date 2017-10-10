---
-api-id: M:Windows.ApplicationModel.Calls.PhoneCallManager.RequestStoreAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Calls.PhoneCallStore> RequestStoreAsync()
-->

# Windows.ApplicationModel.Calls.PhoneCallManager.RequestStoreAsync

## -description
Retrieves a [PhoneCallStore](phonecallstore.md).

## -returns
A [PhoneCallStore](phonecallstore.md) object that contains information about the phone lines available on the device.

## -remarks
In order to use this method, you need to have the **phoneCall** capability in your app manifest file.

```
<uap:Capability Name="phoneCall" />
```



> [!IMPORTANT]
> If your application uses the **phoneCall** capability, you must request a waiver if you want to publish your application in China. Contact your premier support representative if you need the waiver.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
