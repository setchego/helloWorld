<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOUT = New System.Windows.Forms.Button()
        Me.btnDBF = New System.Windows.Forms.Button()
        Me.txtOUT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDBF = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chk557 = New System.Windows.Forms.CheckBox()
        Me.chkEico = New System.Windows.Forms.CheckBox()
        Me.chkCopppel = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOUT)
        Me.GroupBox1.Controls.Add(Me.btnDBF)
        Me.GroupBox1.Controls.Add(Me.txtOUT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDBF)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnOUT
        '
        Me.btnOUT.Location = New System.Drawing.Point(318, 42)
        Me.btnOUT.Name = "btnOUT"
        Me.btnOUT.Size = New System.Drawing.Size(47, 23)
        Me.btnOUT.TabIndex = 5
        Me.btnOUT.Text = "..."
        Me.btnOUT.UseVisualStyleBackColor = True
        '
        'btnDBF
        '
        Me.btnDBF.Location = New System.Drawing.Point(318, 13)
        Me.btnDBF.Name = "btnDBF"
        Me.btnDBF.Size = New System.Drawing.Size(47, 23)
        Me.btnDBF.TabIndex = 4
        Me.btnDBF.Text = "..."
        Me.btnDBF.UseVisualStyleBackColor = True
        '
        'txtOUT
        '
        Me.txtOUT.Location = New System.Drawing.Point(79, 43)
        Me.txtOUT.Name = "txtOUT"
        Me.txtOUT.Size = New System.Drawing.Size(232, 20)
        Me.txtOUT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archivo"
        '
        'txtDBF
        '
        Me.txtDBF.Location = New System.Drawing.Point(79, 14)
        Me.txtDBF.Name = "txtDBF"
        Me.txtDBF.Size = New System.Drawing.Size(232, 20)
        Me.txtDBF.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Location = New System.Drawing.Point(-9, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 54)
        Me.Panel1.TabIndex = 1
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.Control
        Me.btnExport.Location = New System.Drawing.Point(311, 5)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chk557
        '
        Me.chk557.AutoSize = True
        Me.chk557.Location = New System.Drawing.Point(7, 82)
        Me.chk557.Name = "chk557"
        Me.chk557.Size = New System.Drawing.Size(67, 17)
        Me.chk557.TabIndex = 2
        Me.chk557.Text = "557/558"
        Me.chk557.UseVisualStyleBackColor = True
        '
        'chkEico
        '
        Me.chkEico.AutoSize = True
        Me.chkEico.Location = New System.Drawing.Point(80, 82)
        Me.chkEico.Name = "chkEico"
        Me.chkEico.Size = New System.Drawing.Size(65, 17)
        Me.chkEico.TabIndex = 3
        Me.chkEico.Text = "EICOBA"
        Me.chkEico.UseVisualStyleBackColor = True
        '
        'chkCopppel
        '
        Me.chkCopppel.AutoSize = True
        Me.chkCopppel.Location = New System.Drawing.Point(152, 83)
        Me.chkCopppel.Name = "chkCopppel"
        Me.chkCopppel.Size = New System.Drawing.Size(68, 17)
        Me.chkCopppel.TabIndex = 4
        Me.chkCopppel.Text = "COPPEL"
        Me.chkCopppel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 136)
        Me.Controls.Add(Me.chkCopppel)
        Me.Controls.Add(Me.chkEico)
        Me.Controls.Add(Me.chk557)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Exportar desde Archivo de morosos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOUT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDBF As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOUT As System.Windows.Forms.Button
    Friend WithEvents btnDBF As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chk557 As System.Windows.Forms.CheckBox
    Friend WithEvents chkEico As System.Windows.Forms.CheckBox
    Friend WithEvents chkCopppel As System.Windows.Forms.CheckBox

End Class
