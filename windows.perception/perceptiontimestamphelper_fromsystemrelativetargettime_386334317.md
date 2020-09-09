---
-api-id: M:Windows.Perception.PerceptionTimestampHelper.FromSystemRelativeTargetTime(Windows.Foundation.TimeSpan)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public PerceptionTimestamp PerceptionTimestampHelper.FromSystemRelativeTargetTime(TimeSpan targetTime)
-->

# Windows.Perception.PerceptionTimestampHelper.FromSystemRelativeTargetTime

## -description
Gets a timestamp that targets the specified system-relative time, represented in the system-relative QueryPerformanceCounter (QPC) time domain.

## -parameters
### -param targetTime
The system-relative moment in QPC time to target with the timestamp.

## -returns
The timestamp.

## -remarks
The *targetTime* parameter uses 100ns interval QPC time. For more information on QPC time, see [Acquiring high-resolution time stamps](/windows/desktop/SysInfo/acquiring-high-resolution-time-stamps). 

## -see-also

## -examples

