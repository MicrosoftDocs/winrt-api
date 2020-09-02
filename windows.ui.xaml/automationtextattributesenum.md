---
-api-id: T:Windows.UI.Xaml.AutomationTextAttributesEnum
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.AutomationTextAttributesEnum : int
-->

# AutomationTextAttributesEnum

## -description
Defines constants that identify text attributes of a Microsoft UI Automation text range.

## -enum-fields
### -field AnimationStyleAttribute:40000
Identifies the **AnimationStyle** text attribute, which specifies the type of animation applied to the text. This attribute is specified as a value of the [AutomationAnimationStyle](../windows.ui.xaml.automation/automationanimationstyle.md) enumeration.

### -field BackgroundColorAttribute:40001
Identifies the **BackgroundColor** text attribute, which specifies the background color of the text.

### -field BulletStyleAttribute:40002
Identifies the **BulletStyle** text attribute, which specifies the style of bullets used in the text range. This attribute is specified as a value of the [AutomationBulletStyle](../windows.ui.xaml.automation/automationbulletstyle.md) enumeration.

### -field CapStyleAttribute:40003
Identifies the **CapStyle** text attribute, which specifies the capitalization style for the text.

### -field CultureAttribute:40004
Identifies the **Culture** text attribute, which specifies the locale of the text by locale identifier (LCID).

### -field FontNameAttribute:40005
Identifies the **FontName** text attribute, which specifies the name of the font. Examples: "Arial Black"; "Arial Narrow". The font name string is not localized.

### -field FontSizeAttribute:40006
Identifies the **FontSize** text attribute, which specifies the point size of the font.

### -field FontWeightAttribute:40007
Identifies the **FontWeight** text attribute, which specifies the relative stroke, thickness, or boldness of the font.

### -field ForegroundColorAttribute:40008
Identifies the **ForegroundColor** text attribute, which specifies the foreground color of the text.

### -field HorizontalTextAlignmentAttribute:40009
Identifies the **HorizontalTextAlignment** text attribute, which specifies how the text is aligned horizontally.

### -field IndentationFirstLineAttribute:40010
Identifies the **IndentationFirstLine** text attribute, which specifies how far, in points, to indent the first line of a paragraph.

### -field IndentationLeadingAttribute:40011
Identifies the **IndentationLeading** text attribute, which specifies the leading indentation, in points.

### -field IndentationTrailingAttribute:40012
Identifies the **IndentationTrailing** text attribute, which specifies the trailing indentation, in points.

### -field IsHiddenAttribute:40013
Identifies the **IsHidden** text attribute, which indicates whether the text is hidden (**true**) or visible (**false**).

### -field IsItalicAttribute:40014
Identifies the **IsItalic** text attribute, which indicates whether the text is italic (**true**) or not (**false**).

### -field IsReadOnlyAttribute:40015
Identifies the **IsReadOnly** text attribute, which indicates whether the text is read-only (**true**) or can be modified (**false**).

### -field IsSubscriptAttribute:40016
Identifies the **IsSubscript** text attribute, which indicates whether the text is subscript (**true**) or not (**false**).

### -field IsSuperscriptAttribute:40017
Identifies the **IsSuperscript** text attribute, which indicates whether the text is subscript (**true**) or not (**false**).

### -field MarginBottomAttribute:40018
Identifies the **MarginBottom** text attribute, which specifies the size, in points, of the bottom margin applied to the page associated with the text range.

### -field MarginLeadingAttribute:40019
Identifies the **MarginLeading** text attribute, which specifies the size, in points, of the leading margin applied to the page associated with the text range.

### -field MarginTopAttribute:40020
Identifies the **MarginTop** text attribute, which specifies the size, in points, of the top margin applied to the page associated with the text range.

### -field MarginTrailingAttribute:40021
Identifies the **MarginTrailing** text attribute, which specifies the size, in points, of the trailing margin applied to the page associated with the text range.

### -field OutlineStylesAttribute:40022
Identifies the **OutlineStyles** text attribute, which specifies the outline style of the text. This attribute is specified as a value of the [AutomationOutlineStyles](../windows.ui.xaml.automation/automationoutlinestyles.md) enumeration.

