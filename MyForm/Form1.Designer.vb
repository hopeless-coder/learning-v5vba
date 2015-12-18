<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirst
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lstBxSearch = New System.Windows.Forms.ListBox()
        Me.lstBxResult = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trViewNodes = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(23, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(263, 20)
        Me.txtSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnSearch.Location = New System.Drawing.Point(305, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 20)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstBxSearch
        '
        Me.lstBxSearch.FormattingEnabled = True
        Me.lstBxSearch.Location = New System.Drawing.Point(23, 89)
        Me.lstBxSearch.Name = "lstBxSearch"
        Me.lstBxSearch.Size = New System.Drawing.Size(134, 147)
        Me.lstBxSearch.TabIndex = 2
        '
        'lstBxResult
        '
        Me.lstBxResult.FormattingEnabled = True
        Me.lstBxResult.Location = New System.Drawing.Point(202, 89)
        Me.lstBxResult.Name = "lstBxResult"
        Me.lstBxResult.Size = New System.Drawing.Size(120, 147)
        Me.lstBxResult.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(49, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(229, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search History"
        '
        'trViewNodes
        '
        Me.trViewNodes.Location = New System.Drawing.Point(359, 89)
        Me.trViewNodes.Name = "trViewNodes"
        Me.trViewNodes.Size = New System.Drawing.Size(168, 147)
        Me.trViewNodes.TabIndex = 6
        '
        'frmFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(614, 295)
        Me.Controls.Add(Me.trViewNodes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBxResult)
        Me.Controls.Add(Me.lstBxSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmFirst"
        Me.Text = "My Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lstBxSearch As System.Windows.Forms.ListBox
    Friend WithEvents lstBxResult As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trViewNodes As System.Windows.Forms.TreeView

End Class
