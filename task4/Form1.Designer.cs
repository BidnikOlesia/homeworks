
namespace task4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.txtboxWord = new System.Windows.Forms.TextBox();
            this.txtBoxTranslate = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTranslate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxWord
            // 
            this.txtboxWord.Location = new System.Drawing.Point(40, 63);
            this.txtboxWord.Name = "txtboxWord";
            this.txtboxWord.Size = new System.Drawing.Size(100, 20);
            this.txtboxWord.TabIndex = 0;
            // 
            // txtBoxTranslate
            // 
            this.txtBoxTranslate.Location = new System.Drawing.Point(200, 63);
            this.txtBoxTranslate.Name = "txtBoxTranslate";
            this.txtBoxTranslate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTranslate.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(40, 29);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(30, 13);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "word";
            // 
            // lblTranslate
            // 
            this.lblTranslate.AutoSize = true;
            this.lblTranslate.Location = new System.Drawing.Point(197, 29);
            this.lblTranslate.Name = "lblTranslate";
            this.lblTranslate.Size = new System.Drawing.Size(47, 13);
            this.lblTranslate.TabIndex = 3;
            this.lblTranslate.Text = "translate";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(236, 124);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 7;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 159);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTranslate);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.txtBoxTranslate);
            this.Controls.Add(this.txtboxWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxWord;
        private System.Windows.Forms.TextBox txtBoxTranslate;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTranslate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTranslate;
    }
}

