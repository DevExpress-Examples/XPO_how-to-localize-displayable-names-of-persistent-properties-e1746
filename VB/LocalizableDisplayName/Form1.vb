Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace LocalizableDisplayName
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			gridControl1.DataSource = New XPCollection(Of Product)(XpoDefault.Session)
		End Sub
	End Class
End Namespace