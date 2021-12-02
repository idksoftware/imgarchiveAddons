
namespace iawizard
{
    partial class IAWizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IAWizardForm));
            this.header1 = new IDK.Gui.Wizard.Header();
            this.header2 = new IDK.Gui.Wizard.Header();
            this.header3 = new IDK.Gui.Wizard.Header();
            this.header1.SuspendLayout();
            this.header2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.Control;
            this.header1.CausesValidation = false;
            this.header1.Controls.Add(this.header2);
            this.header1.Description = "Description";
            this.header1.Image = ((System.Drawing.Image)(resources.GetObject("header1.Image")));
            this.header1.Location = new System.Drawing.Point(12, 12);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1087, 91);
            this.header1.TabIndex = 0;
            this.header1.Title = "Title";
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.SystemColors.Control;
            this.header2.CausesValidation = false;
            this.header2.Controls.Add(this.header3);
            this.header2.Description = "Description";
            this.header2.Image = ((System.Drawing.Image)(resources.GetObject("header2.Image")));
            this.header2.Location = new System.Drawing.Point(0, 0);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(324, 64);
            this.header2.TabIndex = 9;
            this.header2.Title = "Title";
            // 
            // header3
            // 
            this.header3.BackColor = System.Drawing.SystemColors.Control;
            this.header3.CausesValidation = false;
            this.header3.Description = "Description";
            this.header3.Image = ((System.Drawing.Image)(resources.GetObject("header3.Image")));
            this.header3.Location = new System.Drawing.Point(0, 0);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(324, 64);
            this.header3.TabIndex = 9;
            this.header3.Title = "Title";
            // 
            // IAWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 705);
            this.Controls.Add(this.header1);
            this.Name = "IAWizardForm";
            this.Text = "Form1";
            this.header1.ResumeLayout(false);
            this.header2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IDK.Gui.Wizard.Header header1;
        private IDK.Gui.Wizard.Header header2;
        private IDK.Gui.Wizard.Header header3;
    }
}

