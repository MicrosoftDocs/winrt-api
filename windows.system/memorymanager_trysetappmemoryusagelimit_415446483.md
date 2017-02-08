---
-api-id: M:Windows.System.MemoryManager.TrySetAppMemoryUsageLimit(System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySetAppMemoryUsageLimit(System.UInt64 value)
-->

# Windows.System.MemoryManager.TrySetAppMemoryUsageLimit

## -description
Tries to set a specific memory cap for the current app or task. In cases where memory caps are shared between foreground and background components, any difference between the default cap and the new request will be assigned to the other component.

## -parameters
### -param value
The new memory limit to set.

## -returns
True if the operation succeeded; otherwise, false.

## -remarks

## -examples

## -see-also
