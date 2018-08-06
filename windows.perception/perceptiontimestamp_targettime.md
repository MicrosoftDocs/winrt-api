---
-api-id: P:Windows.Perception.PerceptionTimestamp.TargetTime
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.DateTime TargetTime { get; }
-->

# Windows.Perception.PerceptionTimestamp.TargetTime

## -description
Gets the specific time that is the subject of this timestamp.

## -property-value
The time.

## -remarks
If you will be relating this timestamp to other high-precision events on the system, you should instead use the [SystemRelativeTargetTime](perceptiontimestamp_systemrelativetargettime.md) property, which operates in the QueryPerformanceCounter (QPC) time domain.

## -examples

## -see-also
