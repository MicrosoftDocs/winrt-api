Namespace Global.Microsoft.UI.Xaml.Controls

    Public NotInheritable Class RichTextColumns
        Inherits Panel

        Public Shared ReadOnly RichTextContentProperty As DependencyProperty =
            DependencyProperty.Register("RichTextContent", GetType(RichTextBlock),
            GetType(RichTextColumns), New PropertyMetadata(Nothing, AddressOf ResetOverflowLayout))
        Public Shared ReadOnly ColumnTemplateProperty As DependencyProperty =
            DependencyProperty.Register("ColumnTemplate", GetType(DataTemplate),
            GetType(RichTextColumns), New PropertyMetadata(Nothing, AddressOf ResetOverflowLayout))

        Public Property RichTextContent As RichTextBlock
            Get
                Return DirectCast(GetValue(RichTextContentProperty), RichTextBlock)
            End Get
            Set
                SetValue(RichTextContentProperty, Value)
            End Set
        End Property

        Public Property ColumnTemplate As DataTemplate
            Get
                Return DirectCast(GetValue(ColumnTemplateProperty), DataTemplate)
            End Get
            Set
                SetValue(ColumnTemplateProperty, Value)
            End Set
        End Property

        Public Shared Sub ResetOverflowLayout(d As DependencyObject, e As DependencyPropertyChangedEventArgs)
            Dim target = TryCast(d, RichTextColumns)
            If target IsNot Nothing Then
                target.InvalidateMeasure()
            End If
        End Sub

        Protected Overrides Function MeasureOverride(availableSize As Size) As Size
            Children.Clear()
            If (RichTextContent Is Nothing) Then Return New Size(0, 0)

            Children.Add(RichTextContent)
            RichTextContent.OverflowContentTarget = Nothing
            RichTextContent.Measure(availableSize)
            Dim maxWidth = RichTextContent.DesiredSize.Width
            Dim maxHeight = RichTextContent.DesiredSize.Height
            Dim hasOverflow = RichTextContent.HasOverflowContent

            If hasOverflow AndAlso ColumnTemplate IsNot Nothing
                ' Create necessary overflow blocks
                Dim previousOverflow As RichTextBlockOverflow = Nothing
                While hasOverflow AndAlso maxWidth < availableSize.Width
                    Dim overflow As RichTextBlockOverflow = DirectCast(ColumnTemplate.LoadContent(), RichTextBlockOverflow)
                    Children.Add(overflow)

                    ' Establish overflow from the previous block
                    If previousOverflow Is Nothing
                        RichTextContent.OverflowContentTarget = overflow
                    Else
                        previousOverflow.OverflowContentTarget = overflow
                    End If
                    overflow.Measure(New Size(availableSize.Width - maxWidth, availableSize.Height))
                    maxWidth += overflow.DesiredSize.Width
                    maxHeight = Math.Max(maxHeight, overflow.DesiredSize.Height)
                    hasOverflow = overflow.HasOverflowContent
                    previousOverflow = overflow
                End While
            End If
            Return New Size(maxWidth, maxHeight)
        End Function

        Protected Overrides Function ArrangeOverride(finalSize As Size) As Size
            Dim maxWidth As Double = 0
            Dim maxHeight As Double = 0
            For Each child In Children
                child.Arrange(New Rect(maxWidth, 0, child.DesiredSize.Width, finalSize.Height))
                maxWidth += child.DesiredSize.Width
                maxHeight = Math.Max(maxHeight, child.DesiredSize.Height)
            Next
        End Function

    End Class

End Namespace
