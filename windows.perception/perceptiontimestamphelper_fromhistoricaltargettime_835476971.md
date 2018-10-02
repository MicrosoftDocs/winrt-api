---
-api-id: M:Windows.Perception.PerceptionTimestampHelper.FromHistoricalTargetTime(Windows.Foundation.DateTime)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Perception.PerceptionTimestamp FromHistoricalTargetTime(Windows.Foundation.DateTime targetTime)
-->

# Windows.Perception.PerceptionTimestampHelper.FromHistoricalTargetTime

## -description
Gets a timestamp that targets the specified time in the past.

## -parameters
### -param targetTime
The moment in the past to target with the timestamp.

## -returns
The timestamp.

## -remarks
If you are creating this timestamp to relate to other high-precision events on the system, you should instead use the [FromSystemRelativeTargetTime](perceptiontimestamphelper_fromsystemrelativetargettime_386334317.md) method, which operates in the QueryPerformanceCounter (QPC) time domain.

## -examples

## -see-also
