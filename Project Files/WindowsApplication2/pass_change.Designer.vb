<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pass_change
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pass_change))
        Me.Old_Pass = New System.Windows.Forms.TextBox()
        Me.New_Pass = New System.Windows.Forms.TextBox()
        Me.New_Pass2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProjectDataSet1 = New WindowsApplication2.PROJECTDataSet()
        Me.UsersTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.UsersTableAdapter()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Old_Pass
        '
        Me.Old_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Old_Pass.Location = New System.Drawing.Point(30, 38)
        Me.Old_Pass.Name = "Old_Pass"
        Me.Old_Pass.Size = New System.Drawing.Size(207, 26)
        Me.Old_Pass.TabIndex = 0
        Me.Old_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Old_Pass.UseSystemPasswordChar = True
        '
        'New_Pass
        '
        Me.New_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Pass.Location = New System.Drawing.Point(30, 101)
        Me.New_Pass.Name = "New_Pass"
        Me.New_Pass.Size = New System.Drawing.Size(207, 26)
        Me.New_Pass.TabIndex = 1
        Me.New_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.New_Pass.UseSystemPasswordChar = True
        '
        'New_Pass2
        '
        Me.New_Pass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.New_Pass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Pass2.Location = New System.Drawing.Point(30, 163)
        Me.New_Pass2.Name = "New_Pass2"
        Me.New_Pass2.Size = New System.Drawing.Size(207, 26)
        Me.New_Pass2.TabIndex = 2
        Me.New_Pass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.New_Pass2.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(63, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = " Confirm New Password"
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "PROJECTDataSet"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'pass_change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 282)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.New_Pass2)
        Me.Controls.Add(Me.New_Pass)
        Me.Controls.Add(Me.Old_Pass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pass_change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pass_change"
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Old_Pass As TextBox
    Friend WithEvents New_Pass As TextBox
    Friend WithEvents New_Pass2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProjectDataSet1 As PROJECTDataSet
    Friend WithEvents UsersTableAdapter1 As PROJECTDataSetTableAdapters.UsersTableAdapter
End Class
