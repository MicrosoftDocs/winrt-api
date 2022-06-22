---
-api-id: T:Windows.UI.Composition.CompositionPropertySet
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionPropertySet : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionPropertySet, Windows.UI.Composition.ICompositionPropertySet2
-->

# Windows.UI.Composition.CompositionPropertySet

## -description

Stores values as key-value pairs.



## -remarks

**CompositionPropertySet**s are [CompositionObject](compositionobject.md)s that allow storage of key values pairs that can be shared across the application and are not tied to the lifetime of another composition object. **CompositionPropertySet**s are most commonly used with animations, where they maintain key-value pairs that are referenced to drive portions of composition animations. **CompositionPropertySet**s provide the ability to insert key-value pairs or retrieve a value for a given key. For more information on using **CompositionPropertySet** with animations, see the [Animations Overview](/windows/uwp/graphics/composition-animation) page.

CompositionPropertySet does not support a delete function – ensure you use CompositionPropertySet to store values that will be shared across the application.

> [!NOTE]
> Inserting a new value into a CompositionPropertySet for a key that already exists will overwrite the old value with the new one.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | InsertBoolean |
| 1607 | 14393 | TryGetBoolean |

## -examples


```csharp

void CreatePropertySet()
{
  // Create the CompositionPropertySet and insert a scalar value
  CompositionPropertySet sharedPropSet = _compositor.CreatePropertySet();
  sharedPropSet.InsertScalar("offsetChange", 50f);

  // Reference value in CompositionPropertySet in an Expression
  ExpressionAnimation expression =
  _compositor.CreateExpressionAnimation("this.Target.Offset.X + shared.offsetChange");
  expression.SetReferenceParameter("shared", sharedPropSet);
}

void PropertySetRetrieve(CompositionPropertySet propertySet)
{
  // Retrieve the value of key in a CompositionPropertySet
  float tempOffset;
  propertySet.TryGetScalar("offsetChange", out tempOffset);
}
        
```



## -see-also
[CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)
