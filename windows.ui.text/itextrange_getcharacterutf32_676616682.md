---
-api-id: M:Windows.UI.Text.ITextRange.GetCharacterUtf32(System.UInt32@,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void GetCharacterUtf32(System.UInt32 value, System.Int32 offset)
-->

# Windows.UI.Text.ITextRange.GetCharacterUtf32

## -description
Retrieves the Unicode Transformation Format (UTF)-32 character code of the character at the specified offset from the end of the text range.



## -parameters
### -param value
The character value.

### -param offset
The offset from the end of the text range.<table>
   <tr><th>If *offset* is</th><th>The method returns this character</th></tr>
   <tr><td>0</td><td>The character at the end of the range</td></tr>
   <tr><td>in the middle of a surrogate pair</td><td>The corresponding UTF-32 character</td></tr>
</table>

## -remarks
This method differs from [ITextRange.Character](itextrange_character.md) in the following ways: 
+ It returns the Unicode Transformation Format (UTF)-32 character code for a Unicode Transformation Format (UTF)-16 surrogate pair instead of the pair’s lead code (see Sections 3.8 and 3.9 and Table 3-5 in [The Unicode Standard](https://www.unicode.org/versions/Unicode6.0.0/) for explanations of this notation).
+ It gets the code for the character at the specified offset from the end of the text range instead of the character at the start of the range.


If you try to retrieve a character that is before the start of the story or at the end of the story, *value* is set to the character code 0.

If *offset* is 0, this method retrieves the character at the end of the range.

If *offset* is in the middle of a surrogate pair, this method retrieves the corresponding Unicode Transformation Format (UTF)-32 character.

## -examples

## -see-also
[ITextRange.Character](itextrange_character.md)
