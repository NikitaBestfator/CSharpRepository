namespace КТ4;

partial class Form1
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
        lbl = new System.Windows.Forms.Label();
        btn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lbl
        // 
        lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lbl.Location = new System.Drawing.Point(12, 9);
        lbl.Name = "lbl";
        lbl.Size = new System.Drawing.Size(683, 442);
        lbl.TabIndex = 0;
        lbl.Text = "Авиабилеты";
        // 
        // btn
        // 
        btn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        btn.Location = new System.Drawing.Point(498, 454);
        btn.Name = "btn";
        btn.Size = new System.Drawing.Size(197, 56);
        btn.TabIndex = 1;
        btn.Text = "Прочитать содержимое файла";
        btn.UseVisualStyleBackColor = true;
        btn.Click += btn_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(707, 522);
        Controls.Add(btn);
        Controls.Add(lbl);
        Text = "КТ4: Загрузка файлов в форму";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl;
    private System.Windows.Forms.Button btn;

    #endregion
}