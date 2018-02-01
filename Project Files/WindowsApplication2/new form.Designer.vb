<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(new_form))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ProjectDataSet1 = New WindowsApplication2.PROJECTDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotesTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.NotesTableAdapter()
        Me.UsersTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.UsersTableAdapter()
        Me.Notes_AccessTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.Notes_AccessTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(33, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(33, 93)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(430, 202)
        Me.TextBox2.TabIndex = 1
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "PROJECTDataSet"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(33, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save Normal Note"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotesTableAdapter1
        '
        Me.NotesTableAdapter1.ClearBeforeFill = True
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'Notes_AccessTableAdapter1
        '
        Me.Notes_AccessTableAdapter1.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(327, 307)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 26)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Save Encrypted Note"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Stone Inf OS ITC TT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(29, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Stone Inf OS ITC TT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(29, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Note:"
        '
        'new_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 345)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "new_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "new_form"
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ProjectDataSet1 As PROJECTDataSet
    Friend WithEvents Button1 As Button
    Friend WithEvents NotesTableAdapter1 As PROJECTDataSetTableAdapters.NotesTableAdapter
    Friend WithEvents UsersTableAdapter1 As PROJECTDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents Notes_AccessTableAdapter1 As PROJECTDataSetTableAdapters.Notes_AccessTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
