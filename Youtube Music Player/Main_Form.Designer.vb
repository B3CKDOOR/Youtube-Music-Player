<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Searchbox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.URLBox = New System.Windows.Forms.TextBox()
        Me.Flash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Flash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Searchbox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.URLBox)
        Me.SplitContainer1.Panel1MinSize = 40
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Flash1)
        Me.SplitContainer1.Size = New System.Drawing.Size(731, 489)
        Me.SplitContainer1.SplitterDistance = 40
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 20)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Download!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Searchbox
        '
        Me.Searchbox.Location = New System.Drawing.Point(1, 20)
        Me.Searchbox.Name = "Searchbox"
        Me.Searchbox.Size = New System.Drawing.Size(568, 20)
        Me.Searchbox.TabIndex = 10
        Me.Searchbox.Text = "Type here to search..."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(664, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Topmost"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(575, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 20)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Search!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'URLBox
        '
        Me.URLBox.Location = New System.Drawing.Point(1, 1)
        Me.URLBox.Name = "URLBox"
        Me.URLBox.Size = New System.Drawing.Size(568, 20)
        Me.URLBox.TabIndex = 7
        '
        'Flash1
        '
        Me.Flash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Flash1.Enabled = True
        Me.Flash1.Location = New System.Drawing.Point(0, 0)
        Me.Flash1.Name = "Flash1"
        Me.Flash1.OcxState = CType(resources.GetObject("Flash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Flash1.Size = New System.Drawing.Size(731, 445)
        Me.Flash1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(664, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 19)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Play"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 489)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Form"
        Me.Text = "Main_Form"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Flash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button2 As Button
    Friend WithEvents URLBox As TextBox
    Friend WithEvents Flash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Searchbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
