---
-api-id: M:Windows.UI.Composition.Compositor.CreateAnimationPropertyInfo
-api-type: winrt method
---

# Windows.UI.Composition.Compositor.CreateAnimationPropertyInfo

<!--
public Windows.UI.Composition.AnimationPropertyInfo CreateAnimationPropertyInfo ();
-->


## -description

Creates an instance of [AnimationPropertyInfo](animationpropertyinfo.md).

## -returns

Returns the created [AnimationPropertyInfo](animationpropertyinfo.md) object.

## -remarks

## -see-also

## -examples

```csharp
// Create an AnimationPropertyInfo object that will hold the mapping between the custom
// animatable property and the corresponding composition object.
AnimationPropertyInfo propertyInfo = _compositor.CreateAnimationPropertyInfo();

animatableObject.PopulatePropertyInfo("CustomOffset", propertyInfo);

// Get the resolved composition object and property for "CustomOffset".
CompositionObject resolvedObject = propertyInfo.GetResolvedCompositionObject();
String resolvedProperty = propertyInfo.GetResolvedCompositionObjectProperty();
```
