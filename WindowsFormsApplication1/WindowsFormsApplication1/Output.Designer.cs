namespace WindowsFormsApplication1
{
    partial class Output
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
            this.reset_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.name_output = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.surname_output = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.address_output = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(110, 216);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 0;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(68, 39);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Imie:";
            // 
            // name_output
            // 
            this.name_output.AutoSize = true;
            this.name_output.Location = new System.Drawing.Point(107, 39);
            this.name_output.Name = "name_output";
            this.name_output.Size = new System.Drawing.Size(35, 13);
            this.name_output.TabIndex = 2;
            this.name_output.Text = "label2";
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Location = new System.Drawing.Point(41, 68);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(56, 13);
            this.surname_label.TabIndex = 3;
            this.surname_label.Text = "Nazwisko:";
            // 
            // surname_output
            // 
            this.surname_output.AutoSize = true;
            this.surname_output.Location = new System.Drawing.Point(107, 68);
            this.surname_output.Name = "surname_output";
            this.surname_output.Size = new System.Drawing.Size(35, 13);
            this.surname_output.TabIndex = 4;
            this.surname_output.Text = "label4";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(57, 97);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(37, 13);
            this.address_label.TabIndex = 5;
            this.address_label.Text = "Adres:";
            // 
            // address_output
            // 
            this.address_output.AutoSize = true;
            this.address_output.Location = new System.Drawing.Point(107, 97);
            this.address_output.MaximumSize = new System.Drawing.Size(100, 0);
            this.address_output.Name = "address_output";
            this.address_output.Size = new System.Drawing.Size(35, 13);
            this.address_output.TabIndex = 6;
            this.address_output.Text = "label6";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(36, 168);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(58, 13);
            this.phone_label.TabIndex = 7;
            this.phone_label.Text = "Numer tel.:";
            // 
            // phone_output
            // 
            this.phone_output.AutoSize = true;
            this.phone_output.Location = new System.Drawing.Point(107, 168);
            this.phone_output.Name = "phone_output";
            this.phone_output.Size = new System.Drawing.Size(35, 13);
            this.phone_output.TabIndex = 8;
            this.phone_output.Text = "label8";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.phone_output);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.address_output);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.surname_output);
            this.Controls.Add(this.surname_label);
            this.Controls.Add(this.name_output);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.reset_button);
            this.Name = "Output";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.Output_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label name_output;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label surname_output;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label address_output;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label phone_output;
    }
}