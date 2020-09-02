---
-api-id: T:Windows.UI.Input.Inking.Analysis.InkAnalysisStrokeKind
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum InkAnalysisStrokeKind : int {
	Auto = 0
	Drawing = 2
	Writing = 1
}
-->

# Windows.UI.Input.Inking.Analysis.InkAnalysisStrokeKind

## -description

Specifies the types of ink strokes that can be recognized by the ink analysis process.

## -enum-fields

## -field Writing:1

Indicates a handwriting ink stroke.

## -field Drawing:2

Indicates a non-handwriting ink stroke.

## -field Auto:0

Indicates a non-specific ink stroke.

## -remarks

Use InkAnalysisStrokeKind with the [**SetStrokeDataKind**](/en-us/uwp/api/windows.ui.input.inking.analysis.inkanalyzer.setstrokedatakind) method to specify the type of ink stroke you're interested in analyzing: text (including document structure and bullet lists), drawing (including shape recognition), or non-specific. This can improve both efficiency and recognition accuracy.

## -see-also

[SetStrokeDataKind](inkanalyzer_setstrokedatakind_844006976.md)

## -examples

