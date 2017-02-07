---
-api-id: P:Windows.Foundation.Diagnostics.LoggingOptions.ActivityId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid ActivityId { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingOptions.ActivityId

## -description
Gets or sets the unique identifier associated with an activity.

## -property-value
The activity unique identifier.

## -remarks
This value corresponds to the Event Tracing for Windows (ETW) definition of an activity id. You will normally use the [LoggingActivity](loggingactivity.md) class to automatically manage this value instead of setting it manually.

## -examples

## -see-also