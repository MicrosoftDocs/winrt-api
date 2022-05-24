---
-api-id: M:Windows.UI.Xaml.PropertyMetadata.#ctor(System.Object,Windows.UI.Xaml.PropertyChangedCallback)
-api-type: winrt method
---

<!-- Method syntax
public PropertyMetadata(System.Object defaultValue, Windows.UI.Xaml.PropertyChangedCallback propertyChangedCallback)
-->

# Windows.UI.Xaml.PropertyMetadata.PropertyMetadata

## -description
Initializes a new instance of the [PropertyMetadata](propertymetadata.md) class, using a property default value and callback reference.


## -parameters
### -param defaultValue
A default value for the property where this [PropertyMetadata](propertymetadata.md) is applied.

### -param propertyChangedCallback
A reference to the callback to call for property changed behavior.

## -remarks
If you want to establish a [PropertyMetadata](propertymetadata.md) instance that has a property-changed callback method but not a default value, pass **null** for *defaultValue*.

If you pass a value for *defaultValue*, make sure that the type of that value is valid for the *propertyType* type from the dependency property's definition through the [Register](dependencyproperty_register_1826645607.md) call. If you've created a type mismatch between registration parameter and metadata, the issue only manifests itself indirectly. You'll get runtime errors when you try to instantiate a type that has this dependency property value, you won't get any design-time or compile-time warning or error.

## -examples
This example shows usage of this constructor. `OnLabelChanged` refers to a delegate implementation for a [PropertyChangedCallback](propertychangedcallback.md) (not shown). To see more code that puts this example in context, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

```csharp
public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
  "Label",
  typeof(String),
  typeof(ImageWithLabelControl),
  new PropertyMetadata(null,new PropertyChangedCallback(OnLabelChanged))
);
```

```vb
Public Shared ReadOnly LabelProperty As DependencyProperty = _
    DependencyProperty.Register("Label", _
      GetType(String), GetType(ImageWithLabelControl), _
      New PropertyMetadata(Nothing, new PropertyChangedCallback(AddressOf OnLabelChanged)))
```

```
DependencyProperty^ ImageWithLabelControl::_LabelProperty = 
    DependencyProperty::Register("Label", 
    Platform::String::typeid,
    ImageWithLabelControl::typeid, 
    ref new PropertyMetadata(nullptr,
      ref new PropertyChangedCallback(&ImageWithLabelControl::OnLabelChanged))
    );
```



## -see-also
[PropertyMetadata(Object)](propertymetadata_propertymetadata_365528641.md), [DependencyProperty.Register](dependencyproperty_register_1826645607.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties)
