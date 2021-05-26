---
-api-id: M:Windows.AI.MachineLearning.LearningModelSessionOptions.OverrideNamedDimension(System.String,System.UInt32)
-api-type: winrt method
---

# Windows.AI.MachineLearning.LearningModelSessionOptions.OverrideNamedDimension(System.String,System.UInt32)

<!--
public void OverrideNamedDimension (string name, uint dimension);
-->


## -description

Provides the ability to override named input dimensions of a Learning Model to concrete values.

## -parameters

### -param name

The name of the input dimension to set.

### -param dimension

The concrete value to assign to the specified dimension.

## -remarks

Using this API can yield performance improvements, as it allows for preallocation of tensors during session creation that would otherwise be allocated during model evaluation.


## -see-also

[NamedDimensionOverride interface]()

## -examples

```cpp
void SetNamedDimensionOverrides(LearningModel model) {
    // Create LearningModelSessionOptions
    auto options = LearningModelSessionOptions();
 
    // Override a named input dimension to a concrete value
    options->OverrideNamedDimension(L"dimension_name", 256);
 
    // Create session
    LearningModelSession session = nullptr;
    session = LearningModelSession(model, LearningModelDeviceKind::GPU, options);
}

```
