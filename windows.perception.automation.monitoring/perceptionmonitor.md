---
-api-id: T:Windows.Perception.Automation.Monitoring.PerceptionMonitor
-api-type: winrt class
---

<!-- Class syntax.
public class PerceptionMonitor : Windows.Perception.Automation.Monitoring.IPerceptionMonitor
-->

# Windows.Perception.Automation.Monitoring.PerceptionMonitor

## -description
Monitors a collection of channels that contain data like [HolographicFrame](../windows.graphics.holographic/holographicframe.md) and [SpatialSurfaceMesh](../windows.perception.spatial.surfaces/spatialsurfacemesh.md) objects.

## -remarks
The monitor provides several independent channels of data which should be parallelized as much as possible, which means that you should use separate sockets or round-robin between the channels, rather than draining one before consuming the next. This helps to ensure that independent streams of data, like spatial input and spatial surfaces, don't interfere with each other.

Each channel may require best-effort delivery, when minimizing latency is more important than avoiding dropped packets, or guaranteed delivery, when packets must be delivered completely and in order, even at the expense of latency.

Some channels of data flow automatically, but others require explicit requests to cause data to flow, like spatial surface and holographic frame predictions.

## -examples

## -see-also
