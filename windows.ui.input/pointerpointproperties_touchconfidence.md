---
-api-id: P:Windows.UI.Input.PointerPointProperties.TouchConfidence
-api-type: winrt property
---

<!-- Property syntax
public bool TouchConfidence { get; }
-->

# Windows.UI.Input.PointerPointProperties.TouchConfidence

## -description
Gets a value that indicates whether the pointer device rejected the touch contact.

## -property-value
True if the touch contact was accepted; otherwise false.

## -remarks
A device rejects accidental touches and reports this information through the Human Interface Device (HID) confidence usage (see note above). [TouchConfidence](pointerpointproperties_touchconfidence.md) is set through the value of this usage.

The confidence usage helps improve the accuracy and reliability of accidental touch rejection. (In addition to confidence, additional heuristics are applied to the touch input stream to improve the accuracy of accidental touch rejection.)

Touch input is most often rejected due to palm detection or through input arbitration (such as when pen/stylus proximity overrides touch input).

## -examples

## -see-also
