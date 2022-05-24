---
-api-id: M:Windows.UI.Composition.AnimationPropertyInfo.GetResolvedCompositionObjectProperty
-api-type: winrt method
---

# Windows.UI.Composition.AnimationPropertyInfo.GetResolvedCompositionObjectProperty

<!--
public string GetResolvedCompositionObjectProperty ();
-->

## -description

Retrieves the animatable property from the composition object associated with the `AnimationPropertyInfo`.

## -returns

The animatable property from the composition object associated with the `AnimationPropertyInfo`.

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
