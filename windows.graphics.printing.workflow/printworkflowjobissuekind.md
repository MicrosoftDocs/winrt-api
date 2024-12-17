---
-api-id: T:Windows.Graphics.Printing.Workflow.PrintWorkflowJobIssueKind
-api-type: winrt enum
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobIssueKind

<!--
public enum PrintWorkflowJobIssueKind
-->


## -description

Specifies the kind of issue that was detected in a printer job operation.

## -enum-fields

### -field Other: 0

Other.

### -field AttentionRequired: 1

Attention required.

### -field DoorOpen: 2

Door open.

### -field MarkerSupplyLow: 3

Marker supply low.

### -field MarkerSupplyEmpty: 4

Marker supply low.

### -field MediaJam: 5

Media jam.

### -field MediaEmpty: 6

Media empty.

### -field MediaLow: 7

Media low.

### -field OutputAreaAlmostFull: 8

Output area almost full.

### -field OutputAreaFull: 9

Output area full.

### -field JobPrintingError: 10

Job printing error.

## -remarks

This enumeration is used by the [JobIssueKind](printworkflowjobissuedetectedeventargs_jobissuekind.md) property of the [PrintWorkflowJobIssueDetectedEventArgs](printworkflowjobissuedetectedeventargs.md) object passed into the handler for the[PrintWorkflowJobBackgroundSession.JobIssueDetected](printworkflowjobbackgroundsession_jobissuedetected.md) event.

## -see-also

## -examples


