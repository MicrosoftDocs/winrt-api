---
-api-id: M:Windows.System.AppDiagnosticInfo.RequestInfoForPackageAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppDiagnosticInfo>> AppDiagnosticInfo.RequestInfoForPackageAsync(String packageFamilyName)
-->

# Windows.System.AppDiagnosticInfo.RequestInfoForPackageAsync

## -description
Gets a collection of [AppDiagnosticInfo](appdiagnosticinfo.md) objects for all instances of the specified app package. 

## -parameters
### -param packageFamilyName
The identifier of the app package for which to get the [AppDiagnosticInfo](appdiagnosticinfo.md).

## -returns
A collection of [AppDiagnosticInfo](appdiagnosticinfo.md) objects for all instances of the app package specified by *packageFamilyName*. 

## -remarks
If you call this method for the current app package, there is no capability check. Calling the method for any other package requires user consent, which defaults to denied. Users can provide consent in the Settings app. An app can request consent programmatically by calling [AppDiagnosticInfo.RequestAccessAsync](appdiagnosticinfo_requestaccessasync_380675631.md). 

## -see-also

## -examples

## -capabilities
appDiagnostics
