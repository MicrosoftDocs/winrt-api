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
See the [MediaStreamSource Sample](http://go.microsoft.com/fwlink/p/?LinkID=309021) for an example of using Media Stream Source in a Universal Windows app.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

You can iterate through a [MediaStreamSamplePropertySet](mediastreamsamplepropertyset.md) object in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://msdn.microsoft.com/en-us/library/system.collections.ienumerable.getenumerator.aspx), cast the collection object to [IEnumerable&lt;T&gt;](https://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) with a [KeyValuePair](https://msdn.microsoft.com/en-us/library/5tbh8a42.aspx) of [Guid](https://msdn.microsoft.com/library/system.guid.aspx) and [Object](https://msdn.microsoft.com/library/system.object.aspx) as the constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[IMap(Guid, Object)](../windows.foundation.collections/imap_2.md), [IIterable(IKeyValuePair)](../windows.foundation.collections/iiterable_1.md), [ExtendedProperties](mediastreamsample_extendedproperties.md), [MediaStreamSource Sample](http://go.microsoft.com/fwlink/p/?LinkID=309021)