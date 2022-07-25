---
-api-id: T:Windows.UI.Xaml.DependencyPropertyChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class DependencyPropertyChangedEventArgs : Windows.UI.Xaml.IDependencyPropertyChangedEventArgs
-->

# Windows.UI.Xaml.DependencyPropertyChangedEventArgs

## -description
Provides data for a [PropertyChangedCallback](propertychangedcallback.md) implementation that is invoked when a dependency property changes its value. Also provides event data for the [Control.IsEnabledChanged](../windows.ui.xaml.controls/control_isenabledchanged.md) event and any other event that uses the [DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md) delegate.



## -remarks
DependencyPropertyChangedEventArgs provides data for two different situations that involve changes to dependency property values:
+ Situational callback information as used by a [PropertyChangedCallback](propertychangedcallback.md) for a custom dependency property. This is the more common case.
+ Event data for an event based on [DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md). This is less common because the only Windows Runtime event that uses this delegate is the [Control.IsEnabledChanged](../windows.ui.xaml.controls/control_isenabledchanged.md) event. For more info on how to use the DependencyPropertyChangedEventArgs event data in this case, see [DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md) or [Control.IsEnabledChanged](../windows.ui.xaml.controls/control_isenabledchanged.md).


A [PropertyChangedCallback](propertychangedcallback.md) implementation is an optional part of the property metadata that you provide when you register a dependency property. The callback is invoked by the dependency property system internally. For more info on dependency properties in general, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties) and [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

Typically you define the method with private or internal access. The method must be static. Because the method is static, the [DependencyObject](dependencyobject.md) parameter (*d*) of the [PropertyChangedCallback](propertychangedcallback.md) delegate is important. That's what identifies the specific dependency object instance where the property is changing. For many operations, such as correcting or coercing a value, or changing another calculated property value in response on the same object, you'll reference this [DependencyObject](dependencyobject.md). You'll typically want to cast it to the owner type of the property that changes. The owner type is the type referenced by name in the [DependencyProperty.Register](dependencyproperty_register_1826645607.md) call; the metadata where your [PropertyChangedCallback](propertychangedcallback.md) is assigned to property metadata is part of that same call.

Be aware of the possibility for recursion. If you change the value of a dependency property that the [PropertyChangedCallback](propertychangedcallback.md) is invoked for, it will be invoked again. For example, if you created a callback for a **Double** property where the callback always divided the value by 2, that callback would be called recursively and your app would be in an infinite loop.

It's legal to have two or more different dependency properties define callbacks to change each other, but again be careful to not create an unintentional circular dependency that doesn't enable the values to stabilize.

A [PropertyChangedCallback](propertychangedcallback.md) is only invoked if [OldValue](dependencypropertychangedeventargs_oldvalue.md) and [NewValue](dependencypropertychangedeventargs_newvalue.md) in the event data is different.

[OldValue](dependencypropertychangedeventargs_oldvalue.md) and [NewValue](dependencypropertychangedeventargs_newvalue.md) come untyped, so any comparison you perform probably needs a cast. Many dependency property values are using a value type, which means you'll be relying on the operators or other API of the value type to make the comparisons. That functionality is usually available on the structure that represents a value, as a utility API. For example, the language-specific utility API on a [Thickness](thickness.md) value enables you to compare [Thickness](thickness.md) values.

> [!NOTE]
> If you are programming using C++, a few of the Windows Runtime structures don't support nondata members, so don't support operators or other utility. For these, there is a companion **Helper** class that provides comparison API that C++ code can use. For example, use the [ColorHelper](../windows.ui/colorhelper.md) class to compare [Color](../windows.ui/color.md) values.

### Using **DependencyPropertyChangedEventArgs** for a custom event

A custom control implementer might consider using [DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md) as the delegate type if a custom event is fired as a result of a dependency property value change. You can only fire such an event from within the context of a [PropertyChangedCallback](propertychangedcallback.md). This is because the value that changed (the property, the old and new value) should be in the DependencyPropertyChangedEventArgs that are reported for the event at the property-system level. But there aren't any constructors for DependencyPropertyChangedEventArgs and none of its properties are settable, so the only way to get a DependencyPropertyChangedEventArgs value is to get it from the original [PropertyChangedCallback](propertychangedcallback.md) parameters and pass it through when you fire your custom event.

## -examples
This example shows a [PropertyChangedCallback](propertychangedcallback.md) implementation that uses the DependencyPropertyChangedEventArgs event data. In particular, it uses [NewValue](dependencypropertychangedeventargs_newvalue.md) to set a related property, which displays the underlying numeric [DependencyProperty](dependencyproperty.md) value as text, in a [TextBlock](../windows.ui.xaml.controls/textblock.md) part of a composite control.



[!code-csharp[ValueChangedCallback](../windows.ui.xaml/code/NumericUpDownCustomControl/csharp/NumericUpDownCustomControl.cs#SnippetValueChangedCallback)]

[!code-vb[ValueChangedCallback](../windows.ui.xaml/code/NumericUpDownCustomControl/vbnet/NumericUpDown.vb#SnippetValueChangedCallback)]

## -see-also
[PropertyChangedCallback](propertychangedcallback.md), [PropertyMetadata](propertymetadata.md), [DependencyObject](dependencyobject.md), [DependencyProperty](dependencyproperty.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
9e66-f71c-4daa-9994-617c886fda7e)
