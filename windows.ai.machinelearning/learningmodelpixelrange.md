---
-api-id: T:Windows.AI.MachineLearning.LearningModelPixelRange
-api-type: winrt enum
---

# Windows.AI.MachineLearning.LearningModelPixelRange

<!--
public enum LearningModelPixelRange
-->


## -description
Defines the list of image nominal pixel range suppored by Windows ML. The proper value is specified in a machine learning model's metadata.

## -enum-fields
### -field ZeroTo255:0
The pixel range is [0...255] for 8bpp(8 Bits per Pixel) samples.

### -field ZeroToOne:1
The [0...1] pixel data is stored normalized.

### -field MinusOneToOne:2
The [-1...1] pixel data is stored normalized.

## -remarks
If this value is not specified, the system will default to the **ZeroTo255** value.

### Windows Server
To use this API on Windows Server, you must use the [Windows Server 2019 with Desktop Experience](/windows-server/get-started-19/whats-new-19).

### Thread safety
This API is thread-safe.

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples


