---
-api-id: M:Windows.Media.AudioBuffer.CreateReference
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IMemoryBufferReference CreateReference()
-->

# Windows.Media.AudioBuffer.CreateReference

## -description
Returns an [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) representation of the audio buffer.

## -returns
The [IMemoryBufferReference](../windows.foundation/imemorybufferreference.md) representation of the audio buffer.

## -remarks
The audio buffer is in the form of an array of samples.
Each sample is a series of IEEE single-precision floating point values
in a linear range from &minus;1.0 to +1.0, one value per channel.
The channels within a sample are in speaker number order,
as given in the documentation for
[**WAVEFORMATEXTENSIBLE**](/windows/win32/api/mmreg/ns-mmreg-waveformatextensible).

For example, in the case of a left/right two-channel audio buffer,
the floating point values are the left and right channels of the first sample,
followed by
the left and right channels of the second sample,
and so on.

## -examples

## -see-also
