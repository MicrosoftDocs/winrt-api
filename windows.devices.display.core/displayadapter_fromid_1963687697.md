---
-api-id: M:Windows.Devices.Display.Core.DisplayAdapter.FromId(Windows.Graphics.DisplayAdapterId)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayAdapter DisplayAdapter.FromId(DisplayAdapterId id)
-->

# Windows.Devices.Display.Core.DisplayAdapter.FromId

## -description
Retrieves a [DisplayAdapter](displayadapter.md) for the given display adapter ID, if the adapter still exists on the system. This method throws an exception if the specified adapter cannot be found, or if it is no longer present on the system.

## -parameters
### -param id
The [DisplayAdapterId](../windows.graphics/displayadapterid.md) identifying the display adapter to retrieve. The identifier is a locally unique numeric ID (LUID) value.

## -returns
A [DisplayAdapter](displayadapter.md) object representing the specified adapter.

## -remarks

## -see-also

## -examples
