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


The values you get for the properties are technically untyped objects (variants) because they are being reported directly from registry info (HKLM). Here are the types that you can use as type-casting options (which might be needed for UI display) for each of the properties:<table>
   <tr><td>[BatteryLifeDescription](knownretailinfoproperties_batterylifedescription.md)</td><td>**String**</td></tr>
   <tr><td>[DisplayDescription](knownretailinfoproperties_displaydescription.md)</td><td>**String**</td></tr>
   <tr><td>[DisplayModelName](knownretailinfoproperties_displaymodelname.md)</td><td>**String**</td></tr>
   <tr><td>[FormFactor](knownretailinfoproperties_formfactor.md)</td><td>**String**</td></tr>
   <tr><td>[FrontCameraDescription](knownretailinfoproperties_frontcameradescription.md)</td><td>**String**</td></tr>
   <tr><td>[GraphicsDescription](knownretailinfoproperties_graphicsdescription.md)</td><td>**String**</td></tr>
   <tr><td>[HasNfc](knownretailinfoproperties_hasnfc.md)</td><td>**Boolean**</td></tr>
   <tr><td>[HasOpticalDrive](knownretailinfoproperties_hasopticaldrive.md)</td><td>**Boolean**</td></tr>
   <tr><td>[HasSdSlot](knownretailinfoproperties_hassdslot.md)</td><td>**Boolean**</td></tr>
   <tr><td>[IsFeatured](knownretailinfoproperties_isfeatured.md)</td><td>**Boolean**</td></tr>
   <tr><td>[IsOfficeInstalled](knownretailinfoproperties_isofficeinstalled.md)</td><td>**Boolean**</td></tr>
   <tr><td>[ManufacturerName](knownretailinfoproperties_manufacturername.md)</td><td>**String**</td></tr>
   <tr><td>[Memory](knownretailinfoproperties_memory.md)</td><td>**String**</td></tr>
   <tr><td>[ModelName](knownretailinfoproperties_modelname.md)</td><td>**String**</td></tr>
   <tr><td>[Price](knownretailinfoproperties_price.md)</td><td>**Double**</td></tr>
   <tr><td>[ProcessorDescription](knownretailinfoproperties_processordescription.md)</td><td>**String**</td></tr>
   <tr><td>[RearCameraDescription](knownretailinfoproperties_rearcameradescription.md)</td><td>**String**</td></tr>
   <tr><td>[RetailAccessCode](knownretailinfoproperties_retailaccesscode.md)</td><td>**String**</td></tr>
   <tr><td>[ScreenSize](knownretailinfoproperties_screensize.md)</td><td>**String**</td></tr>
   <tr><td>[StorageDescription](knownretailinfoproperties_storagedescription.md)</td><td>**String**</td></tr>
   <tr><td>[Weight](knownretailinfoproperties_weight.md)</td><td>**String**</td></tr>
   <tr><td>[WindowsEdition](knownretailinfoproperties_windowsedition.md)</td><td>**String**</td></tr>
</table>

## -examples

## -see-also
