---
-api-id: T:Windows.Foundation.Diagnostics.LoggingOpcode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.Diagnostics.LoggingOpcode : int
-->

# LoggingOpcode

## -description
Specifies an event opcode. Opcodes represent an operation within a component of an application and are used to logically group events.

## -enum-fields
### -field Info:0
An informational event.

### -field Start:1
An event that represents the start of an activity.

### -field Stop:2
An event that represents the end of an activity. The event corresponds to the last unpaired **Start** event.

### -field Reply:6
A reply event.

### -field Resume:7
An event that represents an activity resuming after being suspended.

### -field Suspend:8
An event that represents the activity being suspended pending another activity's completion.

### -field Send:9
An event that represents transferring activity to another component.


## -remarks
Providers use tasks and opcodes to logically group events. Grouping events makes it easy to query for only those events that contain specific task and opcode combinations.

## -examples

## -see-also