---
-api-id: M:Windows.Management.Update.WindowsUpdateAdministrator.RequestRestart(Windows.Management.Update.WindowsUpdateRestartRequestOptions)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateAdministrator.RequestRestart(Windows.Management.Update.WindowsUpdateRestartRequestOptions)

<!--
public static string RequestRestart (Windows.Management.Update.WindowsUpdateRestartRequestOptions restartOptions);
-->


## -description

Requests a restart that will allow the device to complete updates at a convenient time.

## -parameters

### -param restartOptions

[WindowsUpdateRestartRequestOptions](./windowsupdaterestartrequestoptions.md) that specify details about the restart request.

## -returns

An identifier associated with the restart request.

## -remarks

This API creates a dummy update that is pending restart, so that it will be treated the same as an actual update that requires a restart.

The identifier returned from this API can be passed to [CancelRestartRequest](./windowsupdateadministrator_cancelrestartrequest_1241125889.md) in order to cancel a previously requested restart.

## -see-also

## -examples
