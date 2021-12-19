
namespace workItOut
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exercisesListbox = new System.Windows.Forms.CheckedListBox();
            this.muscleCombo = new System.Windows.Forms.ComboBox();
            this.workoutListbox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameWorkoutTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "type training";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "spiergroep";
            // 
            // typeCombo
            // 
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(238, 149);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(153, 23);
            this.typeCombo.TabIndex = 4;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(592, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate workout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(796, 121);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // exercisesListbox
            // 
            this.exercisesListbox.FormattingEnabled = true;
            this.exercisesListbox.Location = new System.Drawing.Point(77, 275);
            this.exercisesListbox.Name = "exercisesListbox";
            this.exercisesListbox.Size = new System.Drawing.Size(314, 184);
            this.exercisesListbox.TabIndex = 11;
            this.exercisesListbox.SelectedIndexChanged += new System.EventHandler(this.exercisesListbox_SelectedIndexChanged);
            // 
            // muscleCombo
            // 
            this.muscleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muscleCombo.FormattingEnabled = true;
            this.muscleCombo.Location = new System.Drawing.Point(238, 193);
            this.muscleCombo.Name = "muscleCombo";
            this.muscleCombo.Size = new System.Drawing.Size(153, 23);
            this.muscleCombo.TabIndex = 12;
            this.muscleCombo.SelectedIndexChanged += new System.EventHandler(this.muscleCombo_SelectedIndexChanged);
            // 
            // workoutListbox
            // 
            this.workoutListbox.FormattingEnabled = true;
            this.workoutListbox.Location = new System.Drawing.Point(442, 149);
            this.workoutListbox.Name = "workoutListbox";
            this.workoutListbox.Size = new System.Drawing.Size(314, 256);
            this.workoutListbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "oefeningen";
            // 
            // nameWorkoutTXT
            // 
            this.nameWorkoutTXT.Location = new System.Drawing.Point(442, 435);
            this.nameWorkoutTXT.Name = "nameWorkoutTXT";
            this.nameWorkoutTXT.Size = new System.Drawing.Size(144, 23);
            this.nameWorkoutTXT.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "naam workout";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameWorkoutTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workoutListbox);
            this.Controls.Add(this.muscleCombo);
            this.Controls.Add(this.exercisesListbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox exercisesListbox;
        private System.Windows.Forms.ComboBox muscleCombo;
        private System.Windows.Forms.CheckedListBox workoutListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameWorkoutTXT;
        private System.Windows.Forms.Label label4;
    }
}