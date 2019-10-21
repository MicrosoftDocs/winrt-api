---
-api-id: T:Windows.System.Profile.KnownRetailInfoProperties
-api-type: winrt class
---

<!-- Class syntax.
public class KnownRetailInfoProperties 
-->

# Windows.System.Profile.KnownRetailInfoProperties

## -description
Identifies the string keys that might exist within the [RetailInfo.Properties](retailinfo_properties.md) map of retail-demo relevant property values.

## -remarks
All members of KnownRetailInfoProperties are static string properties where the base API name and the value of the string match exactly. The intention of this type is to use the members as the string source when you use the generic [IMapView](../windows.foundation.collections/imapview_2.md) or [IReadOnlyDictionary](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary-2?redirectedfrom=MSDN) APIs that access the [RetailInfo.Properties](retailinfo_properties.md) items by string key, so that you're asking for properties that typically exist.

## -examples

## -see-also
[RetailInfo.Properties](retailinfo_properties.md)
