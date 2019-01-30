---
-api-id: E:Windows.Foundation.IMemoryBufferReference.Closed
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.TypedEventHandler Closed<Windows.Foundation.IMemoryBufferReference,  object>
-->

# Windows.Foundation.IMemoryBufferReference.Closed

## -description

Occurs when [MemoryBuffer.Close](memorybuffer_close_811482585.md) has been called, but before this [IMemoryBufferReference](imemorybufferreference.md) has been closed.

## -remarks

This event gives one last chance to access the [IMemoryBufferReference](imemorybufferreference.md) before it is gone.

## -examples

## -see-also
