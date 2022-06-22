---
-api-id: T:Windows.UI.Composition.AnimationDelayBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AnimationDelayBehavior : int 
-->

# Windows.UI.Composition.AnimationDelayBehavior

## -description
Specifies the animation delay behavior.



## -enum-fields
### -field SetInitialValueBeforeDelay:1
Applies the initial value of the animation (i.e. the value at Keyframe 0) to the object before the delay time is elapsed (when there is a DelayTime specified), it then delays starting the animation according to the DelayTime. 

### -field SetInitialValueAfterDelay:0
Does not compute anything in animation nor holds the value of composition object property. If a DelayTime is specified, it delays starting the animation according to delay time and after delay has expired it applies animation to the object property.

## -remarks

## -see-also

## -examples

