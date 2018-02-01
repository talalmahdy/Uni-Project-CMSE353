<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class images_list
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(images_list))
        Me.PROJECTDataSet = New WindowsApplication2.PROJECTDataSet()
        Me.ImagesTableAdapter = New WindowsApplication2.PROJECTDataSetTableAdapters.ImagesTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ImagesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImagesDataTableAdapter1 = New WindowsApplication2.PROJECTDataSetTableAdapters.ImagesDataTableAdapter()
        Me.delete = New System.Windows.Forms.Button()
        Me.addnew = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PROJECTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROJECTDataSet
        '
        Me.PROJECTDataSet.DataSetName = "PROJECTDataSet"
        Me.PROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImagesTableAdapter
        '
        Me.ImagesTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ImagesBindingSource1
        Me.ListBox1.DisplayMember = "image_name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(922, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 381)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "Image_ID"
        '
        'ImagesBindingSource1
        '
        Me.ImagesBindingSource1.DataMember = "Images"
        Me.ImagesBindingSource1.DataSource = Me.PROJECTDataSet
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ImagesBindingSource1, "Image", True))
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(879, 415)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ImagesBindingSource
        '
        Me.ImagesBindingSource.DataMember = "Images"
        Me.ImagesBindingSource.DataSource = Me.PROJECTDataSet
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImagesDataTableAdapter1
        '
        Me.ImagesDataTableAdapter1.ClearBeforeFill = True
        '
        'delete
        '
        Me.delete.BackgroundImage = CType(resources.GetObject("delete.BackgroundImage"), System.Drawing.Image)
        Me.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(969, 446)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(30, 30)
        Me.delete.TabIndex = 8
        Me.delete.UseVisualStyleBackColor = True
        '
        'addnew
        '
        Me.addnew.BackgroundImage = CType(resources.GetObject("addnew.BackgroundImage"), System.Drawing.Image)
        Me.addnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addnew.FlatAppearance.BorderSize = 0
        Me.addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addnew.Location = New System.Drawing.Point(1031, 446)
        Me.addnew.Name = "addnew"
        Me.addnew.Size = New System.Drawing.Size(30, 30)
        Me.addnew.TabIndex = 7
        Me.addnew.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(741, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Image|*.jpg|png|*.png|All|*.*"
        '
        'images_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 487)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.addnew)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "images_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "images_list"
        CType(Me.PROJECTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PROJECTDataSet As PROJECTDataSet
    Friend WithEvents ImagesTableAdapter As PROJECTDataSetTableAdapters.ImagesTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImagesBindingSource1 As BindingSource
    Friend WithEvents ImagesBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents ImagesDataTableAdapter1 As PROJECTDataSetTableAdapters.ImagesDataTableAdapter
    Friend WithEvents delete As Button
    Friend WithEvents addnew As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
