---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetHeadingLevel
-api-type: winrt method
---

<!-- Method syntax.
public AutomationHeadingLevel AutomationPeer.GetHeadingLevel()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetHeadingLevel

## -description
Gets the text heading level of the element that is associated with this automation peer.

## -returns
The text heading level.

## -remarks
A heading is an element that has special importance in the context of an app. Assistive Technology (AT) users should be able to quickly jump between headings. Headings have a level from 1 to 9.

![Mouse settings page in Windows Ease of Access settings](images/MouseSettings.png)

Examples of headings would be section titles within the Windows Settings app. For instance, under the **Ease of Access** -> **Mouse** page, **Pointer size**, **Pointer color**, and **Mouse keys** would be a heading of level 1.

## -see-also
[AutomationHeadingLevel](automationheadinglevel.md)

## -examples

