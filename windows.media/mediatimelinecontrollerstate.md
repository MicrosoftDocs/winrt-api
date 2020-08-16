---
-api-id: T:Windows.Media.MediaTimelineControllerState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.MediaTimelineControllerState : int
-->

# MediaTimelineControllerState

## -description
Specifies the state of a [MediaTimelineController](mediatimelinecontroller.md).

## -enum-fields
### -field Paused:0
The **MediaTimelineController** is paused.

### -field Running:1
The **MediaTimelineController** is running.


### -field Error:3
The **MediaTimelineController** has encountered an error.

### -field Stalled:2
The **MediaTimelineController** is stalled due to starvation of streaming data. Apps may choose to show a buffering indicator when the timeline controller is stalled.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Error |
| 1703 | 15063 | Stalled |

## -examples

## -see-also

