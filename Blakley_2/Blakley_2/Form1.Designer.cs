namespace Blakley_2
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
            this.components = new System.ComponentModel.Container();
            this.languagePictureBox = new System.Windows.Forms.PictureBox();
            this.termInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.termYearLabel = new System.Windows.Forms.Label();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.outStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.residenceStatusLabel = new System.Windows.Forms.Label();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            this.beginningSpanishCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningRussianCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningItalianCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningGermanCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningFrenchCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.expirationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.creditcardNumberTextBox = new System.Windows.Forms.TextBox();
            this.creditCardNumberLabel = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.mastercardRadioButton = new System.Windows.Forms.RadioButton();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.totalCoursesLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberOfCoursesLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).BeginInit();
            this.termInformationGroupBox.SuspendLayout();
            this.studentInformationGroupBox.SuspendLayout();
            this.courseGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagePictureBox
            // 
            this.languagePictureBox.Image = global::Blakley_2.Properties.Resources.language_learning1;
            this.languagePictureBox.Location = new System.Drawing.Point(44, 2);
            this.languagePictureBox.Name = "languagePictureBox";
            this.languagePictureBox.Size = new System.Drawing.Size(700, 204);
            this.languagePictureBox.TabIndex = 0;
            this.languagePictureBox.TabStop = false;
            // 
            // termInformationGroupBox
            // 
            this.termInformationGroupBox.Controls.Add(this.yearComboBox);
            this.termInformationGroupBox.Controls.Add(this.termYearLabel);
            this.termInformationGroupBox.Controls.Add(this.springRadioButton);
            this.termInformationGroupBox.Controls.Add(this.fallRadioButton);
            this.termInformationGroupBox.Location = new System.Drawing.Point(21, 212);
            this.termInformationGroupBox.Name = "termInformationGroupBox";
            this.termInformationGroupBox.Size = new System.Drawing.Size(325, 148);
            this.termInformationGroupBox.TabIndex = 1;
            this.termInformationGroupBox.TabStop = false;
            this.termInformationGroupBox.Text = "Term:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.yearComboBox.Location = new System.Drawing.Point(23, 104);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(146, 24);
            this.yearComboBox.TabIndex = 3;
            // 
            // termYearLabel
            // 
            this.termYearLabel.AutoSize = true;
            this.termYearLabel.Location = new System.Drawing.Point(20, 82);
            this.termYearLabel.Name = "termYearLabel";
            this.termYearLabel.Size = new System.Drawing.Size(42, 17);
            this.termYearLabel.TabIndex = 2;
            this.termYearLabel.Text = "Year:";
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(23, 48);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(70, 21);
            this.springRadioButton.TabIndex = 1;
            this.springRadioButton.TabStop = true;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(23, 21);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(51, 21);
            this.fallRadioButton.TabIndex = 0;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.outStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.residenceStatusLabel);
            this.studentInformationGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentInformationGroupBox.Controls.Add(this.emailTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.studentIDLabel);
            this.studentInformationGroupBox.Controls.Add(this.emailLabel);
            this.studentInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(369, 212);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(375, 148);
            this.studentInformationGroupBox.TabIndex = 2;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student:";
            // 
            // outStateRadioButton
            // 
            this.outStateRadioButton.AutoSize = true;
            this.outStateRadioButton.Location = new System.Drawing.Point(265, 78);
            this.outStateRadioButton.Name = "outStateRadioButton";
            this.outStateRadioButton.Size = new System.Drawing.Size(107, 21);
            this.outStateRadioButton.TabIndex = 9;
            this.outStateRadioButton.TabStop = true;
            this.outStateRadioButton.Text = "Out-of-State";
            this.outStateRadioButton.UseVisualStyleBackColor = true;
            this.outStateRadioButton.CheckedChanged += new System.EventHandler(this.outStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(265, 44);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(78, 21);
            this.inStateRadioButton.TabIndex = 8;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // residenceStatusLabel
            // 
            this.residenceStatusLabel.AutoSize = true;
            this.residenceStatusLabel.Location = new System.Drawing.Point(262, 18);
            this.residenceStatusLabel.Name = "residenceStatusLabel";
            this.residenceStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.residenceStatusLabel.TabIndex = 7;
            this.residenceStatusLabel.Text = "Residence:";
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(106, 104);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(138, 22);
            this.studentIDMaskedTextBox.TabIndex = 6;
            this.studentIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(106, 76);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(138, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(106, 48);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(138, 22);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(106, 19);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(138, 22);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(20, 109);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(25, 17);
            this.studentIDLabel.TabIndex = 3;
            this.studentIDLabel.Text = "ID:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(20, 48);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(20, 19);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Controls.Add(this.beginningSpanishCheckBox);
            this.courseGroupBox.Controls.Add(this.beginningRussianCheckBox);
            this.courseGroupBox.Controls.Add(this.beginningItalianCheckBox);
            this.courseGroupBox.Controls.Add(this.beginningGermanCheckBox);
            this.courseGroupBox.Controls.Add(this.beginningFrenchCheckBox);
            this.courseGroupBox.Location = new System.Drawing.Point(21, 375);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(325, 178);
            this.courseGroupBox.TabIndex = 3;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Courses:";
            // 
            // beginningSpanishCheckBox
            // 
            this.beginningSpanishCheckBox.AutoSize = true;
            this.beginningSpanishCheckBox.Location = new System.Drawing.Point(23, 138);
            this.beginningSpanishCheckBox.Name = "beginningSpanishCheckBox";
            this.beginningSpanishCheckBox.Size = new System.Drawing.Size(148, 21);
            this.beginningSpanishCheckBox.TabIndex = 4;
            this.beginningSpanishCheckBox.Text = "Beginning Spanish";
            this.beginningSpanishCheckBox.UseVisualStyleBackColor = true;
            this.beginningSpanishCheckBox.CheckedChanged += new System.EventHandler(this.beginningSpanishCheckBox_CheckedChanged);
            // 
            // beginningRussianCheckBox
            // 
            this.beginningRussianCheckBox.AutoSize = true;
            this.beginningRussianCheckBox.Location = new System.Drawing.Point(23, 111);
            this.beginningRussianCheckBox.Name = "beginningRussianCheckBox";
            this.beginningRussianCheckBox.Size = new System.Drawing.Size(148, 21);
            this.beginningRussianCheckBox.TabIndex = 3;
            this.beginningRussianCheckBox.Text = "Beginning Russian";
            this.beginningRussianCheckBox.UseVisualStyleBackColor = true;
            this.beginningRussianCheckBox.CheckedChanged += new System.EventHandler(this.beginningRussianCheckBox_CheckedChanged);
            // 
            // beginningItalianCheckBox
            // 
            this.beginningItalianCheckBox.AutoSize = true;
            this.beginningItalianCheckBox.Location = new System.Drawing.Point(23, 84);
            this.beginningItalianCheckBox.Name = "beginningItalianCheckBox";
            this.beginningItalianCheckBox.Size = new System.Drawing.Size(134, 21);
            this.beginningItalianCheckBox.TabIndex = 2;
            this.beginningItalianCheckBox.Text = "Beginning Italian";
            this.beginningItalianCheckBox.UseVisualStyleBackColor = true;
            this.beginningItalianCheckBox.CheckedChanged += new System.EventHandler(this.beginningItalianCheckBox_CheckedChanged);
            // 
            // beginningGermanCheckBox
            // 
            this.beginningGermanCheckBox.AutoSize = true;
            this.beginningGermanCheckBox.Location = new System.Drawing.Point(23, 57);
            this.beginningGermanCheckBox.Name = "beginningGermanCheckBox";
            this.beginningGermanCheckBox.Size = new System.Drawing.Size(148, 21);
            this.beginningGermanCheckBox.TabIndex = 1;
            this.beginningGermanCheckBox.Text = "Beginning German";
            this.beginningGermanCheckBox.UseVisualStyleBackColor = true;
            this.beginningGermanCheckBox.CheckedChanged += new System.EventHandler(this.beginningGermanCheckBox_CheckedChanged);
            // 
            // beginningFrenchCheckBox
            // 
            this.beginningFrenchCheckBox.AutoSize = true;
            this.beginningFrenchCheckBox.Location = new System.Drawing.Point(23, 30);
            this.beginningFrenchCheckBox.Name = "beginningFrenchCheckBox";
            this.beginningFrenchCheckBox.Size = new System.Drawing.Size(141, 21);
            this.beginningFrenchCheckBox.TabIndex = 0;
            this.beginningFrenchCheckBox.Text = "Beginning French";
            this.beginningFrenchCheckBox.UseVisualStyleBackColor = true;
            this.beginningFrenchCheckBox.CheckedChanged += new System.EventHandler(this.beginningFrenchCheckBox_CheckedChanged);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.expirationDateMaskedTextBox);
            this.paymentGroupBox.Controls.Add(this.label1);
            this.paymentGroupBox.Controls.Add(this.creditcardNumberTextBox);
            this.paymentGroupBox.Controls.Add(this.creditCardNumberLabel);
            this.paymentGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentGroupBox.Controls.Add(this.mastercardRadioButton);
            this.paymentGroupBox.Controls.Add(this.creditCardLabel);
            this.paymentGroupBox.Location = new System.Drawing.Point(369, 375);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(375, 178);
            this.paymentGroupBox.TabIndex = 5;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment:";
            // 
            // expirationDateMaskedTextBox
            // 
            this.expirationDateMaskedTextBox.Location = new System.Drawing.Point(134, 142);
            this.expirationDateMaskedTextBox.Mask = "00/00/0000";
            this.expirationDateMaskedTextBox.Name = "expirationDateMaskedTextBox";
            this.expirationDateMaskedTextBox.Size = new System.Drawing.Size(195, 22);
            this.expirationDateMaskedTextBox.TabIndex = 11;
            this.expirationDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Expiration Date:";
            // 
            // creditcardNumberTextBox
            // 
            this.creditcardNumberTextBox.Location = new System.Drawing.Point(134, 111);
            this.creditcardNumberTextBox.Name = "creditcardNumberTextBox";
            this.creditcardNumberTextBox.Size = new System.Drawing.Size(195, 22);
            this.creditcardNumberTextBox.TabIndex = 9;
            this.creditcardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // creditCardNumberLabel
            // 
            this.creditCardNumberLabel.AutoSize = true;
            this.creditCardNumberLabel.Location = new System.Drawing.Point(20, 111);
            this.creditCardNumberLabel.Name = "creditCardNumberLabel";
            this.creditCardNumberLabel.Size = new System.Drawing.Size(95, 17);
            this.creditCardNumberLabel.TabIndex = 8;
            this.creditCardNumberLabel.Text = "Credit Card #:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(34, 83);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(56, 21);
            this.visaRadioButton.TabIndex = 7;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastercardRadioButton
            // 
            this.mastercardRadioButton.AutoSize = true;
            this.mastercardRadioButton.Checked = true;
            this.mastercardRadioButton.Location = new System.Drawing.Point(34, 56);
            this.mastercardRadioButton.Name = "mastercardRadioButton";
            this.mastercardRadioButton.Size = new System.Drawing.Size(102, 21);
            this.mastercardRadioButton.TabIndex = 6;
            this.mastercardRadioButton.TabStop = true;
            this.mastercardRadioButton.Text = "MasterCard";
            this.mastercardRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(20, 30);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(83, 17);
            this.creditCardLabel.TabIndex = 0;
            this.creditCardLabel.Text = "Credit Card:";
            // 
            // totalCoursesLabel
            // 
            this.totalCoursesLabel.AutoSize = true;
            this.totalCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCoursesLabel.Location = new System.Drawing.Point(18, 570);
            this.totalCoursesLabel.Name = "totalCoursesLabel";
            this.totalCoursesLabel.Size = new System.Drawing.Size(194, 17);
            this.totalCoursesLabel.TabIndex = 6;
            this.totalCoursesLabel.Text = "Total Number of Courses:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(375, 570);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(97, 17);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Total Price: ";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(44, 632);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(191, 57);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(293, 632);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(191, 57);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(550, 632);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(191, 57);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numberOfCoursesLabel
            // 
            this.numberOfCoursesLabel.AutoSize = true;
            this.numberOfCoursesLabel.Location = new System.Drawing.Point(227, 570);
            this.numberOfCoursesLabel.Name = "numberOfCoursesLabel";
            this.numberOfCoursesLabel.Size = new System.Drawing.Size(36, 17);
            this.numberOfCoursesLabel.TabIndex = 10;
            this.numberOfCoursesLabel.Text = "0.00";
            this.numberOfCoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(567, 570);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(36, 17);
            this.orderTotalLabel.TabIndex = 11;
            this.orderTotalLabel.Text = "0.00";
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clearToolTip
            // 
            //this.clearToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            //this.clearToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.clearToolTip_Popup);
            // 
            // exitToolTip
            // 
            //this.exitToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.exitToolTip_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 712);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.numberOfCoursesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalCoursesLabel);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.courseGroupBox);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.termInformationGroupBox);
            this.Controls.Add(this.languagePictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Arts Institute - Course Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).EndInit();
            this.termInformationGroupBox.ResumeLayout(false);
            this.termInformationGroupBox.PerformLayout();
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.courseGroupBox.ResumeLayout(false);
            this.courseGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox languagePictureBox;
        private System.Windows.Forms.GroupBox termInformationGroupBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label termYearLabel;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.RadioButton outStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label residenceStatusLabel;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.GroupBox courseGroupBox;
        private System.Windows.Forms.CheckBox beginningSpanishCheckBox;
        private System.Windows.Forms.CheckBox beginningRussianCheckBox;
        private System.Windows.Forms.CheckBox beginningItalianCheckBox;
        private System.Windows.Forms.CheckBox beginningGermanCheckBox;
        private System.Windows.Forms.CheckBox beginningFrenchCheckBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.MaskedTextBox expirationDateMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox creditcardNumberTextBox;
        private System.Windows.Forms.Label creditCardNumberLabel;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton mastercardRadioButton;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Label totalCoursesLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numberOfCoursesLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}

