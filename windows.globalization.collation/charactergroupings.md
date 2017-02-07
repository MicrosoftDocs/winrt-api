---
-api-id: T:Windows.Globalization.Collation.CharacterGroupings
-api-type: winrt class
---

<!-- Class syntax.
public class CharacterGroupings : Windows.Foundation.Collections.IIterable<Windows.Globalization.Collation.CharacterGrouping>, Windows.Foundation.Collections.IVectorView<Windows.Globalization.Collation.CharacterGrouping>, Windows.Globalization.Collation.ICharacterGroupings
-->

# Windows.Globalization.Collation.CharacterGroupings

## -description
Contains the set of character groups and the functionality to get the label for any given string.

## -remarks
### Collection member lists

For JavaScript, [CharacterGroupings](charactergroupings.md) has the members shown in the member lists. In addition, [CharacterGroupings](charactergroupings.md) supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

[CharacterGroupings](charactergroupings.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<CharacterGrouping>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [CharacterGrouping](charactergrouping.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
```javascript
// Create a CharacterGroupings object for the default collation.
var characterGroupings = new Windows.Globalization.Collation.CharacterGroupings();
// Get the number of CharacterGrouping objects.
var size = characterGroupings.size;
if (size > 0) {
    // Get the first characterGrouping.
    var characterGrouping = characterGroupings.getAt(0);
    // Get the first item in this characterGrouping.
    var first = characterGrouping.first;
    // Get the label of the first item in this characterGrouping.
    var label = characterGrouping.label;
}
```



## -see-also