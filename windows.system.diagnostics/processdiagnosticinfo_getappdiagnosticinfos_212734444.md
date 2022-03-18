---
-api-id: M:Windows.System.Diagnostics.ProcessDiagnosticInfo.GetAppDiagnosticInfos
-api-type: winrt method
---

<!-- Method syntax.
public IVector<AppDiagnosticInfo> ProcessDiagnosticInfo.GetAppDiagnosticInfos()
-->

# Windows.System.Diagnostics.ProcessDiagnosticInfo.GetAppDiagnosticInfos

## -description
Gets one or more [AppDiagnosticInfo](/uwp/api/windows.system.appdiagnosticinfo) objects if the [IsPackaged](processdiagnosticinfo_ispackaged.md) property is **true**.

## -returns
Returns one or more [AppDiagnosticInfo](/uwp/api/windows.system.appdiagnosticinfo) objects.

## -remarks
Use of this method may require user consent, which defaults to denied. If you do not have consent, the method will return information for only the current app. Users can provide consent in the Settings app. An app can request consent programmatically by calling [AppDiagnosticInfo.RequestAccessAsync](../windows.system/appdiagnosticinfo_requestaccessasync_380675631.md).

## -see-also

## -examples

