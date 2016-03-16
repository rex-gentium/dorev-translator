namespace DorevApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxDorev = new System.Windows.Forms.RichTextBox();
            this.richTextBoxModern = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonImportDorev = new System.Windows.Forms.Button();
            this.buttonExportDorev = new System.Windows.Forms.Button();
            this.buttonExportModern = new System.Windows.Forms.Button();
            this.buttonImportModern = new System.Windows.Forms.Button();
            this.buttonToModern = new System.Windows.Forms.Button();
            this.buttonToDorev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDorev
            // 
            this.richTextBoxDorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDorev.Location = new System.Drawing.Point(12, 25);
            this.richTextBoxDorev.Name = "richTextBoxDorev";
            this.richTextBoxDorev.Size = new System.Drawing.Size(340, 495);
            this.richTextBoxDorev.TabIndex = 0;
            this.richTextBoxDorev.Text = "";
            // 
            // richTextBoxModern
            // 
            this.richTextBoxModern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxModern.Location = new System.Drawing.Point(492, 25);
            this.richTextBoxModern.Name = "richTextBoxModern";
            this.richTextBoxModern.Size = new System.Drawing.Size(340, 495);
            this.richTextBoxModern.TabIndex = 1;
            this.richTextBoxModern.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дореволюционный вариант";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Современный вариант";
            // 
            // buttonImportDorev
            // 
            this.buttonImportDorev.Location = new System.Drawing.Point(12, 526);
            this.buttonImportDorev.Name = "buttonImportDorev";
            this.buttonImportDorev.Size = new System.Drawing.Size(75, 23);
            this.buttonImportDorev.TabIndex = 4;
            this.buttonImportDorev.Text = "Из файла...";
            this.buttonImportDorev.UseVisualStyleBackColor = true;
            // 
            // buttonExportDorev
            // 
            this.buttonExportDorev.Location = new System.Drawing.Point(93, 526);
            this.buttonExportDorev.Name = "buttonExportDorev";
            this.buttonExportDorev.Size = new System.Drawing.Size(75, 23);
            this.buttonExportDorev.TabIndex = 5;
            this.buttonExportDorev.Text = "В файл...";
            this.buttonExportDorev.UseVisualStyleBackColor = true;
            // 
            // buttonExportModern
            // 
            this.buttonExportModern.Location = new System.Drawing.Point(757, 526);
            this.buttonExportModern.Name = "buttonExportModern";
            this.buttonExportModern.Size = new System.Drawing.Size(75, 23);
            this.buttonExportModern.TabIndex = 7;
            this.buttonExportModern.Text = "В файл...";
            this.buttonExportModern.UseVisualStyleBackColor = true;
            // 
            // buttonImportModern
            // 
            this.buttonImportModern.Location = new System.Drawing.Point(676, 526);
            this.buttonImportModern.Name = "buttonImportModern";
            this.buttonImportModern.Size = new System.Drawing.Size(75, 23);
            this.buttonImportModern.TabIndex = 6;
            this.buttonImportModern.Text = "Из файла...";
            this.buttonImportModern.UseVisualStyleBackColor = true;
            // 
            // buttonToModern
            // 
            this.buttonToModern.Location = new System.Drawing.Point(385, 226);
            this.buttonToModern.Name = "buttonToModern";
            this.buttonToModern.Size = new System.Drawing.Size(75, 23);
            this.buttonToModern.TabIndex = 8;
            this.buttonToModern.Text = ">>";
            this.buttonToModern.UseVisualStyleBackColor = true;
            this.buttonToModern.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TranslateToModern);
            // 
            // buttonToDorev
            // 
            this.buttonToDorev.Location = new System.Drawing.Point(385, 297);
            this.buttonToDorev.Name = "buttonToDorev";
            this.buttonToDorev.Size = new System.Drawing.Size(75, 23);
            this.buttonToDorev.TabIndex = 9;
            this.buttonToDorev.Text = "<<";
            this.buttonToDorev.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.buttonToDorev);
            this.Controls.Add(this.buttonToModern);
            this.Controls.Add(this.buttonExportModern);
            this.Controls.Add(this.buttonImportModern);
            this.Controls.Add(this.buttonExportDorev);
            this.Controls.Add(this.buttonImportDorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxModern);
            this.Controls.Add(this.richTextBoxDorev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDorev;
        private System.Windows.Forms.RichTextBox richTextBoxModern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonImportDorev;
        private System.Windows.Forms.Button buttonExportDorev;
        private System.Windows.Forms.Button buttonExportModern;
        private System.Windows.Forms.Button buttonImportModern;
        private System.Windows.Forms.Button buttonToModern;
        private System.Windows.Forms.Button buttonToDorev;
    }
}

