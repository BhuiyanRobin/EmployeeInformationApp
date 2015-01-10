namespace EmployeeInformationApp
{
    partial class mainMenuForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportGenarateButtton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.addDegignationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportGenarateButtton);
            this.groupBox1.Controls.Add(this.addEmployeeButton);
            this.groupBox1.Controls.Add(this.addDegignationButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // reportGenarateButtton
            // 
            this.reportGenarateButtton.Location = new System.Drawing.Point(328, 29);
            this.reportGenarateButtton.Name = "reportGenarateButtton";
            this.reportGenarateButtton.Size = new System.Drawing.Size(75, 77);
            this.reportGenarateButtton.TabIndex = 5;
            this.reportGenarateButtton.Text = "Report Genarate";
            this.reportGenarateButtton.UseVisualStyleBackColor = true;
            this.reportGenarateButtton.Click += new System.EventHandler(this.reportGenarateButtton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(176, 29);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(75, 77);
            this.addEmployeeButton.TabIndex = 4;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // addDegignationButton
            // 
            this.addDegignationButton.Location = new System.Drawing.Point(33, 29);
            this.addDegignationButton.Name = "addDegignationButton";
            this.addDegignationButton.Size = new System.Drawing.Size(75, 77);
            this.addDegignationButton.TabIndex = 3;
            this.addDegignationButton.Text = "Add Degignation";
            this.addDegignationButton.UseVisualStyleBackColor = true;
            this.addDegignationButton.Click += new System.EventHandler(this.addDegignationButton_Click);
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 204);
            this.Controls.Add(this.groupBox1);
            this.Name = "mainMenuForm";
            this.Text = "mainMenu";

            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reportGenarateButtton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button addDegignationButton;

    }
}

