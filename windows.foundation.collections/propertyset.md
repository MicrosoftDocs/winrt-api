---
-api-id: T:Windows.Foundation.Collections.PropertySet
-api-type: winrt class
---

<!-- Class syntax.
public class PropertySet : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMap<System.String, System.Object>, Windows.Foundation.Collections.IObservableMap<System.String, System.Object>, Windows.Foundation.Collections.IPropertySet
-->

# Windows.Foundation.Collections.PropertySet

## -description
Represents a property set, which is a set of [PropertyValue](../windows.foundation/propertyvalue.md) objects with string keys.

## -remarks
This class implements a map (the [IMap<K,V>](imap_2.md) interface) with keys of type **String** and values of type [PropertyValue](../windows.foundation/propertyvalue.md). The PropertySet type enables various Windows Runtime APIs to return a collection of mixed values that can still be iterated or inspected using the common collection APIs of PropertySet, which match those of [IMap<K,V>](imap_2.md), [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true), or JavaScript collection and enumeration techniques, depending on which language your app uses.

[PropertyValue](../windows.foundation/propertyvalue.md) is a class that supports a large number of static **Create*** methods that create a deliberately untyped value from an input that's typically a value type or primitive (Boolean, numbers and so on) or an array of those values. Once one of the static [PropertyValue](../windows.foundation/propertyvalue.md) methods is called, its return value can be treated as a [PropertyValue](../windows.foundation/propertyvalue.md) instance (however the **Create*** methods technically return an **Object** if you look at the signatures).

However, you don't typically use a PropertySet in a way that requires you to fill the [PropertyValue](../windows.foundation/propertyvalue.md) values in the set yourself. Instead, you typically get a filled-in PropertySet as a return value from a Windows Runtime API that's providing a collection where the value types within it might be mixed, but are still related to each other by origin or scenario. For example, the [LocalSettings](../windows.storage/applicationdata_localsettings.md) and [RoamingSettings](../windows.storage/applicationdata_roamingsettings.md) values that you get when you retrieve app data are of type [ApplicationDataContainer](../windows.storage/applicationdatacontainer.md), and each contains a PropertySet as its [Values](../windows.storage/applicationdatacontainer_values.md) property value. When you interact with app data that's storing settings, you typically get the collection from [ApplicationDataContainer.Values](../windows.storage/applicationdatacontainer_values.md). Then you can:
+ iterate over the set using the appropriate iteration syntax
+ use [HasKey](propertyset_haskey_425964900.md)/[ContainsKey](/dotnet/api/system.collections.generic.idictionary-2.containskey) to verify the existence of a [PropertyValue](../windows.foundation/propertyvalue.md) in the set
+ use [Lookup](propertyset_lookup_711408188.md) or the [Item](/dotnet/api/system.collections.generic.idictionary-2.item) indexer to retrieve an item once you know it exists


For scenarios like working with app data, when you have a PropertySet you have it by reference, so if you add items to the PropertySet using [Add](/dotnet/api/system.collections.generic.idictionary-2.add)/[Insert](propertyset_insert_2123640444.md) these items will be added to the app data, and removing items removes them from app data. All such changes are then shared through the app data mechanisms, if they're made to the [RoamingSettings](../windows.storage/applicationdata_roamingsettings.md).

There are other Windows Runtime APIs that use a PropertySet value as a direct value rather than wrapped in another class like [ApplicationDataContainer](../windows.storage/applicationdatacontainer.md). For example, [CoreApplication.Properties](../windows.applicationmodel.core/coreapplication_properties.md) returns a PropertySet.

Various properties that report info from media and devices use PropertySet, for example [PlayToReceiver.Properties](../windows.media.playto/playtoreceiver_properties.md). However, there are other media/devices property sets that don't use PropertySet and instead use [MediaPropertySet](../windows.media.mediaproperties/mediapropertyset.md), because the identifier for those properties is better represented when keyed as a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) rather than a string.

In many cases where a Windows Runtime API uses a PropertySet as a value, it's actually shown as [IPropertySet](ipropertyset.md) in the signatures. PropertySet can be considered the practical implementation of [IPropertySet](ipropertyset.md) that's ready for use by app code. JavaScript code can treat any [IPropertySet](ipropertyset.md) value as if it implemented the PropertySet prototypes.

### Collection member lists

For JavaScript, PropertySet supports using an index to access items.

## -examples

## -see-also
[Windows.Foundation.PropertyValue class](../windows.foundation/propertyvalue.md), [IPropertySet interface](ipropertyset.md)
