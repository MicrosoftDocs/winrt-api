---
-api-id: P:Windows.UI.Xaml.DependencyPropertyChangedEventArgs.Property
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty Property { get; }
-->

# Windows.UI.Xaml.DependencyPropertyChangedEventArgs.Property

## -description
Gets the identifier for the dependency property where the value change occurred.

## -property-value
The identifier field of the dependency property where the value change occurred.

## -remarks
In many cases the dependency property being changed is known implicitly, because you're checking the [DependencyPropertyChangedEventArgs](dependencypropertychangedeventargs.md) data in a callback that's dedicated for use only by one defined dependency property. The [Property](dependencypropertychangedeventargs_property.md) property makes it possible to share a [PropertyChangedCallback](propertychangedcallback.md) as a common callback for more than one [PropertyMetadata](propertymetadata.md) instance and more than one dependency property. For example, you might have handler logic that first checks [Property](dependencypropertychangedeventargs_property.md) and then branches behavior (like knowing how to cast [NewValue](dependencypropertychangedeventargs_newvalue.md)) depending on which property's change invoked the handler in this event case:

```
private static void OnGravityPropertiesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
    if (e.Property==Planet.GravityFactorProperty) {
        //GravityFactor is a Double, cast e.NewValue to Double, do logic
    }
    if (e.Property==Planet.IsGravityOnProperty) {
        //IsGravityOn is a Boolean, cast e.NewValue to Boolean, do logic
    }
}
```



## -examples

## -see-also
[Dependency properties overview](https://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e)
