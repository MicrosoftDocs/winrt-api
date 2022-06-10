---
-api-id: T:Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy
-api-type: winrt enum
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowAttributesMergePolicy

<!--
public enum PrintWorkflowAttributesMergePolicy
-->


## -description

Specifies how attributes supplied by the Printer Support App should be merged with PrintTicket attributes.

## -enum-fields

### -field MergePreferPrintTicketOnConflict: 0

PSA attributes are merged with the attributes derived from PrintTicket, preferring the Print Ticket over PSA for the attributes with the same name.

### -field MergePreferPsaOnConflict: 1

PSA attributes are merged with the attributes derived from PrintTicket, preferring the PSA over Print Ticket for the attributes with the same name.

### -field DoNotMergeWithPrintTicket: 2

The PSA provides a new set of attributes which are not merged with the attributes derived from PrintTicket.

## -remarks

## -see-also

## -examples


