using System.ComponentModel;

namespace КТ3;

partial class ReportForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        closeBtn = new System.Windows.Forms.Button();
        resultsText = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // closeBtn
        // 
        closeBtn.Location = new System.Drawing.Point(563, 359);
        closeBtn.Name = "closeBtn";
        closeBtn.Size = new System.Drawing.Size(226, 73);
        closeBtn.TabIndex = 0;
        closeBtn.Text = "Закрыть";
        closeBtn.UseVisualStyleBackColor = true;
        closeBtn.Click += closeBtn_Click;
        // 
        // resultsText
        // 
        resultsText.Location = new System.Drawing.Point(13, 14);
        resultsText.Multiline = true;
        resultsText.Name = "resultsText";
        resultsText.Size = new System.Drawing.Size(775, 326);
        resultsText.TabIndex = 1;
        // 
        // ReportForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(resultsText);
        Controls.Add(closeBtn);
        Text = "Результаты";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox resultsText;

    private System.Windows.Forms.Button closeBtn;

    #endregion
}