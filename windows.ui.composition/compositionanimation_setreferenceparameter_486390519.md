---
-api-id: M:Windows.UI.Composition.CompositionAnimation.SetReferenceParameter(System.String,Windows.UI.Composition.CompositionObject)
-api-type: winrt method
---

<!-- Method syntax
public void SetReferenceParameter(System.String key, Windows.UI.Composition.CompositionObject compositionObject)
-->

# Windows.UI.Composition.CompositionAnimation.SetReferenceParameter

## -description
Sets a reference to a Composition object for use with an [ExpressionAnimation](expressionanimation.md) or an [expression keyframe](keyframeanimation_insertexpressionkeyframe_1955314135.md).



## -parameters
### -param key
The name of the parameter to set. The name can be used to reference the parameter in the [ExpressionAnimation](expressionanimation.md).

### -param compositionObject
The [CompositionObject](compositionobject.md) value.

## -remarks
By setting a reference to a [CompositionObject](compositionobject.md), an [ExpressionAnimation](expressionanimation.md) can refer to any animatable property on that [CompositionObject](compositionobject.md). The [CompositionObject](compositionobject.md)'s current property value in the [Compositor](compositor.md) will be used when calculating the value of the expression. See the remarks section of [ExpressionAnimation](expressionanimation.md) for additional information.

## -examples
The sample below outlines how to use an [ExpressionAnimation](expressionanimation.md) to create a parallax effect between a background and foreground visual. This type of animation can be seen on the Windows Start Screen and Windows Phone Hub UIs.

```csharp

void CreateParallaxExpression(Visual foreground, Visual background) 
{ 
    var animation = _compositor.CreateExpressionAnimation(); 

    animation.Expression = "foreground.Offset * (foreground.Size / background.Size)"; 

    animation.SetReferenceParameter("foreground", foreground); 
    animation.SetReferenceParameter("background", background); 

    background.StartAnimation("Offset", animation); 
} 
          
```



## -see-also
