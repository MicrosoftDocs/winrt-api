---
-api-id: P:Windows.Foundation.Diagnostics.LoggingOptions.RelatedActivityId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid RelatedActivityId { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingOptions.RelatedActivityId

## -description
Gets or sets a value that uniquely identifies the parent activity to which this activity is related.

## -property-value
A value that uniquely identifies the parent activity to which this activity is related.

## -remarks
This value corresponds to the Event Tracing for Windows (ETW) definition of a related activity id. You will normally use the [LoggingActivity](loggingactivity.md) class to automatically manage this value instead of setting it manually.

## -examples

## -see-also
[EVENT_EXTENDED_ITEM_RELATED_ACTIVITYID](/windows/win32/api/evntcons/ns-evntcons-event_extended_item_related_activityid)
