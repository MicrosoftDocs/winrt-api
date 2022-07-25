---
-api-id: M:Windows.UI.Xaml.DependencyObject.RegisterPropertyChangedCallback(Windows.UI.Xaml.DependencyProperty,Windows.UI.Xaml.DependencyPropertyChangedCallback)
-api-type: winrt method
---

<!-- Method syntax
public long RegisterPropertyChangedCallback(Windows.UI.Xaml.DependencyProperty dp, Windows.UI.Xaml.DependencyPropertyChangedCallback callback)
-->

# Windows.UI.Xaml.DependencyObject.RegisterPropertyChangedCallback

## -description
Registers a notification function for listening to changes to a specific [DependencyProperty](dependencyproperty.md) on this [DependencyObject](dependencyobject.md) instance.



## -parameters
### -param dp
The dependency property identifier of the property to register for property-changed notification.

### -param callback
A callback based on the [DependencyPropertyChangedCallback](dependencypropertychangedcallback.md) delegate, which the system invokes when the value of the specified property changes.

## -returns
A token that represents the callback, used to identify the callback in calls to [UnregisterPropertyChangedCallback](dependencyobject_unregisterpropertychangedcallback_129400824.md).

## -remarks
Use RegisterPropertyChangedCallback to get property-changed notification for dependency properties that are already defined as part of the XAML framework. This is useful for properties where were isn't already a corresponding XAML framework event that tracks changes. For example, [FrameworkElement.Tag](frameworkelement_tag.md) is an existing XAML framework dependency property, and your app could track when that property's value changes because some external input (like a data binding) has changed that property's runtime value on a particular object instance that's part of your app UI.

To unregister the callback, call [UnregisterPropertyChangedCallback](dependencyobject_unregisterpropertychangedcallback_129400824.md) and pass in the token returned by this method.

You don't typically use RegisterPropertyChangedCallback for notifications on a custom dependency property, because custom dependency properties already have a way to register a property-changed handler that provides more data in the event args. For more info, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

## -examples
This example shows how to use a [DependencyPropertyChangedCallback](dependencypropertychangedcallback.md) delegate to listen for changes to the [Tag](frameworkelement_tag.md) property on a [TextBlock](../windows.ui.xaml.controls/textblock.md).

```xaml
<TextBlock x:Name="textBlock1" Text="Hello, world"/>
```

```csharp
long tagToken;
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    tagToken = textBlock1.RegisterPropertyChangedCallback(TextBlock.TagProperty, tbTagChangedCallback);
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
[UnregisterPropertyChangedCallback](dependencyobject_unregisterpropertychangedcallback_129400824.md), [DependencyPropertyChangedCallback](dependencypropertychangedcallback.md)
