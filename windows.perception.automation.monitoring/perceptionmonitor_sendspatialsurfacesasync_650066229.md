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
Calling this method raises one or more [DataReceived](perceptionmonitorchannel_datareceived.md) events, followed by the completion of the [IAsyncAction](/windows/desktop/api/windows.foundation/nn-windows-foundation-iasyncaction) that this method returns. You can't call the SendSpatialSurfacesAsync method until the [IAsyncAction](/windows/desktop/api/windows.foundation/nn-windows-foundation-iasyncaction) from the previous call has completed.

## -examples

## -see-also
