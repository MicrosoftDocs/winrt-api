---
-api-id: M:Windows.System.Diagnostics.ProcessDiagnosticInfo.TryGetForProcessId(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax.
public ProcessDiagnosticInfo ProcessDiagnosticInfo.TryGetForProcessId(UInt32 processId)
-->

# Windows.System.Diagnostics.ProcessDiagnosticInfo.TryGetForProcessId

## -description
Gets a [ProcessDiagnosticInfo](processdiagnosticinfo.md) object for the specified process.

## -parameters
### -param processId
The identifier of the process for which to retrieve a [ProcessDiagnosticInfo](processdiagnosticinfo.md) object.

## -returns

## -remarks
If you call this method for the current app process ID, there is no capability check. Calling the method for any other process requires user consent, which defaults to denied. Users can provide consent in the Settings app. An app can request consent programmatically by calling [AppDiagnosticInfo.RequestAccessAsync](../windows.system/appdiagnosticinfo_requestaccessasync_380675631.md).

## -see-also

## -examples

