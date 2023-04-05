---
-api-id: M:Windows.UI.Composition.CompositionAnimation.SetExpressionReferenceParameter(System.String,Windows.UI.Composition.IAnimationObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void CompositionAnimation.SetExpressionReferenceParameter(String parameterName, IAnimationObject source)
-->

# Windows.UI.Composition.CompositionAnimation.SetExpressionReferenceParameter

## -description

Sets an object that implements [IAnimationObject](ianimationobject.md) as a reference parameter in an [ExpressionAnimation](expressionanimation.md).

## -parameters

### -param parameterName

The name of the parameter to set.

### -param source

The source object.

## -remarks

## -see-also

## -examples

```csharp
// CustomObject that implements IAnimationObject.
class CustomObject : IAnimationObject
{
    public CustomObject(Compositor compositor)
    {
        _targetVisual = compositor.CreateSpriteVisual();
    }

    // Implement PopulatePropertyInfo method that 
    // redirects the property named "CustomOffset"
    // to the Offset property of the underlying visual.
    void IAnimationObject.PopulatePropertyInfo(
        string propertyName,
        AnimationPropertyInfo propertyInfo)
    {
        if (propertyName.Equals(“CustomOffset”)
        {
            _targetVisual.PopulatePropertyInfo(
                “Offset”,
                propertyInfo);           
        }
    }

    private SpriteVisual _targetVisual = null;
}

// Sample usage of CustomObject in an ExpressionAnimation.
void SetupExpression(
    Compositor compositor, 
    IAnimationObject customObject,
    SpriteVisual target)
{
    var expAnim = compositor.CreateExpressionAnimation(
        “customObject.CustomOffset + vector3(100.0f, 0.0f, 0.0f)”);

    expAnim.SetExpressionReferenceParameter(“customObject”, customObject);

    targetVisual.StartAnimation(“Offset”, expAnim);        
}
```
