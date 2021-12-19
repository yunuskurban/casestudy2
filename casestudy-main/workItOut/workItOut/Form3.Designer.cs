
namespace workItOut
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.workoutCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.workoutExercise = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(796, 121);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // workoutCombobox
            // 
            this.workoutCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workoutCombobox.FormattingEnabled = true;
            this.workoutCombobox.Location = new System.Drawing.Point(179, 154);
            this.workoutCombobox.Name = "workoutCombobox";
            this.workoutCombobox.Size = new System.Drawing.Size(164, 23);
            this.workoutCombobox.TabIndex = 12;
            this.workoutCombobox.SelectedIndexChanged += new System.EventHandler(this.workoutCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "workout";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(59, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "verwijder";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // workoutExercise
            // 
            this.workoutExercise.FormattingEnabled = true;
            this.workoutExercise.Location = new System.Drawing.Point(418, 154);
            this.workoutExercise.Name = "workoutExercise";
            this.workoutExercise.Size = new System.Drawing.Size(321, 238);
            this.workoutExercise.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workoutExercise);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workoutCombobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox workoutCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox workoutExercise;
    }
}