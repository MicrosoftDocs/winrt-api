---
-api-id: T:Windows.UI.Input.Inking.Analysis.InkAnalysisNodeKind
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum InkAnalysisNodeKind : int {
    InkBullet = 6
    InkDrawing = 7
    InkWord = 5
    Line = 4
    ListItem = 8
    Paragraph = 3
    Root = 1
    UnclassifiedInk = 0
    WritingRegion = 2
}
-->

# Windows.UI.Input.Inking.Analysis.InkAnalysisNodeKind

## -description
Specifies the types of nodes (or categories of ink input) that ink analysis can differentiate and recognize.

## -enum-fields

## -field WritingRegion:2
Node is for a generic writing region.

## -field UnclassifiedInk:0
Node is for unrecognized ink.

## -field Root:1
Node is the first, or topmost, in the collection of nodes.

## -field Paragraph:3
Node is for a paragraph of text.

## -field ListItem:8
Node is for a list item.

## -field Line:4
Node is for a single line of text.

## -field InkWord:5
Node is for a single word of text.

## -field InkDrawing:7
Node is for one of the recognized shapes specified in [InkAnalysisDrawingKind](inkanalysisdrawingkind.md).

## -field InkBullet:6
Node is for a list item bullet.

## -remarks

## -see-also

[InkAnalysisNode.Kind](inkanalysisnode_kind.md)

## -examples

