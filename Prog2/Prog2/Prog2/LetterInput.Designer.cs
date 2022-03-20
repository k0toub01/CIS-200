
namespace UPVApp
{
    partial class LetterInput
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originCombo = new System.Windows.Forms.ComboBox();
            this.destComboBox = new System.Windows.Forms.ComboBox();
            this.fixCostTxt = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed Cost:";
            // 
            // originCombo
            // 
            this.originCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originCombo.FormattingEnabled = true;
            this.originCombo.Location = new System.Drawing.Point(195, 40);
            this.originCombo.Margin = new System.Windows.Forms.Padding(2);
            this.originCombo.Name = "originCombo";
            this.originCombo.Size = new System.Drawing.Size(82, 21);
            this.originCombo.TabIndex = 3;
            this.originCombo.Validating += new System.ComponentModel.CancelEventHandler(this.origin_Validating);
            this.originCombo.Validated += new System.EventHandler(this.origin_Validated);
            // 
            // destComboBox
            // 
            this.destComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destComboBox.FormattingEnabled = true;
            this.destComboBox.Location = new System.Drawing.Point(195, 79);
            this.destComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.destComboBox.Name = "destComboBox";
            this.destComboBox.Size = new System.Drawing.Size(82, 21);
            this.destComboBox.TabIndex = 4;
            this.destComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.dest_Validating);
            this.destComboBox.Validated += new System.EventHandler(this.dest_Validate);
            // 
            // fixCostTxt
            // 
            this.fixCostTxt.Location = new System.Drawing.Point(195, 111);
            this.fixCostTxt.Margin = new System.Windows.Forms.Padding(2);
            this.fixCostTxt.Name = "fixCostTxt";
            this.fixCostTxt.Size = new System.Drawing.Size(82, 20);
            this.fixCostTxt.TabIndex = 5;
            this.fixCostTxt.Validating += new System.ComponentModel.CancelEventHandler(this.fixed_Validating);
            this.fixCostTxt.Validated += new System.EventHandler(this.fixed_Validated);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(189, 196);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 21);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelmouseBttn);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(109, 196);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(50, 21);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "OK";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fixCostTxt);
            this.Controls.Add(this.destComboBox);
            this.Controls.Add(this.originCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LetterInput";
            this.Text = "MyUps ParcelView: Letter";
            this.Load += new System.EventHandler(this.LetterInput_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelmouseBttn);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox originCombo;
        private System.Windows.Forms.ComboBox destComboBox;
        private System.Windows.Forms.TextBox fixCostTxt;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}