---
-api-id: M:Windows.System.AppDiagnosticInfo.RequestInfoForAppAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppDiagnosticInfo>> AppDiagnosticInfo.RequestInfoForAppAsync(String aumid)
-->

# Windows.System.AppDiagnosticInfo.RequestInfoForAppAsync

## -description
Gets a collection of [AppDiagnosticInfo](appdiagnosticinfo.md) objects for all instances of the specified app. 

## -parameters
### -param appUserModelId
The identifier of the app for which to get the [AppDiagnosticInfo](appdiagnosticinfo.md).

## -returns
A collection of [AppDiagnosticInfo](appdiagnosticinfo.md) objects for all instances of the app specified by *appUserModelId*. 

## -remarks
Calling this method will result in a capability check and a user prompt to authorize this action.

## -see-also

## -examples

## -capabilities
appDiagnostics
