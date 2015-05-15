namespace WindowsFormsApplication1
{
    partial class Calculadora
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
            this.Result = new System.Windows.Forms.TextBox();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Diminuir = new System.Windows.Forms.Button();
            this.Somar = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Porcent = new System.Windows.Forms.Button();
            this.Sen = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResultBin = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(3, 6);
            this.Result.MaxLength = 18;
            this.Result.Name = "Result";
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Result.Size = new System.Drawing.Size(459, 49);
            this.Result.TabIndex = 0;
            this.Result.Text = "0";
            this.Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aprovador);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(70, 184);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(60, 50);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Add);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(4, 184);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(60, 50);
            this.Seven.TabIndex = 2;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Add);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(136, 184);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(60, 50);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Add);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(4, 240);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(60, 50);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Add);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(70, 240);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(60, 50);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Add);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(136, 240);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(60, 50);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Add);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(4, 296);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(60, 50);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Add);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(70, 296);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(60, 50);
            this.Two.TabIndex = 8;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Add);
            // 
            // Tree
            // 
            this.Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tree.Location = new System.Drawing.Point(136, 296);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(60, 50);
            this.Tree.TabIndex = 9;
            this.Tree.Text = "3";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.Click += new System.EventHandler(this.Add);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(334, 296);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(126, 106);
            this.Equal.TabIndex = 10;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Total);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(4, 352);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(126, 50);
            this.Zero.TabIndex = 11;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Add);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Point.Location = new System.Drawing.Point(136, 352);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(60, 50);
            this.Point.TabIndex = 12;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Add);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(202, 184);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(60, 50);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.Location = new System.Drawing.Point(202, 240);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(60, 50);
            this.Mult.TabIndex = 14;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Diminuir
            // 
            this.Diminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diminuir.Location = new System.Drawing.Point(202, 296);
            this.Diminuir.Name = "Diminuir";
            this.Diminuir.Size = new System.Drawing.Size(60, 50);
            this.Diminuir.TabIndex = 15;
            this.Diminuir.Text = "-";
            this.Diminuir.UseVisualStyleBackColor = true;
            this.Diminuir.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Somar
            // 
            this.Somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somar.Location = new System.Drawing.Point(202, 352);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(60, 50);
            this.Somar.TabIndex = 16;
            this.Somar.Text = "+";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Potencia
            // 
            this.Potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Potencia.Location = new System.Drawing.Point(268, 184);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(60, 50);
            this.Potencia.TabIndex = 18;
            this.Potencia.Text = "^";
            this.Potencia.UseVisualStyleBackColor = true;
            this.Potencia.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Raiz
            // 
            this.Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.Location = new System.Drawing.Point(268, 240);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(60, 50);
            this.Raiz.TabIndex = 19;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Porcent
            // 
            this.Porcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcent.Location = new System.Drawing.Point(400, 128);
            this.Porcent.Name = "Porcent";
            this.Porcent.Size = new System.Drawing.Size(60, 50);
            this.Porcent.TabIndex = 20;
            this.Porcent.Text = "%";
            this.Porcent.UseVisualStyleBackColor = true;
            this.Porcent.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Sen
            // 
            this.Sen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sen.Location = new System.Drawing.Point(334, 128);
            this.Sen.Name = "Sen";
            this.Sen.Size = new System.Drawing.Size(60, 50);
            this.Sen.TabIndex = 21;
            this.Sen.Text = "Sen";
            this.Sen.UseVisualStyleBackColor = true;
            this.Sen.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cos.Location = new System.Drawing.Point(334, 184);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(60, 50);
            this.Cos.TabIndex = 22;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Tg
            // 
            this.Tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tg.Location = new System.Drawing.Point(334, 240);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(60, 50);
            this.Tg.TabIndex = 23;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Rest
            // 
            this.Rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rest.Location = new System.Drawing.Point(268, 128);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(60, 50);
            this.Rest.TabIndex = 24;
            this.Rest.Text = "Resto";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(70, 128);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(126, 50);
            this.Clear.TabIndex = 25;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Reset);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "±";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Negativar);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Backspace);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(268, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 50);
            this.button6.TabIndex = 31;
            this.button6.Text = "! Re";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(268, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 32;
            this.button3.Text = "! In";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(400, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 50);
            this.button4.TabIndex = 33;
            this.button4.Text = "Fi Re";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(400, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 50);
            this.button5.TabIndex = 34;
            this.button5.Text = "Fi In";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 434);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button22);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.ResultBin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Binario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button23);
            this.tabPage2.Controls.Add(this.Result);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.Eight);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.Seven);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.Nine);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.Four);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Five);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Six);
            this.tabPage2.Controls.Add(this.Clear);
            this.tabPage2.Controls.Add(this.One);
            this.tabPage2.Controls.Add(this.Rest);
            this.tabPage2.Controls.Add(this.Two);
            this.tabPage2.Controls.Add(this.Tg);
            this.tabPage2.Controls.Add(this.Tree);
            this.tabPage2.Controls.Add(this.Cos);
            this.tabPage2.Controls.Add(this.Equal);
            this.tabPage2.Controls.Add(this.Sen);
            this.tabPage2.Controls.Add(this.Zero);
            this.tabPage2.Controls.Add(this.Porcent);
            this.tabPage2.Controls.Add(this.Point);
            this.tabPage2.Controls.Add(this.Raiz);
            this.tabPage2.Controls.Add(this.Divide);
            this.tabPage2.Controls.Add(this.Potencia);
            this.tabPage2.Controls.Add(this.Mult);
            this.tabPage2.Controls.Add(this.Somar);
            this.tabPage2.Controls.Add(this.Diminuir);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decimal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResultBin
            // 
            this.ResultBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBin.Location = new System.Drawing.Point(3, 6);
            this.ResultBin.MaxLength = 18;
            this.ResultBin.Name = "ResultBin";
            this.ResultBin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResultBin.Size = new System.Drawing.Size(459, 49);
            this.ResultBin.TabIndex = 1;
            this.ResultBin.Text = "0";
            this.ResultBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Aprovador);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(4, 128);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 50);
            this.button11.TabIndex = 39;
            this.button11.Text = "←";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BackspaceBin);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(70, 128);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 50);
            this.button14.TabIndex = 38;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ResetBin);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(6, 296);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(126, 106);
            this.button15.TabIndex = 34;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.AddBin);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(138, 296);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(126, 106);
            this.button18.TabIndex = 37;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.AddBin);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(382, 72);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(76, 50);
            this.button20.TabIndex = 41;
            this.button20.Text = "ConvertToDec";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Add_simbolosBin);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(334, 184);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(126, 50);
            this.button21.TabIndex = 43;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Add_simbolosBin);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(334, 240);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(126, 50);
            this.button22.TabIndex = 42;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Add_simbolosBin);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(382, 72);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(76, 50);
            this.button23.TabIndex = 41;
            this.button23.Text = "ConvertToBin";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Add_simbolos);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(334, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 106);
            this.button7.TabIndex = 44;
            this.button7.Text = "=";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.TotalBin);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "Calculadora";
            this.Text = "Calculadora do Emanuel/Miller";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Tree;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Diminuir;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Porcent;
        private System.Windows.Forms.Button Sen;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ResultBin;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button23;
    }
}

