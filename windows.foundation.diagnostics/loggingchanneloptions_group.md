---
-api-id: P:Windows.Foundation.Diagnostics.LoggingChannelOptions.Group
-api-type: winrt property
---

<!-- Property syntax
public System.Guid Group { get;  set; }
-->

# Windows.Foundation.Diagnostics.LoggingChannelOptions.Group

## -description
Gets or sets the channel group identifier.

## -property-value
The group identifier.

## -remarks
A channel can be a member of one group. Membership in a group indicates that the channel implements a specific set of behaviors. An Event Tracing for Windows (ETW) processing tool that can process groups could locate active channels that belong to a particular group, and could use knowledge of a group’s behaviors to route or manipulate the channel’s events.

## -examples

## -see-also
