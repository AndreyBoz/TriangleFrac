namespace TriangleFrac
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pushButton = new System.Windows.Forms.Button();
            this.numDotes = new System.Windows.Forms.TextBox();
            this.triangle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(0, 0);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(100, 23);
            this.pushButton.TabIndex = 0;
            this.pushButton.Text = "Create triangle";
            this.pushButton.Click += new System.EventHandler(this.createTriangle);
            // 
            // numDotes
            // 
            this.numDotes.Location = new System.Drawing.Point(106, 1);
            this.numDotes.Name = "numDotes";
            this.numDotes.Size = new System.Drawing.Size(100, 23);
            this.numDotes.TabIndex = 1;
            // 
            // triangle
            // 
            this.triangle.Location = new System.Drawing.Point(237, 1);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(400, 400);
            this.triangle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.numDotes);
            this.Controls.Add(this.pushButton);
            this.Name = "Form1";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button pushButton;
        private TextBox numDotes;
        private Panel triangle;
    }
}