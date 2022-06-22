---
-api-id: T:Windows.UI.Text.LinkType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.LinkType : int
-->

# LinkType

## -description
Indicates the link type of a range of text.



## -enum-fields
### -field Undefined:0
A mix of link and nonlink attributes.

### -field NotALink:1
Not a link.

### -field ClientLink:2
A link specified by the client; that is, not an autolink or a friendly-name link.

### -field FriendlyLinkName:3
The name part of a friendly-name link. The name is the part that is displayed.

### -field FriendlyLinkAddress:4
The address Uniform Resource Identifier (URI) part of friendly-name link. The address it the part that is sent when the user clicks the name.

### -field AutoLink:5
A Uniform Resource Identifier (URI) that is automatically recognized.

### -field AutoLinkEmail:6
An email address that is automatically recognized.

### -field AutoLinkPhone:7
A phone number that is automatically recognized.

### -field AutoLinkPath:8
A file name, including the full path, that is automatically recognized.


## -remarks

## -examples

## -see-also
[ITextCharacterFormat.LinkType](itextcharacterformat_linktype.md)
