---
-api-id: M:Windows.Perception.Automation.Monitoring.PerceptionMonitor.SendSpatialSurfacesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SendSpatialSurfacesAsync()
-->

# Windows.Perception.Automation.Monitoring.PerceptionMonitor.SendSpatialSurfacesAsync

## -description
Send a new spatial surfaces update.

## -returns
The asynchronous action.

## -remarks
Calling this method raises one or more [DataReceived](perceptionmonitorchannel_datareceived.md) events, followed by the completion of the [IAsyncAction](http://msdn.microsoft.com/library/e5d567f6-ffde-4e51-8d52-638d30252549) that this method returns. You can't call the [SendSpatialSurfacesAsync](perceptionmonitor_sendspatialsurfacesasync_650066229.md) method until the [IAsyncAction](http://msdn.microsoft.com/library/e5d567f6-ffde-4e51-8d52-638d30252549) from the previous call has completed.

## -examples

## -see-also
