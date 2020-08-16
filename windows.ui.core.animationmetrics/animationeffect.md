---
-api-id: T:Windows.UI.Core.AnimationMetrics.AnimationEffect
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.AnimationMetrics.AnimationEffect : int
-->

# AnimationEffect

## -description
Specifies an animation.

## -enum-fields
### -field Expand:0
<!--Wherever possible, change passive voice to active in the descriptions below.-->
An object increases in size to reveal additional content.

### -field Collapse:1
An object decreases in size to hide content.

### -field Reposition:2
An object changes position. No more specific animation applies.

### -field FadeIn:3
A contextual control fades in.

### -field FadeOut:4
A contextual control fades out.

### -field AddToList:5
An object is added to a list.

### -field DeleteFromList:6
An object is removed from a list.

### -field AddToGrid:7
An object is added to a collection that is arranged in a grid.

### -field DeleteFromGrid:8
An object is removed from a collection that is arranged in a grid.

### -field AddToSearchGrid:9
An object is added to search results that are arranged in a grid.

### -field DeleteFromSearchGrid:10
An object is removed from search results that are arranged in a grid.

### -field AddToSearchList:11
An object is added to a vertically arranged list of search results.

### -field DeleteFromSearchList:12
An object is removed from a vertically arranged list of search results.

### -field ShowEdgeUI:13
UI is brought in from the edge of the screen.

### -field ShowPanel:14
A section of content appears on the screen.

### -field HideEdgeUI:15
UI displayed at the edge of the screen is removed.

### -field HidePanel:16
A section of content is removed from the screen.

### -field ShowPopup:17
A pop-up control appears on the screen.

### -field HidePopup:18
A pop-up control is removed from the screen.

### -field PointerDown:19
The pointing device (such as a mouse or touch) has engaged on an item.

### -field PointerUp:20
The pointing device (such as a mouse or touch) has disengaged from an item.

### -field DragSourceStart:21
The user has begun dragging an item.

### -field DragSourceEnd:22
The user has stopped dragging an item.

### -field TransitionContent:23
Large-scale content replacement is occurring.

### -field Reveal:24
UI expands around a tapped or clicked target.

### -field Hide:25
UI collapses around a tapped or clicked target.

### -field DragBetweenEnter:26
A drag source has moved between two items.

### -field DragBetweenLeave:27
A drag source is no longer between two items.

### -field SwipeSelect:28
An object has been selected through the swipe interaction.

### -field SwipeDeselect:29
An object has been deselected through the swipe interaction.

### -field SwipeReveal:30
Triggered by a press and hold on an item that can be cross-slide selected.

### -field EnterPage:31
A page of content is brought in to the display.

### -field TransitionPage:32
One page is replaced by another page.

### -field CrossFade:33
One item is faded out as another fades in its place.

### -field Peek:34
Contents of a tile move up or down to show a part of the tile that is normally hidden.

### -field UpdateBadge:35
Update a tile's badge overlay.

## -remarks
The [AnimationDescription](animationdescription.md) constructor uses the values of this enumeration to specify the animation.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
