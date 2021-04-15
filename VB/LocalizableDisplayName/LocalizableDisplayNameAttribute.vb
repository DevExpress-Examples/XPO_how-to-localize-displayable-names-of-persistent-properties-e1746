Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection
Imports System.Resources

Public Class LocalizableDisplayNameAttribute
    Inherits DisplayNameAttribute
    Public Shared GlobalResourceCulture As CultureInfo = Nothing
    Private Shared ReadOnly ResourceManagers As New Dictionary(Of Type, ResourceManager)()
    Private ReadOnly resXGeneratedClass As Type
    Public Sub New(ByVal resXGeneratedClass As Type, ByVal stringName As String)
        MyBase.New(stringName)
        If Not ResourceManagers.ContainsKey(resXGeneratedClass) Then
            Dim resourceManager As ResourceManager = CType(resXGeneratedClass.InvokeMember("ResourceManager", BindingFlags.Static Or BindingFlags.NonPublic Or BindingFlags.GetProperty, Nothing, Nothing, Nothing), ResourceManager)
            ResourceManagers.Add(resXGeneratedClass, resourceManager)
        End If
        Me.resXGeneratedClass = resXGeneratedClass
    End Sub
    Public Overrides ReadOnly Property DisplayName As String
        Get
            Dim resourceManager As ResourceManager = ResourceManagers(resXGeneratedClass)
            Return resourceManager.GetString(MyBase.DisplayName, GlobalResourceCulture)
        End Get
    End Property
End Class
