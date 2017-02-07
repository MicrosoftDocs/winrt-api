---
-api-id: T:Windows.Globalization.Collation.CharacterGrouping
-api-type: winrt class
---

<!-- Class syntax.
public class CharacterGrouping : Windows.Globalization.Collation.ICharacterGrouping
-->

# Windows.Globalization.Collation.CharacterGrouping

## -description
A container for character group information. Characters are grouped in an index that enables an application to determine where the grouping boundaries are.

## -remarks

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