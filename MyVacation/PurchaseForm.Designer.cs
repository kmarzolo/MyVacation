
namespace MyVacation
{
    partial class PurchaseForm
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CVV = new System.Windows.Forms.TextBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.EndLocationLabel = new System.Windows.Forms.Label();
            this.ExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.Message = new System.Windows.Forms.Label();
            this.CardNumber = new System.Windows.Forms.MaskedTextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.FromLocationLabel = new System.Windows.Forms.Label();
            this.DateRangeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(0, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(100, 19);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User: Guest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expiration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CVV";
            // 
            // CVV
            // 
            this.CVV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVV.Location = new System.Drawing.Point(152, 203);
            this.CVV.MaxLength = 3;
            this.CVV.Name = "CVV";
            this.CVV.PasswordChar = '*';
            this.CVV.Size = new System.Drawing.Size(230, 26);
            this.CVV.TabIndex = 3;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(105, 277);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(225, 277);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(347, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(347, 41);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // EndLocationLabel
            // 
            this.EndLocationLabel.AutoSize = true;
            this.EndLocationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLocationLabel.Location = new System.Drawing.Point(0, 38);
            this.EndLocationLabel.Name = "EndLocationLabel";
            this.EndLocationLabel.Size = new System.Drawing.Size(105, 19);
            this.EndLocationLabel.TabIndex = 9;
            this.EndLocationLabel.Text = "To: Location";
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.Location = new System.Drawing.Point(152, 171);
            this.ExpirationDate.Mask = "00/00";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(230, 26);
            this.ExpirationDate.TabIndex = 2;
            this.ExpirationDate.ValidatingType = typeof(System.DateTime);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(1, 246);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(410, 23);
            this.Message.TabIndex = 10;
            this.Message.Text = "Message";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumber
            // 
            this.CardNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber.Location = new System.Drawing.Point(152, 139);
            this.CardNumber.Mask = "0000 0000 0000 0000";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(230, 26);
            this.CardNumber.TabIndex = 1;
            this.CardNumber.ValidatingType = typeof(int);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(152, 107);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(230, 26);
            this.EmailBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(27, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 18);
            this.label.TabIndex = 12;
            this.label.Text = "Email";
            // 
            // FromLocationLabel
            // 
            this.FromLocationLabel.AutoSize = true;
            this.FromLocationLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLocationLabel.Location = new System.Drawing.Point(0, 19);
            this.FromLocationLabel.Name = "FromLocationLabel";
            this.FromLocationLabel.Size = new System.Drawing.Size(120, 19);
            this.FromLocationLabel.TabIndex = 13;
            this.FromLocationLabel.Text = "From: location";
            // 
            // DateRangeLabel
            // 
            this.DateRangeLabel.AutoSize = true;
            this.DateRangeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRangeLabel.Location = new System.Drawing.Point(0, 57);
            this.DateRangeLabel.Name = "DateRangeLabel";
            this.DateRangeLabel.Size = new System.Drawing.Size(98, 19);
            this.DateRangeLabel.TabIndex = 14;
            this.DateRangeLabel.Text = "Date Range";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(0, 76);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(54, 19);
            this.PriceLabel.TabIndex = 15;
            this.PriceLabel.Text = "Price:";
            // 
            // SignOutButton
            // 
            this.SignOutButton.Location = new System.Drawing.Point(347, 12);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(75, 23);
            this.SignOutButton.TabIndex = 16;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DateRangeLabel);
            this.Controls.Add(this.FromLocationLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.EndLocationLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.SignOutButton);
            this.Name = "PurchaseForm";
            this.Text = "Buy Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label EndLocationLabel;
        private System.Windows.Forms.MaskedTextBox ExpirationDate;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.MaskedTextBox CardNumber;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label FromLocationLabel;
        private System.Windows.Forms.Label DateRangeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button SignOutButton;
    }
}