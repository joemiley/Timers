﻿namespace workout_Timer
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this._panel1_Menu = new System.Windows.Forms.Panel();
            this.panel1ButtonStart = new System.Windows.Forms.Button();
            this.panel1TextBoxNoOfRounds = new System.Windows.Forms.TextBox();
            this.panel1TextBoxRestAfterEachRound = new System.Windows.Forms.TextBox();
            this.panel1TextBoxRestBetweenExercises = new System.Windows.Forms.TextBox();
            this.panel1TextBoxSecPerExercise = new System.Windows.Forms.TextBox();
            this.panel1TextBoxNoOfExercises = new System.Windows.Forms.TextBox();
            this.panel1LabelNumberOfRounds = new System.Windows.Forms.Label();
            this.panel1LabelRestAfterEachRound = new System.Windows.Forms.Label();
            this.panel1LabelRestBetweenExercises = new System.Windows.Forms.Label();
            this.panel1LabelSecondsPerExercise = new System.Windows.Forms.Label();
            this.panel1LabelNumberOfExercises = new System.Windows.Forms.Label();
            this.panel1LabelInstructionsText = new System.Windows.Forms.Label();
            this.panel1LabelInstructionsTitle = new System.Windows.Forms.Label();
            this.panel1LabelTitle = new System.Windows.Forms.Label();
            this._panel2_PreStartCountdown = new System.Windows.Forms.Panel();
            this.panel2buttonStop = new System.Windows.Forms.Button();
            this.panel2LabelNoOfSeconds = new System.Windows.Forms.Label();
            this.panel2LabelCountDownToStart = new System.Windows.Forms.Label();
            this.panel2LabelTitle = new System.Windows.Forms.Label();
            this.panel2labelStart = new System.Windows.Forms.Label();
            this.timerCountDownToStart = new System.Windows.Forms.Timer(this.components);
            this._panel3_WorkoutPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3LabelGo = new System.Windows.Forms.Label();
            this.panel3buttonStop = new System.Windows.Forms.Button();
            this.panel3LabelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3LabelTitle = new System.Windows.Forms.Label();
            this.timerWork = new System.Windows.Forms.Timer(this.components);
            this._panel4_Rest = new System.Windows.Forms.Panel();
            this.panel4labelRest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4buttonStop = new System.Windows.Forms.Button();
            this.panel4labelTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4labelTime = new System.Windows.Forms.Label();
            this.timerRest = new System.Windows.Forms.Timer(this.components);
            this._panel5_RoundComplete = new System.Windows.Forms.Panel();
            this.panel5buttonStop = new System.Windows.Forms.Button();
            this.panel5labelTillNextRound = new System.Windows.Forms.Label();
            this.panel5labelRoundComplete = new System.Windows.Forms.Label();
            this.panel5labelTitle = new System.Windows.Forms.Label();
            this.panel5labelTime = new System.Windows.Forms.Label();
            this.timerRoundComplete = new System.Windows.Forms.Timer(this.components);
            this._panel1_Menu.SuspendLayout();
            this._panel2_PreStartCountdown.SuspendLayout();
            this._panel3_WorkoutPanel.SuspendLayout();
            this._panel4_Rest.SuspendLayout();
            this._panel5_RoundComplete.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel1_Menu
            // 
            this._panel1_Menu.BackColor = System.Drawing.SystemColors.Desktop;
            this._panel1_Menu.Controls.Add(this.panel1ButtonStart);
            this._panel1_Menu.Controls.Add(this.panel1TextBoxNoOfRounds);
            this._panel1_Menu.Controls.Add(this.panel1TextBoxRestAfterEachRound);
            this._panel1_Menu.Controls.Add(this.panel1TextBoxRestBetweenExercises);
            this._panel1_Menu.Controls.Add(this.panel1TextBoxSecPerExercise);
            this._panel1_Menu.Controls.Add(this.panel1TextBoxNoOfExercises);
            this._panel1_Menu.Controls.Add(this.panel1LabelNumberOfRounds);
            this._panel1_Menu.Controls.Add(this.panel1LabelRestAfterEachRound);
            this._panel1_Menu.Controls.Add(this.panel1LabelRestBetweenExercises);
            this._panel1_Menu.Controls.Add(this.panel1LabelSecondsPerExercise);
            this._panel1_Menu.Controls.Add(this.panel1LabelNumberOfExercises);
            this._panel1_Menu.Controls.Add(this.panel1LabelInstructionsText);
            this._panel1_Menu.Controls.Add(this.panel1LabelInstructionsTitle);
            this._panel1_Menu.Controls.Add(this.panel1LabelTitle);
            this._panel1_Menu.Location = new System.Drawing.Point(3, 3);
            this._panel1_Menu.Name = "_panel1_Menu";
            this._panel1_Menu.Size = new System.Drawing.Size(807, 454);
            this._panel1_Menu.TabIndex = 1;
            // 
            // panel1ButtonStart
            // 
            this.panel1ButtonStart.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1ButtonStart.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1ButtonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1ButtonStart.Location = new System.Drawing.Point(566, 351);
            this.panel1ButtonStart.Margin = new System.Windows.Forms.Padding(1);
            this.panel1ButtonStart.Name = "panel1ButtonStart";
            this.panel1ButtonStart.Size = new System.Drawing.Size(221, 73);
            this.panel1ButtonStart.TabIndex = 13;
            this.panel1ButtonStart.Text = "Start";
            this.panel1ButtonStart.UseVisualStyleBackColor = false;
            this.panel1ButtonStart.Click += new System.EventHandler(this.panel1ButtonStart_Click);
            // 
            // panel1TextBoxNoOfRounds
            // 
            this.panel1TextBoxNoOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1TextBoxNoOfRounds.Location = new System.Drawing.Point(672, 293);
            this.panel1TextBoxNoOfRounds.Name = "panel1TextBoxNoOfRounds";
            this.panel1TextBoxNoOfRounds.Size = new System.Drawing.Size(100, 38);
            this.panel1TextBoxNoOfRounds.TabIndex = 12;
            // 
            // panel1TextBoxRestAfterEachRound
            // 
            this.panel1TextBoxRestAfterEachRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1TextBoxRestAfterEachRound.Location = new System.Drawing.Point(436, 372);
            this.panel1TextBoxRestAfterEachRound.Name = "panel1TextBoxRestAfterEachRound";
            this.panel1TextBoxRestAfterEachRound.Size = new System.Drawing.Size(100, 38);
            this.panel1TextBoxRestAfterEachRound.TabIndex = 11;
            // 
            // panel1TextBoxRestBetweenExercises
            // 
            this.panel1TextBoxRestBetweenExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1TextBoxRestBetweenExercises.Location = new System.Drawing.Point(436, 293);
            this.panel1TextBoxRestBetweenExercises.Name = "panel1TextBoxRestBetweenExercises";
            this.panel1TextBoxRestBetweenExercises.Size = new System.Drawing.Size(100, 38);
            this.panel1TextBoxRestBetweenExercises.TabIndex = 10;
            // 
            // panel1TextBoxSecPerExercise
            // 
            this.panel1TextBoxSecPerExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1TextBoxSecPerExercise.Location = new System.Drawing.Point(180, 372);
            this.panel1TextBoxSecPerExercise.Name = "panel1TextBoxSecPerExercise";
            this.panel1TextBoxSecPerExercise.Size = new System.Drawing.Size(100, 38);
            this.panel1TextBoxSecPerExercise.TabIndex = 9;
            // 
            // panel1TextBoxNoOfExercises
            // 
            this.panel1TextBoxNoOfExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1TextBoxNoOfExercises.Location = new System.Drawing.Point(180, 293);
            this.panel1TextBoxNoOfExercises.Name = "panel1TextBoxNoOfExercises";
            this.panel1TextBoxNoOfExercises.Size = new System.Drawing.Size(100, 38);
            this.panel1TextBoxNoOfExercises.TabIndex = 8;
            // 
            // panel1LabelNumberOfRounds
            // 
            this.panel1LabelNumberOfRounds.AutoSize = true;
            this.panel1LabelNumberOfRounds.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelNumberOfRounds.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelNumberOfRounds.Location = new System.Drawing.Point(562, 291);
            this.panel1LabelNumberOfRounds.Name = "panel1LabelNumberOfRounds";
            this.panel1LabelNumberOfRounds.Size = new System.Drawing.Size(104, 40);
            this.panel1LabelNumberOfRounds.TabIndex = 7;
            this.panel1LabelNumberOfRounds.Text = "Number of \r\nrounds:";
            // 
            // panel1LabelRestAfterEachRound
            // 
            this.panel1LabelRestAfterEachRound.AutoSize = true;
            this.panel1LabelRestAfterEachRound.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelRestAfterEachRound.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelRestAfterEachRound.Location = new System.Drawing.Point(315, 370);
            this.panel1LabelRestAfterEachRound.Name = "panel1LabelRestAfterEachRound";
            this.panel1LabelRestAfterEachRound.Size = new System.Drawing.Size(115, 40);
            this.panel1LabelRestAfterEachRound.TabIndex = 6;
            this.panel1LabelRestAfterEachRound.Text = "Rest after \r\neach round:";
            // 
            // panel1LabelRestBetweenExercises
            // 
            this.panel1LabelRestBetweenExercises.AutoSize = true;
            this.panel1LabelRestBetweenExercises.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelRestBetweenExercises.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelRestBetweenExercises.Location = new System.Drawing.Point(309, 291);
            this.panel1LabelRestBetweenExercises.Name = "panel1LabelRestBetweenExercises";
            this.panel1LabelRestBetweenExercises.Size = new System.Drawing.Size(130, 40);
            this.panel1LabelRestBetweenExercises.TabIndex = 5;
            this.panel1LabelRestBetweenExercises.Text = "Rest between \r\nexercises:";
            // 
            // panel1LabelSecondsPerExercise
            // 
            this.panel1LabelSecondsPerExercise.AutoSize = true;
            this.panel1LabelSecondsPerExercise.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelSecondsPerExercise.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelSecondsPerExercise.Location = new System.Drawing.Point(62, 372);
            this.panel1LabelSecondsPerExercise.Name = "panel1LabelSecondsPerExercise";
            this.panel1LabelSecondsPerExercise.Size = new System.Drawing.Size(118, 40);
            this.panel1LabelSecondsPerExercise.TabIndex = 4;
            this.panel1LabelSecondsPerExercise.Text = "Seconds per \r\nexercise:";
            // 
            // panel1LabelNumberOfExercises
            // 
            this.panel1LabelNumberOfExercises.AutoSize = true;
            this.panel1LabelNumberOfExercises.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelNumberOfExercises.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelNumberOfExercises.Location = new System.Drawing.Point(62, 293);
            this.panel1LabelNumberOfExercises.Name = "panel1LabelNumberOfExercises";
            this.panel1LabelNumberOfExercises.Size = new System.Drawing.Size(101, 40);
            this.panel1LabelNumberOfExercises.TabIndex = 3;
            this.panel1LabelNumberOfExercises.Text = "Number of\r\nExercises:";
            // 
            // panel1LabelInstructionsText
            // 
            this.panel1LabelInstructionsText.AutoSize = true;
            this.panel1LabelInstructionsText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelInstructionsText.ForeColor = System.Drawing.Color.LawnGreen;
            this.panel1LabelInstructionsText.Location = new System.Drawing.Point(202, 126);
            this.panel1LabelInstructionsText.Name = "panel1LabelInstructionsText";
            this.panel1LabelInstructionsText.Size = new System.Drawing.Size(235, 20);
            this.panel1LabelInstructionsText.TabIndex = 2;
            this.panel1LabelInstructionsText.Text = "[input instructions here]";
            // 
            // panel1LabelInstructionsTitle
            // 
            this.panel1LabelInstructionsTitle.AutoSize = true;
            this.panel1LabelInstructionsTitle.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelInstructionsTitle.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelInstructionsTitle.Location = new System.Drawing.Point(36, 120);
            this.panel1LabelInstructionsTitle.Name = "panel1LabelInstructionsTitle";
            this.panel1LabelInstructionsTitle.Size = new System.Drawing.Size(163, 27);
            this.panel1LabelInstructionsTitle.TabIndex = 1;
            this.panel1LabelInstructionsTitle.Text = "instructions:";
            // 
            // panel1LabelTitle
            // 
            this.panel1LabelTitle.AutoSize = true;
            this.panel1LabelTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1LabelTitle.ForeColor = System.Drawing.Color.Aqua;
            this.panel1LabelTitle.Location = new System.Drawing.Point(205, 39);
            this.panel1LabelTitle.Name = "panel1LabelTitle";
            this.panel1LabelTitle.Size = new System.Drawing.Size(442, 60);
            this.panel1LabelTitle.TabIndex = 0;
            this.panel1LabelTitle.Text = "Workout Timer";
            // 
            // _panel2_PreStartCountdown
            // 
            this._panel2_PreStartCountdown.BackColor = System.Drawing.SystemColors.Desktop;
            this._panel2_PreStartCountdown.Controls.Add(this.panel2buttonStop);
            this._panel2_PreStartCountdown.Controls.Add(this.panel2LabelNoOfSeconds);
            this._panel2_PreStartCountdown.Controls.Add(this.panel2LabelCountDownToStart);
            this._panel2_PreStartCountdown.Controls.Add(this.panel2LabelTitle);
            this._panel2_PreStartCountdown.Controls.Add(this.panel2labelStart);
            this._panel2_PreStartCountdown.Location = new System.Drawing.Point(3, 3);
            this._panel2_PreStartCountdown.Name = "_panel2_PreStartCountdown";
            this._panel2_PreStartCountdown.Size = new System.Drawing.Size(807, 454);
            this._panel2_PreStartCountdown.TabIndex = 14;
            // 
            // panel2buttonStop
            // 
            this.panel2buttonStop.BackColor = System.Drawing.Color.Red;
            this.panel2buttonStop.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2buttonStop.Location = new System.Drawing.Point(566, 351);
            this.panel2buttonStop.Margin = new System.Windows.Forms.Padding(1);
            this.panel2buttonStop.Name = "panel2buttonStop";
            this.panel2buttonStop.Size = new System.Drawing.Size(221, 73);
            this.panel2buttonStop.TabIndex = 13;
            this.panel2buttonStop.Text = "Stop";
            this.panel2buttonStop.UseVisualStyleBackColor = false;
            this.panel2buttonStop.Click += new System.EventHandler(this.panel2buttonStop_Click);
            // 
            // panel2LabelNoOfSeconds
            // 
            this.panel2LabelNoOfSeconds.AutoSize = true;
            this.panel2LabelNoOfSeconds.BackColor = System.Drawing.Color.Transparent;
            this.panel2LabelNoOfSeconds.Font = new System.Drawing.Font("Stencil", 150F);
            this.panel2LabelNoOfSeconds.ForeColor = System.Drawing.Color.Aqua;
            this.panel2LabelNoOfSeconds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel2LabelNoOfSeconds.Location = new System.Drawing.Point(304, 163);
            this.panel2LabelNoOfSeconds.Name = "panel2LabelNoOfSeconds";
            this.panel2LabelNoOfSeconds.Size = new System.Drawing.Size(215, 237);
            this.panel2LabelNoOfSeconds.TabIndex = 14;
            this.panel2LabelNoOfSeconds.Text = "3";
            this.panel2LabelNoOfSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2LabelCountDownToStart
            // 
            this.panel2LabelCountDownToStart.AutoSize = true;
            this.panel2LabelCountDownToStart.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2LabelCountDownToStart.ForeColor = System.Drawing.Color.Aqua;
            this.panel2LabelCountDownToStart.Location = new System.Drawing.Point(44, 131);
            this.panel2LabelCountDownToStart.Name = "panel2LabelCountDownToStart";
            this.panel2LabelCountDownToStart.Size = new System.Drawing.Size(257, 27);
            this.panel2LabelCountDownToStart.TabIndex = 1;
            this.panel2LabelCountDownToStart.Text = "Count down to start:";
            // 
            // panel2LabelTitle
            // 
            this.panel2LabelTitle.AutoSize = true;
            this.panel2LabelTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2LabelTitle.ForeColor = System.Drawing.Color.Aqua;
            this.panel2LabelTitle.Location = new System.Drawing.Point(214, 36);
            this.panel2LabelTitle.Name = "panel2LabelTitle";
            this.panel2LabelTitle.Size = new System.Drawing.Size(442, 60);
            this.panel2LabelTitle.TabIndex = 0;
            this.panel2LabelTitle.Text = "Workout Timer";
            // 
            // panel2labelStart
            // 
            this.panel2labelStart.AutoSize = true;
            this.panel2labelStart.BackColor = System.Drawing.Color.Transparent;
            this.panel2labelStart.Font = new System.Drawing.Font("Stencil", 140F);
            this.panel2labelStart.ForeColor = System.Drawing.Color.Aqua;
            this.panel2labelStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel2labelStart.Location = new System.Drawing.Point(97, 163);
            this.panel2labelStart.Name = "panel2labelStart";
            this.panel2labelStart.Size = new System.Drawing.Size(667, 222);
            this.panel2labelStart.TabIndex = 15;
            this.panel2labelStart.Text = "start";
            this.panel2labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panel2labelStart.Visible = false;
            // 
            // timerCountDownToStart
            // 
            this.timerCountDownToStart.Interval = 1000;
            this.timerCountDownToStart.Tick += new System.EventHandler(this.timerCountDownToStart_Tick_1);
            // 
            // _panel3_WorkoutPanel
            // 
            this._panel3_WorkoutPanel.BackColor = System.Drawing.Color.Maroon;
            this._panel3_WorkoutPanel.Controls.Add(this.label2);
            this._panel3_WorkoutPanel.Controls.Add(this.panel3LabelGo);
            this._panel3_WorkoutPanel.Controls.Add(this.panel3buttonStop);
            this._panel3_WorkoutPanel.Controls.Add(this.panel3LabelTime);
            this._panel3_WorkoutPanel.Controls.Add(this.label1);
            this._panel3_WorkoutPanel.Controls.Add(this.panel3LabelTitle);
            this._panel3_WorkoutPanel.Location = new System.Drawing.Point(3, 3);
            this._panel3_WorkoutPanel.Name = "_panel3_WorkoutPanel";
            this._panel3_WorkoutPanel.Size = new System.Drawing.Size(807, 454);
            this._panel3_WorkoutPanel.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 50.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "Go!";
            // 
            // panel3LabelGo
            // 
            this.panel3LabelGo.AutoSize = true;
            this.panel3LabelGo.Font = new System.Drawing.Font("Showcard Gothic", 50.75F);
            this.panel3LabelGo.ForeColor = System.Drawing.Color.White;
            this.panel3LabelGo.Location = new System.Drawing.Point(306, 99);
            this.panel3LabelGo.Name = "panel3LabelGo";
            this.panel3LabelGo.Size = new System.Drawing.Size(158, 84);
            this.panel3LabelGo.TabIndex = 1;
            this.panel3LabelGo.Text = "Go!";
            // 
            // panel3buttonStop
            // 
            this.panel3buttonStop.BackColor = System.Drawing.Color.Red;
            this.panel3buttonStop.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3buttonStop.Location = new System.Drawing.Point(566, 351);
            this.panel3buttonStop.Margin = new System.Windows.Forms.Padding(1);
            this.panel3buttonStop.Name = "panel3buttonStop";
            this.panel3buttonStop.Size = new System.Drawing.Size(221, 73);
            this.panel3buttonStop.TabIndex = 13;
            this.panel3buttonStop.Text = "Stop";
            this.panel3buttonStop.UseVisualStyleBackColor = false;
            this.panel3buttonStop.Click += new System.EventHandler(this.panel3buttonStop_Click);
            // 
            // panel3LabelTime
            // 
            this.panel3LabelTime.AutoSize = true;
            this.panel3LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.panel3LabelTime.Font = new System.Drawing.Font("Stencil", 170F);
            this.panel3LabelTime.ForeColor = System.Drawing.Color.White;
            this.panel3LabelTime.Location = new System.Drawing.Point(253, 145);
            this.panel3LabelTime.Name = "panel3LabelTime";
            this.panel3LabelTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3LabelTime.Size = new System.Drawing.Size(373, 269);
            this.panel3LabelTime.TabIndex = 14;
            this.panel3LabelTime.Text = "00";
            this.panel3LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workout Timer";
            // 
            // panel3LabelTitle
            // 
            this.panel3LabelTitle.AutoSize = true;
            this.panel3LabelTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3LabelTitle.ForeColor = System.Drawing.Color.White;
            this.panel3LabelTitle.Location = new System.Drawing.Point(191, 39);
            this.panel3LabelTitle.Name = "panel3LabelTitle";
            this.panel3LabelTitle.Size = new System.Drawing.Size(442, 60);
            this.panel3LabelTitle.TabIndex = 0;
            this.panel3LabelTitle.Text = "Workout Timer";
            // 
            // timerWork
            // 
            this.timerWork.Interval = 1000;
            this.timerWork.Tick += new System.EventHandler(this.timerWork_Tick);
            // 
            // _panel4_Rest
            // 
            this._panel4_Rest.BackColor = System.Drawing.Color.MidnightBlue;
            this._panel4_Rest.Controls.Add(this.panel4labelRest);
            this._panel4_Rest.Controls.Add(this.label4);
            this._panel4_Rest.Controls.Add(this.panel4buttonStop);
            this._panel4_Rest.Controls.Add(this.panel4labelTitle);
            this._panel4_Rest.Controls.Add(this.label7);
            this._panel4_Rest.Controls.Add(this.panel4labelTime);
            this._panel4_Rest.Location = new System.Drawing.Point(3, 3);
            this._panel4_Rest.Name = "_panel4_Rest";
            this._panel4_Rest.Size = new System.Drawing.Size(807, 454);
            this._panel4_Rest.TabIndex = 17;
            // 
            // panel4labelRest
            // 
            this.panel4labelRest.AutoSize = true;
            this.panel4labelRest.Font = new System.Drawing.Font("Showcard Gothic", 50.75F);
            this.panel4labelRest.ForeColor = System.Drawing.Color.White;
            this.panel4labelRest.Location = new System.Drawing.Point(292, 99);
            this.panel4labelRest.Name = "panel4labelRest";
            this.panel4labelRest.Size = new System.Drawing.Size(196, 84);
            this.panel4labelRest.TabIndex = 1;
            this.panel4labelRest.Text = "Rest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 50.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 84);
            this.label4.TabIndex = 1;
            this.label4.Text = "Go!";
            // 
            // panel4buttonStop
            // 
            this.panel4buttonStop.BackColor = System.Drawing.Color.Red;
            this.panel4buttonStop.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4buttonStop.Location = new System.Drawing.Point(566, 351);
            this.panel4buttonStop.Margin = new System.Windows.Forms.Padding(1);
            this.panel4buttonStop.Name = "panel4buttonStop";
            this.panel4buttonStop.Size = new System.Drawing.Size(221, 73);
            this.panel4buttonStop.TabIndex = 13;
            this.panel4buttonStop.Text = "Stop";
            this.panel4buttonStop.UseVisualStyleBackColor = false;
            this.panel4buttonStop.Click += new System.EventHandler(this.panel4buttonStop_Click);
            // 
            // panel4labelTitle
            // 
            this.panel4labelTitle.AutoSize = true;
            this.panel4labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4labelTitle.ForeColor = System.Drawing.Color.White;
            this.panel4labelTitle.Location = new System.Drawing.Point(178, 39);
            this.panel4labelTitle.Name = "panel4labelTitle";
            this.panel4labelTitle.Size = new System.Drawing.Size(442, 60);
            this.panel4labelTitle.TabIndex = 0;
            this.panel4labelTitle.Text = "Workout Timer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(191, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(442, 60);
            this.label7.TabIndex = 0;
            this.label7.Text = "Workout Timer";
            // 
            // panel4labelTime
            // 
            this.panel4labelTime.AutoSize = true;
            this.panel4labelTime.BackColor = System.Drawing.Color.Transparent;
            this.panel4labelTime.Font = new System.Drawing.Font("Stencil", 170F);
            this.panel4labelTime.ForeColor = System.Drawing.Color.White;
            this.panel4labelTime.Location = new System.Drawing.Point(236, 153);
            this.panel4labelTime.Name = "panel4labelTime";
            this.panel4labelTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4labelTime.Size = new System.Drawing.Size(373, 269);
            this.panel4labelTime.TabIndex = 14;
            this.panel4labelTime.Text = "00";
            this.panel4labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRest
            // 
            this.timerRest.Interval = 1000;
            this.timerRest.Tick += new System.EventHandler(this.timerRest_Tick);
            // 
            // _panel5_RoundComplete
            // 
            this._panel5_RoundComplete.BackColor = System.Drawing.SystemColors.Desktop;
            this._panel5_RoundComplete.Controls.Add(this.panel5buttonStop);
            this._panel5_RoundComplete.Controls.Add(this.panel5labelTillNextRound);
            this._panel5_RoundComplete.Controls.Add(this.panel5labelRoundComplete);
            this._panel5_RoundComplete.Controls.Add(this.panel5labelTitle);
            this._panel5_RoundComplete.Controls.Add(this.panel5labelTime);
            this._panel5_RoundComplete.Location = new System.Drawing.Point(3, 3);
            this._panel5_RoundComplete.Name = "_panel5_RoundComplete";
            this._panel5_RoundComplete.Size = new System.Drawing.Size(807, 454);
            this._panel5_RoundComplete.TabIndex = 14;
            // 
            // panel5buttonStop
            // 
            this.panel5buttonStop.BackColor = System.Drawing.Color.Red;
            this.panel5buttonStop.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5buttonStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5buttonStop.Location = new System.Drawing.Point(566, 349);
            this.panel5buttonStop.Margin = new System.Windows.Forms.Padding(1);
            this.panel5buttonStop.Name = "panel5buttonStop";
            this.panel5buttonStop.Size = new System.Drawing.Size(221, 73);
            this.panel5buttonStop.TabIndex = 16;
            this.panel5buttonStop.Text = "Stop";
            this.panel5buttonStop.UseVisualStyleBackColor = false;
            this.panel5buttonStop.Click += new System.EventHandler(this.panel5buttonStop_Click);
            // 
            // panel5labelTillNextRound
            // 
            this.panel5labelTillNextRound.AutoSize = true;
            this.panel5labelTillNextRound.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5labelTillNextRound.ForeColor = System.Drawing.Color.Aqua;
            this.panel5labelTillNextRound.Location = new System.Drawing.Point(307, 351);
            this.panel5labelTillNextRound.Name = "panel5labelTillNextRound";
            this.panel5labelTillNextRound.Size = new System.Drawing.Size(187, 27);
            this.panel5labelTillNextRound.TabIndex = 14;
            this.panel5labelTillNextRound.Text = "Till Next Round";
            // 
            // panel5labelRoundComplete
            // 
            this.panel5labelRoundComplete.AutoSize = true;
            this.panel5labelRoundComplete.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5labelRoundComplete.ForeColor = System.Drawing.Color.Aqua;
            this.panel5labelRoundComplete.Location = new System.Drawing.Point(309, 119);
            this.panel5labelRoundComplete.Name = "panel5labelRoundComplete";
            this.panel5labelRoundComplete.Size = new System.Drawing.Size(203, 27);
            this.panel5labelRoundComplete.TabIndex = 1;
            this.panel5labelRoundComplete.Text = "Round Complete:";
            // 
            // panel5labelTitle
            // 
            this.panel5labelTitle.AutoSize = true;
            this.panel5labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5labelTitle.ForeColor = System.Drawing.Color.Aqua;
            this.panel5labelTitle.Location = new System.Drawing.Point(205, 39);
            this.panel5labelTitle.Name = "panel5labelTitle";
            this.panel5labelTitle.Size = new System.Drawing.Size(442, 60);
            this.panel5labelTitle.TabIndex = 0;
            this.panel5labelTitle.Text = "Workout Timer";
            // 
            // panel5labelTime
            // 
            this.panel5labelTime.AutoSize = true;
            this.panel5labelTime.BackColor = System.Drawing.Color.Transparent;
            this.panel5labelTime.Font = new System.Drawing.Font("Stencil", 170F);
            this.panel5labelTime.ForeColor = System.Drawing.Color.White;
            this.panel5labelTime.Location = new System.Drawing.Point(231, 120);
            this.panel5labelTime.Name = "panel5labelTime";
            this.panel5labelTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5labelTime.Size = new System.Drawing.Size(373, 269);
            this.panel5labelTime.TabIndex = 15;
            this.panel5labelTime.Text = "00";
            this.panel5labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRoundComplete
            // 
            this.timerRoundComplete.Interval = 1000;
            this.timerRoundComplete.Tick += new System.EventHandler(this.timerRoundComplete_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 459);
            this.Controls.Add(this._panel5_RoundComplete);
            this.Controls.Add(this._panel1_Menu);
            this.Controls.Add(this._panel2_PreStartCountdown);
            this.Controls.Add(this._panel3_WorkoutPanel);
            this.Controls.Add(this._panel4_Rest);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workout Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._panel1_Menu.ResumeLayout(false);
            this._panel1_Menu.PerformLayout();
            this._panel2_PreStartCountdown.ResumeLayout(false);
            this._panel2_PreStartCountdown.PerformLayout();
            this._panel3_WorkoutPanel.ResumeLayout(false);
            this._panel3_WorkoutPanel.PerformLayout();
            this._panel4_Rest.ResumeLayout(false);
            this._panel4_Rest.PerformLayout();
            this._panel5_RoundComplete.ResumeLayout(false);
            this._panel5_RoundComplete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel1_Menu;
        private System.Windows.Forms.Button panel1ButtonStart;
        private System.Windows.Forms.TextBox panel1TextBoxNoOfRounds;
        private System.Windows.Forms.TextBox panel1TextBoxRestAfterEachRound;
        private System.Windows.Forms.TextBox panel1TextBoxRestBetweenExercises;
        private System.Windows.Forms.TextBox panel1TextBoxSecPerExercise;
        private System.Windows.Forms.TextBox panel1TextBoxNoOfExercises;
        private System.Windows.Forms.Label panel1LabelNumberOfRounds;
        private System.Windows.Forms.Label panel1LabelRestAfterEachRound;
        private System.Windows.Forms.Label panel1LabelRestBetweenExercises;
        private System.Windows.Forms.Label panel1LabelSecondsPerExercise;
        private System.Windows.Forms.Label panel1LabelNumberOfExercises;
        private System.Windows.Forms.Label panel1LabelInstructionsText;
        private System.Windows.Forms.Label panel1LabelInstructionsTitle;
        private System.Windows.Forms.Label panel1LabelTitle;
        private System.Windows.Forms.Panel _panel2_PreStartCountdown;
        private System.Windows.Forms.Button panel2buttonStop;
        private System.Windows.Forms.Label panel2LabelCountDownToStart;
        private System.Windows.Forms.Label panel2LabelTitle;
        public System.Windows.Forms.Label panel2LabelNoOfSeconds;
        private System.Windows.Forms.Timer timerCountDownToStart;
        public System.Windows.Forms.Label panel2labelStart;
        private System.Windows.Forms.Panel _panel3_WorkoutPanel;
        private System.Windows.Forms.Label panel3LabelGo;
        private System.Windows.Forms.Button panel3buttonStop;
        public System.Windows.Forms.Label panel3LabelTime;
        private System.Windows.Forms.Label panel3LabelTitle;
        private System.Windows.Forms.Timer timerWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _panel4_Rest;
        private System.Windows.Forms.Label panel4labelRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button panel4buttonStop;
        private System.Windows.Forms.Label panel4labelTitle;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label panel4labelTime;
        private System.Windows.Forms.Timer timerRest;
        private System.Windows.Forms.Panel _panel5_RoundComplete;
        private System.Windows.Forms.Button panel5buttonStop;
        private System.Windows.Forms.Label panel5labelTillNextRound;
        private System.Windows.Forms.Label panel5labelRoundComplete;
        private System.Windows.Forms.Label panel5labelTitle;
        public System.Windows.Forms.Label panel5labelTime;
        private System.Windows.Forms.Timer timerRoundComplete;
    }
}

