---
-api-id: T:Windows.Graphics.Printing.PrintSupport.WorkflowPrintTicketValidationStatus
-api-type: winrt enum
---

# Windows.Graphics.Printing.PrintSupport.WorkflowPrintTicketValidationStatus

<!--
public enum WorkflowPrintTicketValidationStatus
-->


## -description

Defines values that represent the validation status for a print ticket.

## -enum-fields

### -field Resolved: 0

The print ticket was modified to resolve conflicts.

### -field Conflicting: 1

The print ticket options conflict and could not be resolved.

### -field Invalid: 2

The print ticket has invalid XML or an invalid namespace.

## -remarks

For more information, see [Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide).

## -see-also

[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide),[SetPrintTicketValidationStatus](printsupportprintticketvalidationrequestedeventargs_setprintticketvalidationstatus_920893354.md)

## -examples
