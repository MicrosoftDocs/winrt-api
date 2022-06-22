---
-api-id: T:Windows.UI.Xaml.Automation.Peers.RichTextBlockAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class RichTextBlockAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IRichTextBlockAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.RichTextBlockAutomationPeer

## -description
Exposes [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) types to Microsoft UI Automation.


## -remarks
The Windows Runtime  [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) class creates a new RichTextBlockAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) is sealed, so the normal scenario of deriving from the [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) class and its existing peer isn't applicable to RichTextBlockAutomationPeer.

### Default peer implementation and overrides in **RichTextBlockAutomationPeer**

RichTextBlockAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports pattern support for [TextPattern](/windows/desktop/api/uiautomationclient/nn-uiautomationclient-iuiautomationtextpattern), but see "TextPattern support" in this topic for more info.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "RichTextBlock".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Text](automationcontroltype.md).
+ [GetName](automationpeer_getname_1386609741.md) returns a plain-text representation of the [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) text content from [Blocks](../windows.ui.xaml.controls/richtextblock_blocks.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns a value based on the template parent. If there is a template parent then it returns **true**, otherwise the value is **false**. The scenario here is that a templated control may have forwarded to this peer for text support, but normally a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) by itself isn't a full-fledged control.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### TextPattern support

 RichTextBlockAutomationPeer supports the **TextPattern**  Microsoft UI Automation pattern. The support for this pattern is implemented as native code by the peer, so you won't see public API for the RichTextBlockAutomationPeer peer class that exposes the pattern implementation for extension. And you won't see [ITextRangeProvider](../windows.ui.xaml.automation.provider/itextrangeprovider.md) and the similar managed interfaces in the RichTextBlockAutomationPeer inheritance. But Microsoft UI Automation clients can use the **TextPattern** pattern implemented by this peer and call its native API surface.

Here are some specifics of the [TextPattern](/windows/desktop/api/uiautomationclient/nn-uiautomationclient-iuiautomationtextpattern) implementation in RichTextBlockAutomationPeer: 
+ [Move](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-move), [MoveEndpointByUnit](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-moveendpointbyunit) and [ExpandToEnclosingUnit](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-expandtoenclosingunit) are supported for all [TextUnit](/windows/desktop/api/uiautomationcore/ne-uiautomationcore-textunit) units including the **Format** value.
+ [GetAttributeValue](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-getattributevalue) returns results within ranges for these text attributes: **UIA_FontNameAttributeId**, **UIA_FontSizeAttributeId**, **UIA_FontWeightAttributeId**, **UIA_ForegroundColorAttributeId**, **UIA_CultureAttributeId**, **UIA_IsHiddenAttributeId**, **UIA_IsItalicAttributeId**, **UIA_IsReadOnlyAttributeId**, **UIA_CapStyleAttributeId**, **UIA_HorizontalTextAlignmentAttributeId**, **UIA_IndentationFirstLineAttributeId**, **UIA_IndentationLeadingAttributeId**, **UIA_IsSuperscriptAttributeId**, **UIA_IsSubscriptAttributeId**, **UIA_MarginBottomAttributeId**, **UIA_MarginLeadingAttributeId**, **UIA_MarginTopAttributeId**, **UIA_MarginTrailingAttributeId**.
+ For the [Move](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-move), [MoveEndpointByUnit](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-moveendpointbyunit) and [ExpandToEnclosingUnit](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-expandtoenclosingunit)  API when using the **Format** value, a format change is defined as a change within a range in any of the supported text attributes listed above.
+ [ScrollIntoView](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-scrollintoview) is exposed in the pattern, but can only result in a behavior if the owner control is contained within a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md). Otherwise a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) doesn't have its own scrolling behavior. If the [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) does have a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) parent, then the [ScrollIntoView](/windows/desktop/api/uiautomationcore/nf-uiautomationcore-itextrangeprovider-scrollintoview) call fires a system event that requests the parent [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) to scroll. The *alignToTop* value is ignored.


## -examples

## -see-also
[RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
