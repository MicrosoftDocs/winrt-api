---
-api-id: T:Windows.UI.Xaml.DependencyPropertyChangedCallback
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void DependencyPropertyChangedCallback(Windows.UI.Xaml.DependencyObject sender, Windows.UI.Xaml.DependencyProperty dp)
-->
# Windows.UI.Xaml.DependencyPropertyChangedCallback

## -description
Represents the callback that is invoked when a property value changes, for property change notifications that are registered with the [RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_1557279748.md) technique.



## -parameters
### -param sender
The object instance that holds the property to register for property-changed notification.

### -param dp
The dependency property identifier of the property to register for property-changed notification.


## -remarks
The parameter values of the delegate are based on the parameter given to the [RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_1557279748.md) invocation that registered a particular property for property-changed notification, and the instance that invoked it.

Because the callback has the *dp* parameter that identifies which property value changed, you can use the same callback to handle multiple property-changed cases, and your logic can write cases for each different property.

For performance reasons, you don't get an [OldValue](dependencypropertychangedeventargs_oldvalue.md) / [NewValue](dependencypropertychangedeventargs_newvalue.md) property pair from a [PropertyChangedCallback](propertychangedcallback.md) method like you do from [DependencyPropertyChangedEventArgs](dependencypropertychangedeventargs.md). The property value is changed before the callback, so once the method has been invoked, you can call [DependencyObject.GetValue](dependencyobject_getvalue_1188551207.md) to retrieve the new value.

## -examples
This example shows how to use a DependencyPropertyChangedCallback delegate to listen for changes to the [Tag](frameworkelement_tag.md) property on a [TextBlock](../windows.ui.xaml.controls/textblock.md).

```xaml
<TextBlock x:Name="textBlock1" Text="Hello, world"/>
```

```csharp
long tagToken;
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    long tagToken = textBlock1.RegisterPropertyChangedCallback(TextBlock.TagProperty, tbTagChangedCallback);
    base.OnNavigatedTo(e);

    textBlock1.Tag = "name";
}
 
protected override void OnNavigatedFrom(NavigationEventArgs e)
{
    textBlock1.UnregisterPropertyChangedCallback(TextBlock.TagProperty, tagToken);
    base.OnNavigatedFrom(e);
}

private void tbTagChangedCallback(DependencyObject sender, DependencyProperty dp)
{
    if (dp == TextBlock.TagProperty)
    {
       // These lines produce the same result.
       System.Diagnostics.Debug.WriteLine("The tag has been set to " + ((TextBlock)sender).Tag);
       System.Diagnostics.Debug.WriteLine("The tag has been set to " + sender.GetValue(dp));
    }
}
```



## -see-also
[RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_1557279748.md), [UnregisterPropertyChangedCallback](dependencyobject_unregisterpropertychangedcallback_129400824.md)
