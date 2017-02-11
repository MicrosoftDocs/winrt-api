---
-api-id: P:Windows.Devices.Perception.Provider.PerceptionFrame.FrameData
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IMemoryBuffer FrameData { get; }
-->

# Windows.Devices.Perception.Provider.PerceptionFrame.FrameData

## -description
The actual bytes of the frame which can be consumed as described by the Properties of the IPerceptionFrameProvider which produced the frame.

## -property-value
The bytes of the frames.

## -remarks
To write to these bytes, one can use Windows::Foundation::IMemoryBuffer::CreateReference() to create a Windows::Foundation::IMemoryBufferReference. That can then be converted to a Windows::Foundation::IMemoryBufferByteAccess and call GetBuffer() on that to get to the raw byte buffer.

## -examples

## -see-also
