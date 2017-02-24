---
-api-id: M:Windows.ApplicationModel.Background.IBackgroundTaskInstance2.GetThrottleCount(Windows.ApplicationModel.Background.BackgroundTaskThrottleCounter)
-api-type: winrt method
---

<!-- Method syntax
public uint GetThrottleCount(Windows.ApplicationModel.Background.BackgroundTaskThrottleCounter counter)
-->

# Windows.ApplicationModel.Background.IBackgroundTaskInstance2.GetThrottleCount

## -description
Retrieves the number of times the background task has been suspended for using too many resources.

## -parameters
### -param counter
Indicates the type of resource to include in the throttle count: network, CPU, or both.

## -returns
This method returns the number of times the background task has been suspended for exceeding its quota of the indicated resource type.

## -remarks

## -examples

## -see-also
