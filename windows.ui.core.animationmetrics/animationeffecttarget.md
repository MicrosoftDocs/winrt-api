---
-api-id: T:Windows.UI.Core.AnimationMetrics.AnimationEffectTarget
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.AnimationMetrics.AnimationEffectTarget : int
-->

# AnimationEffectTarget

## -description
Specifies a participant in an animation.

## -enum-fields
### -field Primary:0
The only participant in an single-target animation.

### -field Added:1
Objects that are being added.

### -field Affected:2
Objects affected by the animation, such as objects that move out of the way when another object is dropped between them.

### -field Background:3
The background object of the item.

### -field Content:4
The content of the item.

### -field Deleted:5
Objects that are being deleted.

### -field Deselected:6
Objects that have been deselected through a cross-slide deselect interaction.

### -field DragSource:7
Objects that are being dragged.

### -field Hidden:8
Objects that are currently hidden.

### -field Incoming:9
New content to replace old content.

### -field Outgoing:10
Old content that is being replaced by new content.

### -field Outline:11
An outline border around an area.

### -field Remaining:12
Objects that are left behind after other items have been removed.

### -field Revealed:13
Objects that become visible in an expansion.

### -field RowIn:14
A row that is being added to a grid.

### -field RowOut:15
A row that is about to be removed from a grid.

### -field Selected:16
Objects that are selected through a cross-slide select interaction.

### -field Selection:17
Objects, such as checkmarks, that indicate that an item is selected.

### -field Shown:18
Objects previously invisible that are becoming visible.

### -field Tapped:19
Objects that have been tapped or clicked on.

## -remarks
The [AnimationDescription](animationdescription.md) constructor uses the values of this enumeration to specify the animation target. The definition of each value can sometimes depend on 
which [animation effect](animationeffect.md)is being performed.

Not all animations can be applied to all targets. See the specific documentation and guidance for an animation to determine which targets are supported.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics), [AnimationEffect](animationeffect.md)
