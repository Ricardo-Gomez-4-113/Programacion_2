Imports System
Imports System.Windows.Forms

Public Class MyPB
    Inherits ProgressBar
    Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H4

            Return cp
        End Get
    End Property

End Class

