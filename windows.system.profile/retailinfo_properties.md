---
-api-id: P:Windows.System.Profile.RetailInfo.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, object> Properties { get; }
-->

# Windows.System.Profile.RetailInfo.Properties

## -description
Gets an object that represents the set of available retail demo properties and their values.

## -property-value
A read-only collection of key-value pairs, each pair representing an available retail demo property. This is an instance of a collection interface, not a strongly typed collection, so use the interface APIs to work with the items.

## -remarks
These properties include specific information that is useful for apps that are running or otherwise available as pre-installed demo apps in a retail setting. For example, you can get a [ManufacturerName](knownretailinfoproperties_manufacturername.md), [ScreenSize](knownretailinfoproperties_screensize.md), and so on.

If [IsDemoModeEnabled](retailinfo_isdemomodeenabled.md) is **false**, Properties might contain a zero-length collection or **null**. Verify that [IsDemoModeEnabled](retailinfo_isdemomodeenabled.md) is **true** before getting the Properties value.

Once you have a valid collection, this collection is a map/dictionary where each property is identified by a property name. These property names are predefined, and each known property name is represented by a static string property of the [KnownRetailInfoProperties](knownretailinfoproperties.md) class. So whenever you attempt to get a specific property, use a [KnownRetailInfoProperties](knownretailinfoproperties.md) property to supply the string key value, rather than hard-coded strings. That will assure you aren't asking for values that don't exist in the collection.

The collection is represented by a different interface/object depending on which programming language you are using.
+ If you're using .NET code, the collection is an [IReadOnlyDictionary](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) instance, with string keys and nominally untyped ([Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)) values. Use the [Item](/dotnet/api/system.collections.generic.ireadonlydictionary-2.item?view=dotnet-uwp-10.0&preserve-view=true) indexer or [TryGetValue](/dotnet/api/system.collections.generic.ireadonlydictionary-2.trygetvalue?view=dotnet-uwp-10.0&preserve-view=true) to get the values of specific properties. Always use [KnownRetailInfoProperties](knownretailinfoproperties.md) properties to specify the *key* parameters.
+ If you're using C++/CX, the collection is an [IMapView(String, Object)](../windows.foundation.collections/imapview_2.md) instance, which can be used as [Platform::Collections::MapView](/cpp/cppcx/platform-collections-mapview-class). It has string keys and nominally untyped ([Platform::Object](/cpp/cppcx/platform-object-class)) values. Use **Lookup** to get the values of specific properties. Always use [KnownRetailInfoProperties](knownretailinfoproperties.md) properties to specify the *key* parameters.
+ If you're using JavaScript, the object represents [IMapView](../windows.foundation.collections/imapview_2.md) API with string keys and untyped values. Use [Lookup](../windows.foundation.collections/imapview_2_lookup_1104382727.md) to get the values of specific properties.

The values you get for the properties are technically untyped objects (variants) because they are being reported directly from registry info (HKLM). Here are the types that you can use as type-casting options (which might be needed for UI display) for each of the properties:

| Property | Type |
|---|---|
| [BatteryLifeDescription](knownretailinfoproperties_batterylifedescription.md) | **String** |
| [DisplayDescription](knownretailinfoproperties_displaydescription.md) | **String** |
| [DisplayModelName](knownretailinfoproperties_displaymodelname.md) | **String** |
| [FormFactor](knownretailinfoproperties_formfactor.md) | **String** |
| [FrontCameraDescription](knownretailinfoproperties_frontcameradescription.md) | **String** |
| [GraphicsDescription](knownretailinfoproperties_graphicsdescription.md) | **String** |
| [HasNfc](knownretailinfoproperties_hasnfc.md) | **Boolean** |
| [HasOpticalDrive](knownretailinfoproperties_hasopticaldrive.md) | **Boolean** |
| [HasSdSlot](knownretailinfoproperties_hassdslot.md) | **Boolean** |
| [IsFeatured](knownretailinfoproperties_isfeatured.md) | **Boolean** |
| [IsOfficeInstalled](knownretailinfoproperties_isofficeinstalled.md) | **Boolean** |
| [ManufacturerName](knownretailinfoproperties_manufacturername.md) | **String** |
| [Memory](knownretailinfoproperties_memory.md) | **String** |
| [ModelName](knownretailinfoproperties_modelname.md) | **String** |
| [Price](knownretailinfoproperties_price.md) | **Double** |
| [ProcessorDescription](knownretailinfoproperties_processordescription.md) | **String** |
| [RearCameraDescription](knownretailinfoproperties_rearcameradescription.md) | **String** |
| [RetailAccessCode](knownretailinfoproperties_retailaccesscode.md) | **String** |
| [ScreenSize](knownretailinfoproperties_screensize.md) | **String** |
| [StorageDescription](knownretailinfoproperties_storagedescription.md) | **String** |
| [Weight](knownretailinfoproperties_weight.md) | **String** |
| [WindowsEdition](knownretailinfoproperties_windowsedition.md) | **String** |

## -examples

## -see-also
