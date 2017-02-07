Namespace Global.Microsoft.UI.Xaml.Controls

    ' TEMPORARY comments denote areas where this has been written in simulated base class form
    ' because of runtime issues that prevent custom base classes

    ' TEMPORARY
    Public Interface ISimulatedSubclass
        Function DetermineViewStateName(viewState As ApplicationViewState) As String
    End Interface

    Public Class LayoutAwarePage
        ' Inherits Page // TEMPORARY

        Private _simulatedMe As Control ' TEMPORARY
        Private _layoutAwareControls As List(Of Control)

        ' TEMPORARY - this entire constructor will be eliminated
        Public Sub New(simulatedMe As Control)
            _simulatedMe = simulatedMe
            AddHandler _simulatedMe.Loaded, AddressOf StartLayoutUpdates
            AddHandler _simulatedMe.Unloaded, AddressOf StopLayoutUpdates
        End Sub

        Public Sub StartLayoutUpdates(sender As Object, e As RoutedEventArgs) ' TEMPORARY - will add Handles Me.Loaded
            Dim control = TryCast(sender, Control)
            If control Is Nothing Then Return

            If _layoutAwareControls Is Nothing Then
                AddHandler ApplicationView.GetForCurrentView().ViewStateChanged, AddressOf ViewStateChanged
                _layoutAwareControls = New List(Of Control)
            End If
            _layoutAwareControls.Add(control)
            VisualStateManager.GoToState(control, DetermineViewStateName(ApplicationView.Value), False)
        End Sub

        Public Sub StopLayoutUpdates(sender As Object, e As RoutedEventArgs) ' TEMPORARY - will add Handles Me.Unloaded
            Dim control = TryCast(sender, Control)
            If control Is Nothing OrElse _layoutAwareControls Is Nothing Then Return

            _layoutAwareControls.Remove(control)
            If _layoutAwareControls.Count = 0
                _layoutAwareControls = Nothing
                RemoveHandler ApplicationView.GetForCurrentView().ViewStateChanged, AddressOf ViewStateChanged
            End If
        End Sub

        Private Sub ViewStateChanged(sender As ApplicationView, e As ApplicationViewStateChangedEventArgs)
            If _layoutAwareControls IsNot Nothing Then
                Dim viewState As ApplicationViewState
                If e Is Nothing Then
                    viewState = ApplicationView.Value
                Else
                    viewState = e.ViewState
                End If
                Dim viewStateName = DetermineViewStateName(viewState)
                For Each layoutAwareControl In _layoutAwareControls
                    VisualStateManager.GoToState(layoutAwareControl, viewStateName, False)
                Next
            End If
        End Sub

        ' Designed to be overridden for custom state management
        Protected Overridable Function DetermineViewStateName(viewState As ApplicationViewState) As String
            Dim overloaded = TryCast(_simulatedMe, ISimulatedSubclass)
            If overloaded IsNot Nothing Then Return overloaded.DetermineViewStateName(viewState)
            Return DetermineDefaultViewStateName(viewState)
        End Function

        Public Function DetermineDefaultViewStateName(viewState As ApplicationViewState) As String
            If viewState = ApplicationViewState.FullScreenPortrait Then Return "Portrait"
            If viewState = ApplicationViewState.Snapped Then Return "Snapped"
            If viewState = ApplicationViewState.Filled Then Return "Filled"
            Return "FullScreen"
        End Function

        Public Sub InvalidateViewState()
            ViewStateChanged(Nothing, Nothing)
        End Sub

    End Class

End Namespace
