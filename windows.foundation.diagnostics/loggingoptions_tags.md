---
-api-id: P:Windows.Foundation.Diagnostics.LoggingOptions.Tags
-api-type: winrt property
---

<!-- Property syntax
public int Tags { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingOptions.Tags

## -description
Gets or sets the user-defined metadata value attached to an event.

## -property-value
The tag.

## -remarks
The top four bits are reserved and must be set to zero (0).

Up to twenty-eight bits of user-defined information can be attached to an event as metadata. For example, user-defined metadata could be defined to act as instructions to a custom event processing tool to control event sampling, throttling, and so on.

For efficiency reasons, tags should be used for infrequently-changing metadata and not frequently-changing data.

## -examples

## -see-also
