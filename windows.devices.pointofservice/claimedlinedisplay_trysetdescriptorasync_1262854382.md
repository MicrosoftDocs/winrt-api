---
-api-id: M:Windows.Devices.PointOfService.ClaimedLineDisplay.TrySetDescriptorAsync(System.UInt32,Windows.Devices.PointOfService.LineDisplayDescriptorState)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ClaimedLineDisplay.TrySetDescriptorAsync(UInt32 descriptor, LineDisplayDescriptorState descriptorState)
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay.TrySetDescriptorAsync

## -description
Attempts to asynchronously set a descriptor using the specified attribute.



## -parameters
### -param descriptor
The descriptor to be set. Must have a value between 0 and [LineDisplayCapabilities.SupportedDescriptors](LineDisplayCapabilities_SupportedDescriptors.md) - 1.

### -param descriptorState
The state to give to the descriptor.

## -returns
Returns True if the descriptor was set successfully; otherwise, False.

## -remarks
[LineDisplayCapabilities.SupportedDescriptors](LineDisplayCapabilities_SupportedDescriptors.md) must be greater than zero for this method to be successfully executed.

## -see-also

## -examples

