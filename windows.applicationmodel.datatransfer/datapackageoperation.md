---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataPackageOperation
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.DataTransfer.DataPackageOperation : uint
-->

# DataPackageOperation

## -description
Specifies the operation to perform on the [DataPackage](datapackage.md) in clipboard and drag and drop scenarios.

## -enum-fields
### -field None:0
No action. Typically used when the [DataPackage](datapackage.md) object requires delayed rendering.

### -field Copy:1
Copies the content to the target destination. When implementing clipboard functionality, this corresponds to the "Copy" command.

### -field Move:2
Copies the content to the target destination and deletes the original. When implementing clipboard functionality, this corresponds to the "Cut" command.

### -field Link:4
Creates a link for the data.


## -remarks
If your app supports the exchange of data through clipboard and drag and drop, you need to specify what type operation the user wants. The available operations are none/no action, copy, move, and link.

Many existing controls, such as the text box control, include support for Clipboard actions. Before implementing your own support for these actions, check to see if they are already supported.

## -examples

## -see-also
[DataPackage.RequestedOperation](datapackage_requestedoperation.md)