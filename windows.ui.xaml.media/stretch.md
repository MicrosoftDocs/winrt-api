---
-api-id: T:Windows.UI.Xaml.Media.Stretch
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.Stretch : int
-->

# Stretch

## -description
Describes how content is resized to fill its allocated space.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field None:0
The content preserves its original size.

### -field Fill:1
The content is resized to fill the destination dimensions. The aspect ratio is not preserved.

### -field Uniform:2
The content is resized to fit in the destination dimensions while it preserves its native aspect ratio.

### -field UniformToFill:3
The content is resized to fill the destination dimensions while it preserves its native aspect ratio. If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit in the destination dimensions.


## -remarks

## -examples

## -see-also
