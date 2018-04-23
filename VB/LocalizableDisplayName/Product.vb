Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports System.ComponentModel

Public Class Product
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Private _Name As String
		<DXDisplayName(GetType(Product), "PropertyNamesRes", "Product_Name", "neutral name")> _
		Public Property Name() As String
			Get
				Return _Name
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", _Name, value)
			End Set
		End Property

		Private _Price As Decimal
		<DXDisplayName(GetType(Product), "PropertyNamesRes", "Product_Price", "neutral price")> _
		Public Property Price() As Decimal
			Get
				Return _Price
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue("Price", _Price, value)
			End Set
		End Property
End Class
