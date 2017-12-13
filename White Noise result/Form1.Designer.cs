namespace White_Noise_result
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
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.BuildGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphBox
            // 
            this.GraphBox.BackColor = System.Drawing.SystemColors.Window;
            this.GraphBox.Location = new System.Drawing.Point(12, 117);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(951, 186);
            this.GraphBox.TabIndex = 0;
            this.GraphBox.TabStop = false;
            // 
            // BuildGraph
            // 
            this.BuildGraph.Location = new System.Drawing.Point(481, 39);
            this.BuildGraph.Name = "BuildGraph";
            this.BuildGraph.Size = new System.Drawing.Size(131, 23);
            this.BuildGraph.TabIndex = 1;
            this.BuildGraph.Text = "Построить график";
            this.BuildGraph.UseVisualStyleBackColor = true;
            this.BuildGraph.Click += new System.EventHandler(this.BuildGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 315);
            this.Controls.Add(this.BuildGraph);
            this.Controls.Add(this.GraphBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.Button BuildGraph;
    }
}

