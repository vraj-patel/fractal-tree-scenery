using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pythagoras_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        static Bitmap drawSceneBtmp = new Bitmap(790, 450);

        float branchAngle = Convert.ToSingle(-Math.PI / 4); 

        // Graphics and brush specifically for drawing the trees 
        Graphics drawTreesGraphic = Graphics.FromImage(drawSceneBtmp);
        SolidBrush brushForTrees = new SolidBrush(Color.Green);

        // Graphics specifically for drawing either sun or moon
        Graphics drawSunAndMoon = Graphics.FromImage(drawSceneBtmp); 
        SolidBrush brushForSunAndMoon = new SolidBrush(Color.Orange); 

        /* 0.002 radians is approximately 0.1°. The timer ticks every 10th of a second. Therefore, the default 
        speed is approximately 1°/second      */
        float windSpeed = 0.002f;

        /* The Animation Button draws trees of random position and size (both are restricted within a range)
         * In order to preserve this information (position and size of each tree) during animation, these arrays
         * are used */
        int[] storeAllPositions = new int[5];
        int[] storeAllSizes = new int[5];

        /* These 3 branch/leaf colours represent the colours within each tree, branchColour1 being the most 
         * outward leaf/branch layer. */
        Color branchColor1 = Color.Green;
        Color branchColor2 = Color.OrangeRed;
        Color branchColor3 = Color.DarkGreen;


        // Method in charge of drawing the tree using recursion 
        private void drawTree(float x1, float y1, float angle, float sideLength, int iterations)
        {
            // decide the colour based on the value of iteration - or the level of branches being drawn
            if (iterations <= 8 && iterations >= 6)
                brushForTrees.Color = Color.SaddleBrown;

            else if (iterations < 6 && iterations >= 4)
                brushForTrees.Color = branchColor3;

            else if (iterations < 4 && iterations >= 2)
                brushForTrees.Color = branchColor2;

            else if (iterations < 2 && iterations > 0)
                brushForTrees.Color = branchColor1;


            drawTreesGraphic.FillRectangle(brushForTrees, 0, -sideLength, sideLength, sideLength);
            drawTreesGraphic.TranslateTransform(0, -sideLength);

            if (iterations > 0)
            {
                // Saves the state of the graphic while drawing only the right squares 
                GraphicsState gsForRightSquares = drawTreesGraphic.Save();

                float sideLength2 = Convert.ToSingle(Math.Abs(Math.Cos(branchAngle) * sideLength)),
                    angle2 = branchAngle;

                drawTreesGraphic.RotateTransform(Convert.ToSingle(180 * (angle2 / Math.PI)));
                drawTree(0, -sideLength, angle2, sideLength2, iterations - 1);

                drawTreesGraphic.Restore(gsForRightSquares);

                /* Restores (refer to method above) and saves (refer to method below) the graphic to the 
                previous state */

                // This section draws the left sided branches of the tree
                GraphicsState gsForLeftSquares = drawTreesGraphic.Save();

                float x3 = Convert.ToSingle(sideLength2 * Math.Cos(-branchAngle)),
                        y3 = -(Convert.ToSingle(sideLength2 * Math.Sin(-branchAngle))),
                        sideLength3 = Convert.ToSingle(Math.Abs(Math.Tan(-branchAngle) * sideLength2)),
                        angle3 = Convert.ToSingle(Math.PI / 2 - (-branchAngle));

                drawTreesGraphic.TranslateTransform(x3, y3);
                drawTreesGraphic.RotateTransform(Convert.ToSingle(180 * (angle3 / Math.PI)));
                drawTree(x3, y3, angle3, sideLength3, iterations - 1);

                drawTreesGraphic.Restore(gsForLeftSquares);

            }

        }

        // Deals with any change wihtin the scenery the user makes 
        private void changeSceneSettings()
        {
            if (TimeOfDayListBox.SelectedIndex == 0)
                EntireScenePicBox.BackColor = Color.LightSkyBlue;
            else if (TimeOfDayListBox.SelectedIndex == 1)
                EntireScenePicBox.BackColor = Color.Black;

            if (WinterRButton.Checked)
            {
                branchColor1 = Color.White;
                branchColor2 = Color.White;
                branchColor3 = Color.White;
            }
            else if (SpringRButton.Checked)
            {
                branchColor1 = Color.OrangeRed;
                branchColor2 = Color.Green;
                branchColor3 = Color.DarkGreen;
            }
            else if (FallRButton.Checked)
            {
                branchColor1 = Color.DarkOrange;
                branchColor2 = Color.DarkOrange;
                branchColor3 = Color.Green;
            }
            else if (SummerRButton.Checked)
            {
                branchColor1 = Color.LightGreen;
                branchColor2 = Color.Green;
                branchColor3 = Color.Green;
            }

        }

        // Draws the moon
        private void drawMoon(int posX, int posY)
        {
            brushForSunAndMoon.Color = Color.LightGray;
            drawSunAndMoon.FillEllipse(brushForSunAndMoon, posX - 75, posY - 75, 150, 150);
        }

        // Draws the sun
        private void drawSun(int posX, int posY)
        {
            brushForSunAndMoon.Color = Color.Orange;

            // Saves and restores the graphic state for the next method call. 

            GraphicsState gsForSun = drawSunAndMoon.Save();
            drawSunAndMoon.TranslateTransform(posX, posY);


            Point[] pointsForSun = { new Point(0 - 20, 0), new Point(0 + 20, 0), new Point(0, 0 + 75) };

            // Draws the sun by drawing triangles and rotating them 
            for (int counter = 1; counter <= 72; counter++)
            {
                drawSunAndMoon.FillPolygon(brushForSunAndMoon, pointsForSun);
                drawSunAndMoon.RotateTransform(5f);
            }

            drawSunAndMoon.Restore(gsForSun);

        }

        // This event randomly chooses the position and size of the trees and saves them within the 2 arrays 
        private void AnimationButton_Click(object sender, EventArgs e)
        {
             
            Random rndXPosAndSize = new Random();
            GraphicsState gsOfDrawnTrees = drawTreesGraphic.Save();

            int xPos = 50;
            int treeSize = 40;
           

            for (int numOfTrees = 1; numOfTrees <= 5; numOfTrees++)
            {
                storeAllPositions[numOfTrees-1] = xPos;
                storeAllSizes[numOfTrees-1] = treeSize;

                gsOfDrawnTrees = drawTreesGraphic.Save();

                drawTreesGraphic.TranslateTransform(xPos, EntireScenePicBox.Height);
                drawTree(xPos, EntireScenePicBox.Height, 0, treeSize, 8);

                drawTreesGraphic.Restore(gsOfDrawnTrees);

                xPos += rndXPosAndSize.Next(100, 200);                
                treeSize += rndXPosAndSize.Next(-5, 12);
                
            }

            AnimationTimer.Enabled = true;
            AnimationTimer.Start(); 
        }

        // Draws the scenery and changes the angle each time the clock ticks
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {

            drawTreesGraphic.Clear(EntireScenePicBox.BackColor);

            changeSceneSettings();
            if (EntireScenePicBox.BackColor == Color.LightSkyBlue)
                drawSun(100, 100);
            else if (EntireScenePicBox.BackColor == Color.Black)
                drawMoon(100, 100); 


            GraphicsState gsOverall2 = drawTreesGraphic.Save();

            // Changes windspeed direction if it reaches the following angles: 36° and -36°
            if (branchAngle >= -Math.PI / 5 || branchAngle <= -Math.PI/2 + Math.PI/5) // change this to change wind speed
                windSpeed = -windSpeed;

            branchAngle += windSpeed; 

            // draws the identical scenery with position and size store within the array
            for (int counter = 0; counter < storeAllPositions.Length; counter++)
            {
                gsOverall2 = drawTreesGraphic.Save();

                drawTreesGraphic.TranslateTransform(storeAllPositions[counter], EntireScenePicBox.Height);
                drawTree(storeAllPositions[counter], EntireScenePicBox.Height, 0, storeAllSizes[counter], 8);

                drawTreesGraphic.Restore(gsOverall2);
            }

            EntireScenePicBox.Image = drawSceneBtmp;
        }

        // Calculates windspeed depending on the position of WindTrackBar. 
        private void WindTrackBar_Scroll(object sender, EventArgs e)
        {
            windSpeed = (WindTrackBar.Value + 1)*0.002f;
        }

        
    }
}


