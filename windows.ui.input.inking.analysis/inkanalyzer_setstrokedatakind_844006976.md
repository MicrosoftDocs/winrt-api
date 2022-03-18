---
-api-id: M:Windows.UI.Input.Inking.Analysis.InkAnalyzer.SetStrokeDataKind(System.UInt32,Windows.UI.Input.Inking.Analysis.InkAnalysisStrokeKind)
-api-type: winrt method
---

<!-- Method syntax.
public void InkAnalyzer.SetStrokeDataKind(UInt32 strokeId, InkAnalysisStrokeKind strokeKind)
-->

# Windows.UI.Input.Inking.Analysis.InkAnalyzer.SetStrokeDataKind


## -description

Sets the ink analysis category for the [InkAnalysisNode](inkanalysisnode.md) associated with the ink stroke.

## -parameters

### -param strokeId

The unique identifier for the ink stroke being categorized.

### -param strokeKind

The [InkAnalysisStrokeKind](inkanalysisstrokekind.md) category to assign to the [InkAnalysisNode](inkanalysisnode.md).

## -remarks

Use [**SetStrokeDataKind**](/en-us/uwp/api/windows.ui.input.inking.analysis.inkanalyzer.setstrokedatakind) to specify the type of ink stroke you're interested in analyzing: text (including document structure and bullet lists), drawing (including shape recognition), or non-specific. This can improve both efficiency and recognition accuracy.

## -see-also

## -examples

