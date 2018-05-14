---
-api-id: M:Windows.System.Diagnostics.ProcessDiagnosticInfo.GetAppDiagnosticInfos
-api-type: winrt method
---

<!-- Method syntax.
public IVector<AppDiagnosticInfo> ProcessDiagnosticInfo.GetAppDiagnosticInfos()
-->

# Windows.System.Diagnostics.ProcessDiagnosticInfo.GetAppDiagnosticInfos

## -description
Gets one or more [AppDiagnosticInfo](https://docs.microsoft.com/uwp/api/windows.system.appdiagnosticinfo) objects if the [IsPackaged](processdiagnosticinfo_ispackaged.md) property is **true**.

## -returns
Returns one or more [AppDiagnosticInfo](https://docs.microsoft.com/uwp/api/windows.system.appdiagnosticinfo) objects.

## -remarks
On first use within an app, this API will indirectly trigger a user consent prompt. If UI is not supported, consent defaults to denied, and the API fails. 

## -see-also

## -examples

