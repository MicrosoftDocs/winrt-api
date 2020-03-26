---
-api-id: T:Windows.Services.TargetedContent.TargetedContentInteraction
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum TargetedContentInteraction : int 
-->

# Windows.Services.TargetedContent.TargetedContentInteraction

## -description

Defines the types of interaction values supported by each [TargetedContentItem](targetedcontentitem.md) object in a [TargetedContentContainer](targetedcontentcontainer.md).

## -enum-fields

### -field Opportunity:12

Interaction indicates an opportunity.

### -field Like:3

A like action.

### -field Dislike:4

A dislike action.

### -field Conversion:11

A conversion action, such as when a user becomes a paying customer.

### -field Canceled:10

A cancel action.

### -field ClickThrough:1

A click-through action, such as when a user clicks on a specific link.

### -field Ineligible:6

Interaction indicates ineligibility.

### -field Impression:0

An impression, such as any time a user opens an app or website.

> [!NOTE]
> Different apps can have different rules for reporting impressions.

### -field Hover:2

A hover action over the item.

### -field Dismiss:5

A dismiss action.

### -field Defer:9

A defer action.

### -field Decline:8

A decline action.

### -field Accept:7

An accept action.

## -remarks

## -see-also

[TargetedContentCollection.ReportInteraction](targetedcontentcollection_reportinteraction_1054998729.md), [TargetedContentItem.ReportInteraction](targetedcontentitem_reportinteraction_1054998729.md), [TargetedContentContainer.Content](targetedcontentcontainer_content.md)

## -examples

## -capabilities

secondaryAuthenticationFactor
                        