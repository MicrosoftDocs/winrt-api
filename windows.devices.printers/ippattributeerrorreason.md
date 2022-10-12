---
-api-id: T:Windows.Devices.Printers.IppAttributeErrorReason
-api-type: winrt enum
---

# Windows.Devices.Printers.IppAttributeErrorReason

<!--
public enum IppAttributeErrorReason
-->


## -description

Defines values that represent the reasons why an attribute set operation failed for a printer or printer job.

## -enum-fields

### -field RequestEntityTooLarge: 0

An attribute value is too large to be set for the given attribute.

### -field AttributeNotSupported: 1

A specified attribute is not supported.

### -field AttributeValuesNotSupported: 2

A specified attribute value is not supported.

### -field AttributeNotSettable: 3

An attribute cannot be modified.

### -field ConflictingAttributes: 4

Two or more attributes have conflicting values.

## -remarks

## -see-also

[IppAttributeError.Reason](ippattributeerror_reason.md),[SetJobAttributesFromBuffer](/uwp/api/windows.graphics.printing.workflow.printworkflowprinterjob.setjobattributesfrombuffer),[SetJobAttributes](/uwp/api/windows.graphics.printing.workflow.printworkflowprinterjob.setjobattributes),[SetPrinterAttributes](ippprintdevice_setprinterattributes_265185914.md),[SetPrinterAttributesFromBuffer](ippprintdevice_setprinterattributesfrombuffer_1715668139.md)

## -examples


