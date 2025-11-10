namespace КТ3;

partial class QuestionForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        questionLabel = new System.Windows.Forms.Label();
        saveButton = new System.Windows.Forms.Button();
        controlsPanel = new System.Windows.Forms.Panel();
        SuspendLayout();
        // 
        // questionLabel
        // 
        questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        questionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
        questionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        questionLabel.Location = new System.Drawing.Point(12, 9);
        questionLabel.Name = "questionLabel";
        questionLabel.Size = new System.Drawing.Size(539, 42);
        questionLabel.TabIndex = 0;
        questionLabel.Text = "<Текст нашего вопроса>";
        // 
        // saveButton
        // 
        saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        saveButton.Location = new System.Drawing.Point(428, 83);
        saveButton.Name = "saveButton";
        saveButton.Size = new System.Drawing.Size(122, 33);
        saveButton.TabIndex = 1;
        saveButton.Text = "Сохранить";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // controlsPanel
        // 
        controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        controlsPanel.AutoScroll = true;
        controlsPanel.AutoSize = true;
        controlsPanel.Location = new System.Drawing.Point(12, 54);
        controlsPanel.Name = "controlsPanel";
        controlsPanel.Size = new System.Drawing.Size(539, 23);
        controlsPanel.TabIndex = 2;
        // 
        // QuestionForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        ClientSize = new System.Drawing.Size(563, 128);
        Controls.Add(controlsPanel);
        Controls.Add(saveButton);
        Controls.Add(questionLabel);
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Ответьте на вопрос...";
        TopMost = true;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel controlsPanel;

    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.Label questionLabel;

    #endregion
}