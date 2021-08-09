
namespace MyVacation
{
    partial class AccountForm
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
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.CurrentInfoPanel = new System.Windows.Forms.Panel();
            this.CardLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateUserPanel = new System.Windows.Forms.Panel();
            this.UserMessage = new System.Windows.Forms.Label();
            this.SubmitUser = new System.Windows.Forms.Button();
            this.CancelUser = new System.Windows.Forms.Button();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateCardPanel = new System.Windows.Forms.Panel();
            this.SubmitCard = new System.Windows.Forms.Button();
            this.CancelCard = new System.Windows.Forms.Button();
            this.ExpirationDateBox = new System.Windows.Forms.MaskedTextBox();
            this.CardNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.CVVBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CardMessage = new System.Windows.Forms.Label();
            this.UpdatePasswardPanel = new System.Windows.Forms.Panel();
            this.SubmitPass = new System.Windows.Forms.Button();
            this.CancelPass = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassBox = new System.Windows.Forms.TextBox();
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.PassMessage = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ChangeCardButton = new System.Windows.Forms.Button();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.FlightPanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.CancelFlightButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DateRangeLabel = new System.Windows.Forms.Label();
            this.EndLocationLabel = new System.Windows.Forms.Label();
            this.StartLocationLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FlightPanelButton = new System.Windows.Forms.Button();
            this.CurrentInfoPanel.SuspendLayout();
            this.UpdateUserPanel.SuspendLayout();
            this.UpdateCardPanel.SuspendLayout();
            this.UpdatePasswardPanel.SuspendLayout();
            this.FlightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(111, 22);
            this.label.TabIndex = 0;
            this.label.Text = "Username:";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(16, 34);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(168, 29);
            this.ChangePasswordButton.TabIndex = 0;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // CurrentInfoPanel
            // 
            this.CurrentInfoPanel.Controls.Add(this.CardLabel);
            this.CurrentInfoPanel.Controls.Add(this.EmailLabel);
            this.CurrentInfoPanel.Controls.Add(this.LastNameLabel);
            this.CurrentInfoPanel.Controls.Add(this.FirstNameLabel);
            this.CurrentInfoPanel.Controls.Add(this.label4);
            this.CurrentInfoPanel.Controls.Add(this.label3);
            this.CurrentInfoPanel.Controls.Add(this.label2);
            this.CurrentInfoPanel.Controls.Add(this.label1);
            this.CurrentInfoPanel.Location = new System.Drawing.Point(190, 9);
            this.CurrentInfoPanel.Name = "CurrentInfoPanel";
            this.CurrentInfoPanel.Size = new System.Drawing.Size(386, 200);
            this.CurrentInfoPanel.TabIndex = 6;
            // 
            // CardLabel
            // 
            this.CardLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardLabel.Location = new System.Drawing.Point(218, 118);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(164, 18);
            this.CardLabel.TabIndex = 11;
            this.CardLabel.Text = "0000 0000 0000 0000";
            this.CardLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(126, 86);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(256, 18);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(127, 54);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(256, 18);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(126, 22);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(256, 18);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // UpdateUserPanel
            // 
            this.UpdateUserPanel.Controls.Add(this.UserMessage);
            this.UpdateUserPanel.Controls.Add(this.SubmitUser);
            this.UpdateUserPanel.Controls.Add(this.CancelUser);
            this.UpdateUserPanel.Controls.Add(this.LastNameBox);
            this.UpdateUserPanel.Controls.Add(this.EmailBox);
            this.UpdateUserPanel.Controls.Add(this.FirstNameBox);
            this.UpdateUserPanel.Controls.Add(this.label6);
            this.UpdateUserPanel.Controls.Add(this.label7);
            this.UpdateUserPanel.Controls.Add(this.label8);
            this.UpdateUserPanel.Location = new System.Drawing.Point(190, 9);
            this.UpdateUserPanel.Name = "UpdateUserPanel";
            this.UpdateUserPanel.Size = new System.Drawing.Size(386, 200);
            this.UpdateUserPanel.TabIndex = 7;
            // 
            // UserMessage
            // 
            this.UserMessage.Location = new System.Drawing.Point(3, 141);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(380, 23);
            this.UserMessage.TabIndex = 7;
            this.UserMessage.Text = "User Message";
            this.UserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitUser
            // 
            this.SubmitUser.Location = new System.Drawing.Point(87, 174);
            this.SubmitUser.Name = "SubmitUser";
            this.SubmitUser.Size = new System.Drawing.Size(75, 23);
            this.SubmitUser.TabIndex = 9;
            this.SubmitUser.Text = "Submit";
            this.SubmitUser.UseVisualStyleBackColor = true;
            this.SubmitUser.Click += new System.EventHandler(this.SubmitUser_Click);
            // 
            // CancelUser
            // 
            this.CancelUser.Location = new System.Drawing.Point(230, 174);
            this.CancelUser.Name = "CancelUser";
            this.CancelUser.Size = new System.Drawing.Size(75, 23);
            this.CancelUser.TabIndex = 10;
            this.CancelUser.Text = "Cancel";
            this.CancelUser.UseVisualStyleBackColor = true;
            this.CancelUser.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameBox.Location = new System.Drawing.Point(144, 64);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(239, 26);
            this.LastNameBox.TabIndex = 7;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(144, 96);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(239, 26);
            this.EmailBox.TabIndex = 8;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameBox.Location = new System.Drawing.Point(144, 32);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(239, 26);
            this.FirstNameBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "First Name:";
            // 
            // UpdateCardPanel
            // 
            this.UpdateCardPanel.Controls.Add(this.SubmitCard);
            this.UpdateCardPanel.Controls.Add(this.CancelCard);
            this.UpdateCardPanel.Controls.Add(this.ExpirationDateBox);
            this.UpdateCardPanel.Controls.Add(this.CardNumberBox);
            this.UpdateCardPanel.Controls.Add(this.CVVBox);
            this.UpdateCardPanel.Controls.Add(this.label11);
            this.UpdateCardPanel.Controls.Add(this.label10);
            this.UpdateCardPanel.Controls.Add(this.label9);
            this.UpdateCardPanel.Controls.Add(this.CardMessage);
            this.UpdateCardPanel.Location = new System.Drawing.Point(190, 9);
            this.UpdateCardPanel.Name = "UpdateCardPanel";
            this.UpdateCardPanel.Size = new System.Drawing.Size(386, 200);
            this.UpdateCardPanel.TabIndex = 8;
            // 
            // SubmitCard
            // 
            this.SubmitCard.Location = new System.Drawing.Point(87, 174);
            this.SubmitCard.Name = "SubmitCard";
            this.SubmitCard.Size = new System.Drawing.Size(75, 23);
            this.SubmitCard.TabIndex = 9;
            this.SubmitCard.Text = "Submit";
            this.SubmitCard.UseVisualStyleBackColor = true;
            this.SubmitCard.Click += new System.EventHandler(this.SubmitCard_Click);
            // 
            // CancelCard
            // 
            this.CancelCard.Location = new System.Drawing.Point(230, 174);
            this.CancelCard.Name = "CancelCard";
            this.CancelCard.Size = new System.Drawing.Size(75, 23);
            this.CancelCard.TabIndex = 10;
            this.CancelCard.Text = "Cancel";
            this.CancelCard.UseVisualStyleBackColor = true;
            this.CancelCard.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ExpirationDateBox
            // 
            this.ExpirationDateBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateBox.Location = new System.Drawing.Point(160, 63);
            this.ExpirationDateBox.Mask = "00/00";
            this.ExpirationDateBox.Name = "ExpirationDateBox";
            this.ExpirationDateBox.Size = new System.Drawing.Size(170, 26);
            this.ExpirationDateBox.TabIndex = 7;
            this.ExpirationDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberBox.Location = new System.Drawing.Point(160, 31);
            this.CardNumberBox.Mask = "0000 0000 0000 0000";
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.Size = new System.Drawing.Size(170, 26);
            this.CardNumberBox.TabIndex = 6;
            this.CardNumberBox.ValidatingType = typeof(int);
            // 
            // CVVBox
            // 
            this.CVVBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVBox.Location = new System.Drawing.Point(160, 95);
            this.CVVBox.MaxLength = 3;
            this.CVVBox.Name = "CVVBox";
            this.CVVBox.Size = new System.Drawing.Size(170, 26);
            this.CVVBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "CVV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Expiration Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Card Number:";
            // 
            // CardMessage
            // 
            this.CardMessage.Location = new System.Drawing.Point(2, 139);
            this.CardMessage.Name = "CardMessage";
            this.CardMessage.Size = new System.Drawing.Size(380, 23);
            this.CardMessage.TabIndex = 17;
            this.CardMessage.Text = "Card Message";
            this.CardMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdatePasswardPanel
            // 
            this.UpdatePasswardPanel.Controls.Add(this.SubmitPass);
            this.UpdatePasswardPanel.Controls.Add(this.CancelPass);
            this.UpdatePasswardPanel.Controls.Add(this.label14);
            this.UpdatePasswardPanel.Controls.Add(this.label13);
            this.UpdatePasswardPanel.Controls.Add(this.label12);
            this.UpdatePasswardPanel.Controls.Add(this.NewPassBox);
            this.UpdatePasswardPanel.Controls.Add(this.ConfirmPassBox);
            this.UpdatePasswardPanel.Controls.Add(this.OldPassBox);
            this.UpdatePasswardPanel.Controls.Add(this.PassMessage);
            this.UpdatePasswardPanel.Location = new System.Drawing.Point(190, 9);
            this.UpdatePasswardPanel.Name = "UpdatePasswardPanel";
            this.UpdatePasswardPanel.Size = new System.Drawing.Size(386, 200);
            this.UpdatePasswardPanel.TabIndex = 7;
            // 
            // SubmitPass
            // 
            this.SubmitPass.Location = new System.Drawing.Point(87, 174);
            this.SubmitPass.Name = "SubmitPass";
            this.SubmitPass.Size = new System.Drawing.Size(75, 23);
            this.SubmitPass.TabIndex = 9;
            this.SubmitPass.Text = "Submit";
            this.SubmitPass.UseVisualStyleBackColor = true;
            this.SubmitPass.Click += new System.EventHandler(this.SubmitPass_Click);
            // 
            // CancelPass
            // 
            this.CancelPass.Location = new System.Drawing.Point(230, 174);
            this.CancelPass.Name = "CancelPass";
            this.CancelPass.Size = new System.Drawing.Size(75, 23);
            this.CancelPass.TabIndex = 10;
            this.CancelPass.Text = "Cancel";
            this.CancelPass.UseVisualStyleBackColor = true;
            this.CancelPass.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Confirm Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "New Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Old Password";
            // 
            // NewPassBox
            // 
            this.NewPassBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassBox.Location = new System.Drawing.Point(160, 64);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.PasswordChar = '*';
            this.NewPassBox.Size = new System.Drawing.Size(160, 26);
            this.NewPassBox.TabIndex = 7;
            // 
            // ConfirmPassBox
            // 
            this.ConfirmPassBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassBox.Location = new System.Drawing.Point(160, 96);
            this.ConfirmPassBox.Name = "ConfirmPassBox";
            this.ConfirmPassBox.PasswordChar = '*';
            this.ConfirmPassBox.Size = new System.Drawing.Size(160, 26);
            this.ConfirmPassBox.TabIndex = 8;
            // 
            // OldPassBox
            // 
            this.OldPassBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassBox.Location = new System.Drawing.Point(160, 32);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.PasswordChar = '*';
            this.OldPassBox.Size = new System.Drawing.Size(160, 26);
            this.OldPassBox.TabIndex = 6;
            // 
            // PassMessage
            // 
            this.PassMessage.Location = new System.Drawing.Point(2, 141);
            this.PassMessage.Name = "PassMessage";
            this.PassMessage.Size = new System.Drawing.Size(380, 23);
            this.PassMessage.TabIndex = 17;
            this.PassMessage.Text = "Pass Message";
            this.PassMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(119, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 22);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Guest";
            // 
            // ChangeCardButton
            // 
            this.ChangeCardButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeCardButton.Location = new System.Drawing.Point(16, 69);
            this.ChangeCardButton.Name = "ChangeCardButton";
            this.ChangeCardButton.Size = new System.Drawing.Size(168, 29);
            this.ChangeCardButton.TabIndex = 1;
            this.ChangeCardButton.Text = "Change Credit Card";
            this.ChangeCardButton.UseVisualStyleBackColor = true;
            this.ChangeCardButton.Click += new System.EventHandler(this.ChangeCardButton_Click);
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUserButton.Location = new System.Drawing.Point(16, 104);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(168, 29);
            this.UpdateUserButton.TabIndex = 2;
            this.UpdateUserButton.Text = "Update User Info";
            this.UpdateUserButton.UseVisualStyleBackColor = true;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // FlightPanel
            // 
            this.FlightPanel.Controls.Add(this.ReturnButton);
            this.FlightPanel.Controls.Add(this.CancelFlightButton);
            this.FlightPanel.Controls.Add(this.PriceLabel);
            this.FlightPanel.Controls.Add(this.DateRangeLabel);
            this.FlightPanel.Controls.Add(this.EndLocationLabel);
            this.FlightPanel.Controls.Add(this.StartLocationLabel);
            this.FlightPanel.Controls.Add(this.label17);
            this.FlightPanel.Controls.Add(this.label16);
            this.FlightPanel.Controls.Add(this.label15);
            this.FlightPanel.Controls.Add(this.label5);
            this.FlightPanel.Location = new System.Drawing.Point(190, 9);
            this.FlightPanel.Name = "FlightPanel";
            this.FlightPanel.Size = new System.Drawing.Size(386, 200);
            this.FlightPanel.TabIndex = 12;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(234, 174);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // CancelFlightButton
            // 
            this.CancelFlightButton.Location = new System.Drawing.Point(78, 174);
            this.CancelFlightButton.Name = "CancelFlightButton";
            this.CancelFlightButton.Size = new System.Drawing.Size(87, 23);
            this.CancelFlightButton.TabIndex = 8;
            this.CancelFlightButton.Text = "Cancel Flight";
            this.CancelFlightButton.UseVisualStyleBackColor = true;
            this.CancelFlightButton.Click += new System.EventHandler(this.CancelFlightButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(165, 123);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(205, 23);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DateRangeLabel
            // 
            this.DateRangeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRangeLabel.Location = new System.Drawing.Point(165, 89);
            this.DateRangeLabel.Name = "DateRangeLabel";
            this.DateRangeLabel.Size = new System.Drawing.Size(205, 23);
            this.DateRangeLabel.TabIndex = 6;
            this.DateRangeLabel.Text = "Date Range";
            this.DateRangeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // EndLocationLabel
            // 
            this.EndLocationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLocationLabel.Location = new System.Drawing.Point(165, 55);
            this.EndLocationLabel.Name = "EndLocationLabel";
            this.EndLocationLabel.Size = new System.Drawing.Size(205, 23);
            this.EndLocationLabel.TabIndex = 5;
            this.EndLocationLabel.Text = "End Location";
            this.EndLocationLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // StartLocationLabel
            // 
            this.StartLocationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLocationLabel.Location = new System.Drawing.Point(162, 22);
            this.StartLocationLabel.Name = "StartLocationLabel";
            this.StartLocationLabel.Size = new System.Drawing.Size(208, 23);
            this.StartLocationLabel.TabIndex = 4;
            this.StartLocationLabel.Text = "Start Location";
            this.StartLocationLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Dates:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "End Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Location:";
            // 
            // FlightPanelButton
            // 
            this.FlightPanelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightPanelButton.Location = new System.Drawing.Point(16, 139);
            this.FlightPanelButton.Name = "FlightPanelButton";
            this.FlightPanelButton.Size = new System.Drawing.Size(168, 29);
            this.FlightPanelButton.TabIndex = 3;
            this.FlightPanelButton.Text = "See Flights";
            this.FlightPanelButton.UseVisualStyleBackColor = true;
            this.FlightPanelButton.Click += new System.EventHandler(this.FlightPanelButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 222);
            this.Controls.Add(this.FlightPanelButton);
            this.Controls.Add(this.UpdateUserButton);
            this.Controls.Add(this.ChangeCardButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CurrentInfoPanel);
            this.Controls.Add(this.UpdateCardPanel);
            this.Controls.Add(this.UpdatePasswardPanel);
            this.Controls.Add(this.UpdateUserPanel);
            this.Controls.Add(this.FlightPanel);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.CurrentInfoPanel.ResumeLayout(false);
            this.CurrentInfoPanel.PerformLayout();
            this.UpdateUserPanel.ResumeLayout(false);
            this.UpdateUserPanel.PerformLayout();
            this.UpdateCardPanel.ResumeLayout(false);
            this.UpdateCardPanel.PerformLayout();
            this.UpdatePasswardPanel.ResumeLayout(false);
            this.UpdatePasswardPanel.PerformLayout();
            this.FlightPanel.ResumeLayout(false);
            this.FlightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Panel CurrentInfoPanel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UpdateUserPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel UpdateCardPanel;
        private System.Windows.Forms.TextBox CVVBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel UpdatePasswardPanel;
        private System.Windows.Forms.MaskedTextBox ExpirationDateBox;
        private System.Windows.Forms.MaskedTextBox CardNumberBox;
        private System.Windows.Forms.Button CancelUser;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox ConfirmPassBox;
        private System.Windows.Forms.TextBox OldPassBox;
        private System.Windows.Forms.Button CancelPass;
        private System.Windows.Forms.Button SubmitUser;
        private System.Windows.Forms.Button CancelCard;
        private System.Windows.Forms.Label UserMessage;
        private System.Windows.Forms.Button SubmitPass;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PassMessage;
        private System.Windows.Forms.Button SubmitCard;
        private System.Windows.Forms.Label CardMessage;
        private System.Windows.Forms.Button ChangeCardButton;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Panel FlightPanel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button CancelFlightButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DateRangeLabel;
        private System.Windows.Forms.Label EndLocationLabel;
        private System.Windows.Forms.Label StartLocationLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FlightPanelButton;
    }
}