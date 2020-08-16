---
-api-id: T:Windows.Media.Core.MediaStreamSamplePropertySet
-api-type: winrt class
---

<!-- Class syntax.
public class MediaStreamSamplePropertySet : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.Guid, System.Object>>, Windows.Foundation.Collections.IMap<System.Guid, System.Object>
-->

# Windows.Media.Core.MediaStreamSamplePropertySet

## -description
Contains properties for the [MediaStreamSample](mediastreamsample.md).

## -remarks
See the [MediaStreamSource Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/MediaStreamSource%20streaming%20sample) for an example of using Media Stream Source in a Universal Windows app.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through a MediaStreamSamplePropertySet object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator?redirectedfrom=MSDN#System_Collections_IEnumerable_GetEnumerator), cast the collection object to [IEnumerable&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN) with a [KeyValuePair](https://docs.microsoft.com/dotnet/api/system.collections.generic.keyvaluepair-2?redirectedfrom=MSDN) of [Guid](https://docs.microsoft.com/dotnet/api/system.guid?redirectedfrom=MSDN) and [Object](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN) as the constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IMap(Guid, Object)](../windows.foundation.collections/imap_2.md), [IIterable(IKeyValuePair)](../windows.foundation.collections/iiterable_1.md), [ExtendedProperties](mediastreamsample_extendedproperties.md), [MediaStreamSource Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/MediaStreamSource%20streaming%20sample)
