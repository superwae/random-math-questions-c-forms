namespace _10_q_test
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Next_button = new System.Windows.Forms.Button();
            this.finish_button = new System.Windows.Forms.Button();
            this.text_answer = new System.Windows.Forms.TextBox();
            this.label_equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next_button
            // 
            this.Next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.Location = new System.Drawing.Point(219, 36);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(84, 39);
            this.Next_button.TabIndex = 1;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // finish_button
            // 
            this.finish_button.Enabled = false;
            this.finish_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_button.Location = new System.Drawing.Point(219, 110);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(84, 39);
            this.finish_button.TabIndex = 2;
            this.finish_button.Text = "Finish";
            this.finish_button.UseVisualStyleBackColor = true;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // text_answer
            // 
            this.text_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_answer.Location = new System.Drawing.Point(27, 118);
            this.text_answer.Name = "text_answer";
            this.text_answer.Size = new System.Drawing.Size(150, 31);
            this.text_answer.TabIndex = 0;
            this.text_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_answer_KeyDown);
            this.text_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_answer_KeyPress);
            // 
            // label_equation
            // 
            this.label_equation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equation.Location = new System.Drawing.Point(27, 36);
            this.label_equation.Name = "label_equation";
            this.label_equation.Size = new System.Drawing.Size(150, 39);
            this.label_equation.TabIndex = 3;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(317, 167);
            this.Controls.Add(this.label_equation);
            this.Controls.Add(this.text_answer);
            this.Controls.Add(this.finish_button);
            this.Controls.Add(this.Next_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.TextBox text_answer;
        private System.Windows.Forms.Label label_equation;
    }
}