### -field OverlineColorAttribute:40023
Identifies the **OverlineColor** text attribute, which specifies the color of the overline text decoration.

### -field OverlineStyleAttribute:40024
Identifies the **OverlineStyle** text attribute, which specifies the style of the overline text decoration. This attribute is specified as a value of the [AutomationTextDecorationLineStyle](../windows.ui.xaml.automation/automationtextdecorationlinestyle.md) enumeration.

### -field StrikethroughColorAttribute:40025
Identifies the **StrikethroughColor** text attribute, which specifies the color of the strikethrough text decoration.

### -field StrikethroughStyleAttribute:40026
Identifies the **StrikethroughStyle** text attribute, which specifies the style of the strikethrough text decoration. This attribute is specified as a value of the [AutomationTextDecorationLineStyle](../windows.ui.xaml.automation/automationtextdecorationlinestyle.md) enumeration.

### -field TabsAttribute:40027
Identifies the **Tabs** text attribute, which is an array specifying the tab stops for the text range. Each array element specifies a distance, in points, from the leading margin.

### -field TextFlowDirectionsAttribute:40028
Identifies the **TextFlowDirections** text attribute, which specifies the direction of text flow. This attribute is specified as a combination of values of the [AutomationFlowDirections](../windows.ui.xaml.automation/automationflowdirections.md) enumeration.

### -field UnderlineColorAttribute:40029
Identifies the **UnderlineColor** text attribute, which specifies the color of the underline text decoration.

### -field UnderlineStyleAttribute:40030
Identifies the **UnderlineStyle** text attribute, which specifies the style of the underline text decoration. This attribute is specified as a value of the [AutomationTextDecorationLineStyle](../windows.ui.xaml.automation/automationtextdecorationlinestyle.md) enumeration.

### -field AnnotationTypesAttribute:40031
Identifies the **AnnotationTypes** text attribute, which maintains a list of annotation type identifiers for a range of text. This attribute is specified as a value of the [AnnotationType](../windows.ui.xaml.automation/annotationtype.md) enumeration.

### -field AnnotationObjectsAttribute:40032
Identifies the **AnnotationObjects** text attribute.

### -field StyleNameAttribute:40033
Identifies the **StyleName** text attribute, which identifies the localized name of the text style in use for a text range.

### -field StyleIdAttribute:40034
Identifies the **StyleId** text attribute, which indicates the text styles in use for a text range. This attribute is specified as a value of the [AutomationStyleId](../windows.ui.xaml.automation/automationstyleid.md) enumeration.

### -field LinkAttribute:40035
Identifies the **Link** text attribute, which contains the [ITextRangeProvider](../windows.ui.xaml.automation.provider/itextrangeprovider.md) interface of the text range that is the target of an internal link in a document.

### -field IsActiveAttribute:40036
Identifies the **IsActive** text attribute, which indicates whether the control that contains the text range has the keyboard focus (**true**) or not (**false**).

### -field SelectionActiveEndAttribute:40037
Identifies the **SelectionActiveEnd** text attribute, which indicates the location of the caret relative to a text range that represents the currently selected text. This attribute is specified as a value from the [AutomationActiveEnd](../windows.ui.xaml.automation/automationactiveend.md) enumeration.

### -field CaretPositionAttribute:40038
Identifies the **CaretPosition** text attribute, which indicates whether the caret is at the beginning or the end of a line of text in the text range. This attribute is specified as a value of the [AutomationCaretPosition](../windows.ui.xaml.automation/automationcaretposition.md) enumeration.

### -field CaretBidiModeAttribute:40039
Identifies the **CaretBidiMode** text attribute, which indicates the direction of text flow in the text range. This attribute is specified as a value of the [AutomationCaretBidiMode](../windows.ui.xaml.automation/automationcaretbidimode.md) enumeration.


## -remarks
For more info, see [Text Attribute Identifiers](/windows/desktop/WinAuto/uiauto-textattribute-ids).

## -examples

## -see-also
[ITextRangeProvider.GetAttributeValue](../windows.ui.xaml.automation.provider/itextrangeprovider_getattributevalue_221990744.md), [Text Attribute Identifiers](/windows/desktop/WinAuto/uiauto-textattribute-ids)
