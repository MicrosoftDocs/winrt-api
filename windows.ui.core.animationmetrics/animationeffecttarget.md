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
The background object
<!-- @WRITER erictill 5/21/2012 : Added "object" - is that right? -->
of the item.
<!-- @WRITER erictill 5/21/2012 : Could be clearer -->

### -field Content:4
The content of the item.
<!-- @WRITER erictill 5/21/2012 : Could be clearer -->

### -field Deleted:5
Objects that are being deleted.

### -field Deselected:6
Objects that have been deselected through a cross-slide deselect interaction.
<!-- @WRITER erictill 5/21/2012 : How about other ways? -->

### -field DragSource:7
Objects that are being dragged.

### -field Hidden:8
Objects that are currently hidden.
<!-- @WRITER erictill 5/21/2012 : Added "currently" - is that right? -->

### -field Incoming:9
New content to replace old content.
<!-- @WRITER erictill 7/21/2011 : I want to say new content being brought onto the screen, but that's kind of broad, and possibly inaccurate. But wait - does it have to be replacing something? -->

### -field Outgoing:10
Old content that is being replaced by new content.
<!-- @WRITER erictill 7/21/2011 : Outgoing of any type in any way? Define "content"?-->

### -field Outline:11
An outline border around an area.
<!-- @WRITER erictill 5/21/2012 : Could be clearer. -->

### -field Remaining:12
Objects that are left behind after other items have been removed.

### -field Revealed:13
Objects that become visible in an expansion.
<!-- @WRITER erictill 5/21/2012 : Have been revealed or will be revealed? -->

### -field RowIn:14
A row that is being added to a grid.

### -field RowOut:15
A row that is about to be removed from a grid.

### -field Selected:16
Objects that are selected through a cross-slide select interaction.
<!-- @WRITER erictill 5/21/2012 : How about ctrl+click? -->

### -field Selection:17
Objects, such as checkmarks, that indicate that an item is selected.

### -field Shown:18
Objects previously invisible that are becoming visible.
<!-- @WRITER erictill 5/21/2012 : What's the difference between this and Revealed? -->

### -field Tapped:19
Objects that have been tapped or clicked on.


## -remarks
The [AnimationDescription](animationdescription.md) constructor uses the values of this enumeration to specify the animation target. The definition of each value can sometimes depend on 
<!-- @WRITER erictill 5/21/2012 : changed the following from just "animation" to this. But am I right? Or was it talking about Opacity/Translation/Scale? -->
which [animation effect](animationeffect.md)is being performed.
<!-- @WRITER erictill 7/21/2011 : Guidance on when to use each specific type of animation is provided separately in the "Building Your App" library, which will be surfaced in MSDN as part of the Windows User Experience Guidelines. -->

Not all animations can be applied to all targets. See the specific documentation and guidance for an animation to determine which targets are supported.
<!-- @WRITER erictill 7/21/2011 : Make sure you have this somewhere. And now, nearly a year later, I'm not sure that I do, at least not like that. -->

## -examples

## -see-also
[Animation metrics sample](http://go.microsoft.com/fwlink/p/?linkid=242462), [AnimationEffect](animationeffect.md)