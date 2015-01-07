<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BanPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pctBan1 = New System.Windows.Forms.Panel()
        Me.pctBan2 = New System.Windows.Forms.Panel()
        Me.pctBan3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pctBan2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pctBan1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pctBan3, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(232, 64)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'pctBan1
        '
        Me.pctBan1.Location = New System.Drawing.Point(3, 3)
        Me.pctBan1.Name = "pctBan1"
        Me.pctBan1.Size = New System.Drawing.Size(58, 58)
        Me.pctBan1.TabIndex = 0
        '
        'pctBan2
        '
        Me.pctBan2.Location = New System.Drawing.Point(87, 3)
        Me.pctBan2.Name = "pctBan2"
        Me.pctBan2.Size = New System.Drawing.Size(58, 58)
        Me.pctBan2.TabIndex = 1
        '
        'pctBan3
        '
        Me.pctBan3.Location = New System.Drawing.Point(171, 3)
        Me.pctBan3.Name = "pctBan3"
        Me.pctBan3.Size = New System.Drawing.Size(58, 58)
        Me.pctBan3.TabIndex = 1
        '
        'BanPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "BanPanel"
        Me.Size = New System.Drawing.Size(232, 64)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pctBan2 As System.Windows.Forms.Panel
    Friend WithEvents pctBan1 As System.Windows.Forms.Panel
    Friend WithEvents pctBan3 As System.Windows.Forms.Panel

End Class
