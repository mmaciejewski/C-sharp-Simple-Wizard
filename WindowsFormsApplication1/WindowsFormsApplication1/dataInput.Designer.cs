namespace WindowsFormsApplication1
{
    partial class dataInput
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
            this.label = new System.Windows.Forms.Label();
            this.data_input = new System.Windows.Forms.TextBox();
            this.prev_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 75);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Imie:";
            // 
            // data_input
            // 
            this.data_input.Location = new System.Drawing.Point(82, 72);
            this.data_input.Multiline = true;
            this.data_input.Name = "data_input";
            this.data_input.Size = new System.Drawing.Size(123, 16);
            this.data_input.TabIndex = 1;
            this.data_input.TextChanged += new System.EventHandler(this.data_input_TextChanged);
            // 
            // prev_button
            // 
            this.prev_button.Location = new System.Drawing.Point(12, 224);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(72, 23);
            this.prev_button.TabIndex = 2;
            this.prev_button.Text = "< Wstecz";
            this.prev_button.UseVisualStyleBackColor = true;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(197, 224);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 3;
            this.next_button.Text = "Dalej >";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.ForeColor = System.Drawing.Color.Crimson;
            this.error_text.Location = new System.Drawing.Point(69, 115);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(152, 13);
            this.error_text.TabIndex = 4;
            this.error_text.Text = "Prosze wprowadzic tylko 9 cyfr";
            this.error_text.Visible = false;
            // 
            // dataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.data_input);
            this.Controls.Add(this.label);
            this.Name = "dataInput";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.dataInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox data_input;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label error_text;
    }
}

