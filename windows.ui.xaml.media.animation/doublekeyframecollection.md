---
-api-id: T:Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection
-api-type: winrt class
---

<!-- Class syntax.
public class DoubleKeyFrameCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Animation.DoubleKeyFrame>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Animation.DoubleKeyFrame>
-->

# Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection

## -description
Represents a collection of [DoubleKeyFrame](doublekeyframe.md) objects that can be individually accessed by index. [DoubleKeyFrameCollection](doublekeyframecollection.md) is the value of the [DoubleAnimationUsingKeyFrames.KeyFrames](doubleanimationusingkeyframes_keyframes.md) property.

## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [DoubleKeyFrameCollection](doublekeyframecollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<DoubleKeyFrame>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with a [DoubleKeyFrame](doublekeyframe.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[DoubleAnimationUsingKeyFrames.KeyFrames](doubleanimationusingkeyframes_keyframes.md), [IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1)