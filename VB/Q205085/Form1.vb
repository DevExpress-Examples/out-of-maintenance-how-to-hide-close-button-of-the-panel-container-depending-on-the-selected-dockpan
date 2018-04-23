Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace Q205085
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub OnDockManagerRegisterDockPanel(ByVal sender As Object, ByVal e As DockPanelEventArgs) Handles dockManager1.RegisterDockPanel
			If e.Panel.Name.Contains("panelContainer") Then
				AddHandler e.Panel.ActiveChildChanged, AddressOf OnDockPanelActiveChildChanged
				AdjustCloseButtonVisibility(e.Panel)
			End If
		End Sub

		Private Sub OnDockPanelActiveChildChanged(ByVal sender As Object, ByVal e As DockPanelEventArgs)
			AdjustCloseButtonVisibility(e.Panel)
		End Sub

		Private Shared Sub AdjustCloseButtonVisibility(ByVal panel As DockPanel)
			panel.Options.ShowCloseButton = panel.ActiveChild.Options.ShowCloseButton
		End Sub
	End Class
End Namespace