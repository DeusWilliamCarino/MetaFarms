<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DGMetaFarms = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtData6 = New System.Windows.Forms.TextBox()
        Me.lblInformation6 = New System.Windows.Forms.Label()
        Me.ChckBDelete = New System.Windows.Forms.CheckBox()
        Me.ChckBUpdate = New System.Windows.Forms.CheckBox()
        Me.lblInformation5 = New System.Windows.Forms.Label()
        Me.lblInformation4 = New System.Windows.Forms.Label()
        Me.lblInformation3 = New System.Windows.Forms.Label()
        Me.lblInformation2 = New System.Windows.Forms.Label()
        Me.txtData5 = New System.Windows.Forms.TextBox()
        Me.txtData4 = New System.Windows.Forms.TextBox()
        Me.txtData3 = New System.Windows.Forms.TextBox()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.lblInformation1 = New System.Windows.Forms.Label()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.CBSelectInput = New System.Windows.Forms.ComboBox()
        Me.CBSelectOutput = New System.Windows.Forms.ComboBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        CType(Me.DGMetaFarms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGMetaFarms
        '
        Me.DGMetaFarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMetaFarms.Location = New System.Drawing.Point(359, 15)
        Me.DGMetaFarms.Name = "DGMetaFarms"
        Me.DGMetaFarms.Size = New System.Drawing.Size(362, 341)
        Me.DGMetaFarms.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtData6)
        Me.GroupBox1.Controls.Add(Me.lblInformation6)
        Me.GroupBox1.Controls.Add(Me.ChckBDelete)
        Me.GroupBox1.Controls.Add(Me.ChckBUpdate)
        Me.GroupBox1.Controls.Add(Me.lblInformation5)
        Me.GroupBox1.Controls.Add(Me.lblInformation4)
        Me.GroupBox1.Controls.Add(Me.lblInformation3)
        Me.GroupBox1.Controls.Add(Me.lblInformation2)
        Me.GroupBox1.Controls.Add(Me.txtData5)
        Me.GroupBox1.Controls.Add(Me.txtData4)
        Me.GroupBox1.Controls.Add(Me.txtData3)
        Me.GroupBox1.Controls.Add(Me.txtData2)
        Me.GroupBox1.Controls.Add(Me.lblInformation1)
        Me.GroupBox1.Controls.Add(Me.txtData1)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("OCR A Extended", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 280)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Metafarms Info"
        '
        'txtData6
        '
        Me.txtData6.Location = New System.Drawing.Point(235, 197)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(100, 28)
        Me.txtData6.TabIndex = 16
        '
        'lblInformation6
        '
        Me.lblInformation6.AutoSize = True
        Me.lblInformation6.Location = New System.Drawing.Point(6, 202)
        Me.lblInformation6.Name = "lblInformation6"
        Me.lblInformation6.Size = New System.Drawing.Size(142, 23)
        Me.lblInformation6.TabIndex = 15
        Me.lblInformation6.Text = "Animal Type"
        '
        'ChckBDelete
        '
        Me.ChckBDelete.AutoSize = True
        Me.ChckBDelete.Location = New System.Drawing.Point(97, 260)
        Me.ChckBDelete.Name = "ChckBDelete"
        Me.ChckBDelete.Size = New System.Drawing.Size(15, 14)
        Me.ChckBDelete.TabIndex = 14
        Me.ChckBDelete.UseVisualStyleBackColor = True
        '
        'ChckBUpdate
        '
        Me.ChckBUpdate.AutoSize = True
        Me.ChckBUpdate.Location = New System.Drawing.Point(228, 260)
        Me.ChckBUpdate.Name = "ChckBUpdate"
        Me.ChckBUpdate.Size = New System.Drawing.Size(15, 14)
        Me.ChckBUpdate.TabIndex = 13
        Me.ChckBUpdate.UseVisualStyleBackColor = True
        '
        'lblInformation5
        '
        Me.lblInformation5.AutoSize = True
        Me.lblInformation5.Location = New System.Drawing.Point(6, 163)
        Me.lblInformation5.Name = "lblInformation5"
        Me.lblInformation5.Size = New System.Drawing.Size(82, 23)
        Me.lblInformation5.TabIndex = 12
        Me.lblInformation5.Text = "Market"
        '
        'lblInformation4
        '
        Me.lblInformation4.AutoSize = True
        Me.lblInformation4.Font = New System.Drawing.Font("OCR A Extended", 14.0!)
        Me.lblInformation4.Location = New System.Drawing.Point(6, 129)
        Me.lblInformation4.Name = "lblInformation4"
        Me.lblInformation4.Size = New System.Drawing.Size(218, 20)
        Me.lblInformation4.TabIndex = 11
        Me.lblInformation4.Text = "Date of Transaction"
        '
        'lblInformation3
        '
        Me.lblInformation3.AutoSize = True
        Me.lblInformation3.Font = New System.Drawing.Font("OCR A Extended", 15.0!)
        Me.lblInformation3.Location = New System.Drawing.Point(6, 98)
        Me.lblInformation3.Name = "lblInformation3"
        Me.lblInformation3.Size = New System.Drawing.Size(130, 23)
        Me.lblInformation3.TabIndex = 10
        Me.lblInformation3.Text = "Sale Price"
        '
        'lblInformation2
        '
        Me.lblInformation2.AutoSize = True
        Me.lblInformation2.Location = New System.Drawing.Point(6, 66)
        Me.lblInformation2.Name = "lblInformation2"
        Me.lblInformation2.Size = New System.Drawing.Size(130, 23)
        Me.lblInformation2.TabIndex = 9
        Me.lblInformation2.Text = "Buyer Name"
        '
        'txtData5
        '
        Me.txtData5.Location = New System.Drawing.Point(235, 163)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(100, 28)
        Me.txtData5.TabIndex = 8
        '
        'txtData4
        '
        Me.txtData4.Location = New System.Drawing.Point(235, 129)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(100, 28)
        Me.txtData4.TabIndex = 7
        '
        'txtData3
        '
        Me.txtData3.Location = New System.Drawing.Point(235, 95)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(100, 28)
        Me.txtData3.TabIndex = 6
        '
        'txtData2
        '
        Me.txtData2.Location = New System.Drawing.Point(235, 61)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(100, 28)
        Me.txtData2.TabIndex = 5
        '
        'lblInformation1
        '
        Me.lblInformation1.AutoSize = True
        Me.lblInformation1.Location = New System.Drawing.Point(6, 32)
        Me.lblInformation1.Name = "lblInformation1"
        Me.lblInformation1.Size = New System.Drawing.Size(178, 23)
        Me.lblInformation1.TabIndex = 4
        Me.lblInformation1.Text = "Transaction Id"
        '
        'txtData1
        '
        Me.txtData1.Location = New System.Drawing.Point(235, 27)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(100, 28)
        Me.txtData1.TabIndex = 3
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(249, 251)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(86, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(118, 251)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(88, 23)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(10, 251)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(64, 23)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'CBSelectInput
        '
        Me.CBSelectInput.FormattingEnabled = True
        Me.CBSelectInput.Location = New System.Drawing.Point(168, 298)
        Me.CBSelectInput.Name = "CBSelectInput"
        Me.CBSelectInput.Size = New System.Drawing.Size(179, 21)
        Me.CBSelectInput.TabIndex = 2
        '
        'CBSelectOutput
        '
        Me.CBSelectOutput.FormattingEnabled = True
        Me.CBSelectOutput.Location = New System.Drawing.Point(168, 325)
        Me.CBSelectOutput.Name = "CBSelectOutput"
        Me.CBSelectOutput.Size = New System.Drawing.Size(179, 21)
        Me.CBSelectOutput.TabIndex = 3
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("OCR A Extended", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(18, 298)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(142, 23)
        Me.lblInfo.TabIndex = 13
        Me.lblInfo.Text = "Feild Input"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("OCR A Extended", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(18, 325)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(70, 23)
        Me.lblOutput.TabIndex = 14
        Me.lblOutput.Text = "Table"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(733, 368)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.CBSelectOutput)
        Me.Controls.Add(Me.CBSelectInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGMetaFarms)
        Me.Name = "Form1"
        Me.Text = "Metafarms Database"
        CType(Me.DGMetaFarms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGMetaFarms As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents lblInformation5 As System.Windows.Forms.Label
    Friend WithEvents lblInformation4 As System.Windows.Forms.Label
    Friend WithEvents lblInformation3 As System.Windows.Forms.Label
    Friend WithEvents lblInformation2 As System.Windows.Forms.Label
    Friend WithEvents txtData5 As System.Windows.Forms.TextBox
    Friend WithEvents txtData4 As System.Windows.Forms.TextBox
    Friend WithEvents txtData3 As System.Windows.Forms.TextBox
    Friend WithEvents txtData2 As System.Windows.Forms.TextBox
    Friend WithEvents lblInformation1 As System.Windows.Forms.Label
    Friend WithEvents txtData1 As System.Windows.Forms.TextBox
    Friend WithEvents CBSelectInput As System.Windows.Forms.ComboBox
    Friend WithEvents CBSelectOutput As System.Windows.Forms.ComboBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents ChckBDelete As System.Windows.Forms.CheckBox
    Friend WithEvents ChckBUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents txtData6 As System.Windows.Forms.TextBox
    Friend WithEvents lblInformation6 As System.Windows.Forms.Label

End Class
