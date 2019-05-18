---
-api-id: T:Windows.Perception.PerceptionTimestamp
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PerceptionTimestamp : Windows.Perception.IPerceptionTimestamp
-->

# Windows.Perception.PerceptionTimestamp

## -description
Represents a particular prediction of the future, or a snapshot of the past.

Passing one PerceptionTimestamp instance to multiple API calls ensures that they all return results based on the same set of predicted data, even if Windows has improved predictions available. This ensures that you can correctly correlate the data you get back from these APIs.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | SystemRelativeTargetTime |

## -examples

## -see-also
