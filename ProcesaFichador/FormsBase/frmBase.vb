Imports DevExpress.XtraEditors

Public Class frmBase
    Inherits XtraForm

    Friend mflgCancelClose As Boolean = False
    Public Property CancelClose As Boolean
        Get
            Return mflgCancelClose
        End Get
        Set(value As Boolean)
            mflgCancelClose = value
        End Set
    End Property

End Class