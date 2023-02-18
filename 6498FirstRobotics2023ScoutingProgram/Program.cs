﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6498FirstRobotics2023ScoutingProgram.Program;
namespace _6498FirstRobotics2023ScoutingProgram
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmData());
        }

        #region Form non-specific methods
        /* I've moved this out of the form class and into the program class
         * since it doesn't actually relate to the form itself.  Mostly just an organizational thing.
         * Also setting it to accept the csv dictionary variable as an input so it can use it from outside
         * of the form like expected.
         */
        internal static void RecordDataIntoCSV(Dictionary<string, List<string>> csvData)
        {
            #region inefficient, improving with the use of dictionaries
            //string autoHighCones, autoMidCones, autoLowCones, autoHighCubes, autoMidCubes, autoLowCubes = "";
            //string teleHighCones, teleMidCones, teleLowCones, teleHighCubes, teleMidCubes, teleLowCubes = "";
            //string teamNumber = "";
            //string matchNumber = "";
            //string position, autoBalance, endBalance = "";
            //string mobility, links, parked, floorIntake, shelfIntake = "";

            //teamNumber = txtTeamNumber.Text;
            //position = cmbPosition.Text;
            //matchNumber = txtMatchNumber.Text;

            //autoHighCones = txtAutoHighCones.Text;
            //autoMidCones= txtAutoMidCones.Text;
            //autoLowCones = txtAutoLowCones.Text;

            //autoHighCubes = txtAutoHighCubes.Text;
            //autoMidCubes = txtAutoMidCubes.Text;
            //autoLowCubes = txtAutoLowCubes.Text;

            //autoBalance = cmbAutoCharge.Text;

            //mobility = chkMobility.Checked.ToString();

            //teleHighCones = txtTeleHighCones.Text;
            //teleMidCones= txtTeleMidCones.Text;
            //teleLowCones= txtTeleLowCones.Text;

            //teleHighCubes = txtTeleHighCubes.Text;
            //teleMidCubes = txtTeleMidCubes.Text;
            //teleLowCubes = txtTeleLowCubes.Text;

            //links = chkLink.Checked.ToString();
            //endBalance = cmbEndGameChargingStation.Text;
            //parked = chkPark.Checked.ToString();

            //floorIntake = chkFloor.Checked.ToString();
            //shelfIntake = chkShelf.Checked.ToString();

            //string header = "Team Number,Position,Match Number,Mobility Achieved,Auto High Cones,Auto Mid Cones,Auto Low Cones,Auto High Cubes,Auto Mid Cubes,Auto Low Cubes,Auto Charging Station Position,Tele High Cones,Tele Mid Cones,Tele Low Cones,Tele High Cubes,Tele Mid Cubes,Tele Low Cubes,End Game Charging Station,Link Coordination,Parked,Floor Pickup,Shelf Pickup,Notes";
            #endregion

            string header = "";

            foreach (KeyValuePair<string, List<string>> i in csvData)
            {
                header += (i.Key + ",");
            }
            MessageBox.Show(header);

        }
        #endregion
    }



}
