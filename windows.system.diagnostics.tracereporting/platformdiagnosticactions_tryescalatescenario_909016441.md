---
-api-id: M:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions.TryEscalateScenario(System.Guid,Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEscalationType,System.String,System.Boolean,System.Boolean,Windows.Foundation.Collections.IMapView{System.String,System.String})
-api-type: winrt method
---

<!-- Method syntax.
public bool PlatformDiagnosticActions.TryEscalateScenario(Guid scenarioId, PlatformDiagnosticEscalationType escalationType, String outputDirectory, Boolean timestampOutputDirectory, Boolean forceEscalationUpload, IMapView<String> triggers)
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions.TryEscalateScenario


## -description

Try to run a scenario on demand.

## -parameters

### -param scenarioId

The scenario identifier.

### -param escalationType

The type of escalation.

### -param outputDirectory

The path to the location where the diagnostic data will be stored.

### -param timestampOutputDirectory

*True* to have the output directory timestamp reflect when the diagnostic data is written to the directory; *false* otherwise.

### -param forceEscalationUpload

If the diagnostic scenario cannot be found on the device, *true* initiates an upload of the escalation scenario.

### -param triggers

A dictionary of trigger and property pairs. The format is "$(T,P)=V where T is the trigger, P is the property, and V is the value. For example, {""$(T1,Filename)=c:\foo.dat"} implies that the Connected User Experience and Telemetry component will substitute c:\foo.dat in any action which specifies $(T1,FileName).

## -returns

*True* indicates the scenario was escalated; *false*, otherwise.

