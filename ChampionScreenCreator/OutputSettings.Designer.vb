<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Einstellungen = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.pnlEigenschaften = New System.Windows.Forms.Panel()
        Me.cmbObjekt = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numPosX = New System.Windows.Forms.NumericUpDown()
        Me.numPosY = New System.Windows.Forms.NumericUpDown()
        Me.numWidth = New System.Windows.Forms.NumericUpDown()
        Me.numHöe = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.grpFlags = New System.Windows.Forms.GroupBox()
        Me.flpFlags = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pctWallPaper = New System.Windows.Forms.PictureBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdResetAllg = New System.Windows.Forms.Button()
        Me.txtBildPath = New System.Windows.Forms.TextBox()
        Me.cmdSelectPic = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Einstellungen.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlEigenschaften.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numPosX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPosY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHöe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFlags.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctWallPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Einstellungen)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1564, 882)
        Me.TabControl1.TabIndex = 0
        '
        'Einstellungen
        '
        Me.Einstellungen.Controls.Add(Me.cmdResetAllg)
        Me.Einstellungen.Controls.Add(Me.cmdOK)
        Me.Einstellungen.Controls.Add(Me.GroupBox1)
        Me.Einstellungen.Controls.Add(Me.grpFlags)
        Me.Einstellungen.Location = New System.Drawing.Point(4, 22)
        Me.Einstellungen.Name = "Einstellungen"
        Me.Einstellungen.Size = New System.Drawing.Size(1556, 856)
        Me.Einstellungen.TabIndex = 0
        Me.Einstellungen.Text = "Einstellungen"
        Me.Einstellungen.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1556, 856)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Anordnung"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlEdit)
        Me.SplitContainer1.Panel1MinSize = 1280
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlEigenschaften)
        Me.SplitContainer1.Size = New System.Drawing.Size(1556, 856)
        Me.SplitContainer1.SplitterDistance = 1288
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlEdit
        '
        Me.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(1288, 856)
        Me.pnlEdit.TabIndex = 0
        '
        'pnlEigenschaften
        '
        Me.pnlEigenschaften.Controls.Add(Me.cmdReset)
        Me.pnlEigenschaften.Controls.Add(Me.Button1)
        Me.pnlEigenschaften.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlEigenschaften.Controls.Add(Me.cmbObjekt)
        Me.pnlEigenschaften.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEigenschaften.Location = New System.Drawing.Point(0, 0)
        Me.pnlEigenschaften.Name = "pnlEigenschaften"
        Me.pnlEigenschaften.Size = New System.Drawing.Size(264, 856)
        Me.pnlEigenschaften.TabIndex = 0
        '
        'cmbObjekt
        '
        Me.cmbObjekt.FormattingEnabled = True
        Me.cmbObjekt.Items.AddRange(New Object() {"==== Blaues Team ====", "== Banner ==", "[Blau] Top-Lane (Banner)", "[Blau] Jungle (Banner)", "[Blau] Mid-Lane (Banner)", "[Blau] Carry (Banner)", "[Blau] Support (Banner)", "== Icons == ", "[Blau] Top-Lane (Icon)", "[Blau] Jungle (Icon)", "[Blau] Mid-Lane (Icon)", "[Blau] Carry (Icon)", "[Blau] Support (Icon)", "== Banns ==", "[Blau] 1. Bann", "[Blau] 2. Bann", "[Blau] 3. Bann", "==== Rotes Team ====", "== Banner ==", "[Rot] Top-Lane (Banner)", "[Rot] Jungle (Banner)", "[Rot] Mid-Lane (Banner)", "[Rot] Carry (Banner)", "[Rot] Support (Banner)", "== Icons ==", "[Rot] Top-Lane (Icon)", "[Rot] Jungle (Icon)", "[Rot] Mid-Lane (Icon)", "[Rot] Carry (Icon)", "[Rot] Support (Icon)", "== Banns ==", "[Rot] 1. Bann", "[Rot] 2. Bann", "[Rot] 3. Bann"})
        Me.cmbObjekt.Location = New System.Drawing.Point(0, 0)
        Me.cmbObjekt.Name = "cmbObjekt"
        Me.cmbObjekt.Size = New System.Drawing.Size(261, 21)
        Me.cmbObjekt.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.numHöe, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.numWidth, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.numPosY, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.numPosX, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(261, 118)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Position X:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position Y:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Breite:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Höhe:"
        '
        'numPosX
        '
        Me.numPosX.Location = New System.Drawing.Point(133, 3)
        Me.numPosX.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numPosX.Name = "numPosX"
        Me.numPosX.Size = New System.Drawing.Size(120, 20)
        Me.numPosX.TabIndex = 7
        '
        'numPosY
        '
        Me.numPosY.Location = New System.Drawing.Point(133, 33)
        Me.numPosY.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numPosY.Name = "numPosY"
        Me.numPosY.Size = New System.Drawing.Size(120, 20)
        Me.numPosY.TabIndex = 8
        '
        'numWidth
        '
        Me.numWidth.Location = New System.Drawing.Point(133, 63)
        Me.numWidth.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numWidth.Name = "numWidth"
        Me.numWidth.Size = New System.Drawing.Size(120, 20)
        Me.numWidth.TabIndex = 9
        '
        'numHöe
        '
        Me.numHöe.Location = New System.Drawing.Point(133, 93)
        Me.numHöe.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numHöe.Name = "numHöe"
        Me.numHöe.Size = New System.Drawing.Size(120, 20)
        Me.numHöe.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 825)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Übernehmen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(6, 825)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 23)
        Me.cmdReset.TabIndex = 3
        Me.cmdReset.Text = "Verwerfen"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'grpFlags
        '
        Me.grpFlags.Controls.Add(Me.flpFlags)
        Me.grpFlags.Location = New System.Drawing.Point(8, 3)
        Me.grpFlags.Name = "grpFlags"
        Me.grpFlags.Size = New System.Drawing.Size(166, 845)
        Me.grpFlags.TabIndex = 0
        Me.grpFlags.TabStop = False
        Me.grpFlags.Text = "Flags"
        '
        'flpFlags
        '
        Me.flpFlags.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpFlags.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpFlags.Location = New System.Drawing.Point(3, 16)
        Me.flpFlags.Name = "flpFlags"
        Me.flpFlags.Size = New System.Drawing.Size(160, 826)
        Me.flpFlags.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSelectPic)
        Me.GroupBox1.Controls.Add(Me.txtBildPath)
        Me.GroupBox1.Controls.Add(Me.pctWallPaper)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1233, 845)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hintergrund-Bild"
        '
        'pctWallPaper
        '
        Me.pctWallPaper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pctWallPaper.Location = New System.Drawing.Point(155, 19)
        Me.pctWallPaper.Name = "pctWallPaper"
        Me.pctWallPaper.Size = New System.Drawing.Size(922, 507)
        Me.pctWallPaper.TabIndex = 0
        Me.pctWallPaper.TabStop = False
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(1419, 3)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(129, 37)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "Übernehmen"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdResetAllg
        '
        Me.cmdResetAllg.Location = New System.Drawing.Point(1419, 46)
        Me.cmdResetAllg.Name = "cmdResetAllg"
        Me.cmdResetAllg.Size = New System.Drawing.Size(129, 37)
        Me.cmdResetAllg.TabIndex = 2
        Me.cmdResetAllg.Text = "Verwerfen"
        Me.cmdResetAllg.UseVisualStyleBackColor = True
        '
        'txtBildPath
        '
        Me.txtBildPath.Location = New System.Drawing.Point(155, 533)
        Me.txtBildPath.Name = "txtBildPath"
        Me.txtBildPath.Size = New System.Drawing.Size(841, 20)
        Me.txtBildPath.TabIndex = 1
        '
        'cmdSelectPic
        '
        Me.cmdSelectPic.Location = New System.Drawing.Point(1002, 530)
        Me.cmdSelectPic.Name = "cmdSelectPic"
        Me.cmdSelectPic.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelectPic.TabIndex = 2
        Me.cmdSelectPic.Text = ". . ."
        Me.cmdSelectPic.UseVisualStyleBackColor = True
        '
        'OutputSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1564, 882)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "OutputSettings"
        Me.Text = "Ausgabe-Optionen"
        Me.TabControl1.ResumeLayout(False)
        Me.Einstellungen.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlEigenschaften.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numPosX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPosY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHöe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFlags.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctWallPaper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Einstellungen As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlEdit As System.Windows.Forms.Panel
    Friend WithEvents pnlEigenschaften As System.Windows.Forms.Panel
    Friend WithEvents cmbObjekt As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents numHöe As System.Windows.Forms.NumericUpDown
    Friend WithEvents numWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPosY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numPosX As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpFlags As System.Windows.Forms.GroupBox
    Friend WithEvents flpFlags As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pctWallPaper As System.Windows.Forms.PictureBox
    Friend WithEvents cmdResetAllg As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdSelectPic As System.Windows.Forms.Button
    Friend WithEvents txtBildPath As System.Windows.Forms.TextBox
End Class
