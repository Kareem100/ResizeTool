using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ResizeTool
{
    public partial class HomeForm : Form
    {
        string currentImagePath;
        private static int noCurrentDisplay = -1;
        private static int developersCurrentDisplay = 0;
        private static int usersCurrentDisplay = 1;
        private int currentDisplay;
        private bool columnsWork;

        public HomeForm()
        {
            InitializeComponent();
            currentImagePath = null;
            currentDisplay = noCurrentDisplay;
            columnsWork = true;
        }

        private void columnsWorkButton_Click(object sender, EventArgs e)
        {
            columnsWork = true;
            columnsWorkButton.BackColor = Color.Black;
            rowsWorkButton.BackColor = Color.DimGray;
            horizontalSeamsText.Text = "0";
            verticalSeamsText.Enabled = true;
            horizontalSeamsText.Enabled = false;
        }

        private void rowsWorkButton_Click(object sender, EventArgs e)
        {
            columnsWork = false;
            columnsWorkButton.BackColor = Color.DimGray;
            rowsWorkButton.BackColor = Color.Black;
            verticalSeamsText.Text = "0";
            verticalSeamsText.Enabled = false;
            horizontalSeamsText.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            originalPictureBox.Image = null;
            resultedPictureBox.Image = null;
            columnsWork = true;
            columnsWorkButton.BackColor = Color.Black;
            rowsWorkButton.BackColor = Color.DimGray;
            settingsButton.Text = "M A N I P U L A T E  S E T T I N G S";
            groupBox.Enabled = false;
            groupBox.Visible = false;
            verticalSeamsText.Text = "1";
            horizontalSeamsText.Text = "0";
            verticalSeamsText.Enabled = true;
            horizontalSeamsText.Enabled = false;
        }

        private void browseDevelopersButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resizeCurrentButton.Text = "Removed Current Seams";
                currentImagePath = dialog.FileName;
                currentDisplay = developersCurrentDisplay;
                developersDisplay(currentImagePath);
            }
        }

        private void browseUsersButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                resizeCurrentButton.Text = "Resize Current";
                currentImagePath = dialog.FileName;
                currentDisplay = usersCurrentDisplay;
                usersDisplay(currentImagePath);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                resultedPictureBox.Image.Save(dialog.FileName + ".jpeg", ImageFormat.Jpeg);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (!groupBox.Enabled)
            {
                groupBox.Enabled = true;
                groupBox.Visible = true;
                settingsButton.Text = "H I D E  S E T T I N G S";
            }
            else
            {
                groupBox.Enabled = false;
                groupBox.Visible = false;
                settingsButton.Text = "M A N I P U L A T E  S E T T I N G S";
            }
        }

        private void resizeCurrentButton_Click(object sender, EventArgs e)
        {
            if (currentDisplay == developersCurrentDisplay)
                developersDisplay(currentImagePath);
            else if (currentDisplay == usersCurrentDisplay)
                usersDisplay(currentImagePath);
        }

        private void developersDisplay(string imagePath)
        {
            if (verticalSeamsText.Text.Equals("")) verticalSeamsText.Text = "1";
            if (horizontalSeamsText.Text.Equals("")) horizontalSeamsText.Text = "1";
            int numOfVerticalSeams = int.Parse(verticalSeamsText.Text);
            int numOfHorizontalSeams = int.Parse(horizontalSeamsText.Text);
            ImageAwareResize IAR = new ImageAwareResize(imagePath);
            ImageUtils.DisplayImage(IAR.imageMatrix, originalPictureBox);

            // The seams with the original image
            int Width = IAR.imageMatrix.GetLength(1);
            int Height = IAR.imageMatrix.GetLength(0);
            if (columnsWork)
            {
                IAR.calculateVertIndexMat(numOfVerticalSeams);
                ImageUtils.DisplayEnergy(IAR.vertIndexMat, resultedPictureBox);
                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                        if (IAR.vertIndexMat[i, j] != int.MaxValue)
                        {
                            IAR.imageMatrix[i, j].R = 0;
                            IAR.imageMatrix[i, j].G = 0;
                            IAR.imageMatrix[i, j].B = 0;
                        }
            }
            else
            {
                IAR.calculateHorzIndexMat(numOfHorizontalSeams);
                ImageUtils.DisplayEnergy(IAR.horzIndexMat, resultedPictureBox);
                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                        if (IAR.horzIndexMat[i, j] != int.MaxValue)
                        {
                            IAR.imageMatrix[i, j].R = 0;
                            IAR.imageMatrix[i, j].G = 0;
                            IAR.imageMatrix[i, j].B = 0;
                        }
            }
            
            ImageUtils.DisplayImage(IAR.imageMatrix, originalPictureBox);
        }

        private void usersDisplay(string imagePath)
        {
            if (verticalSeamsText.Text.Equals("")) verticalSeamsText.Text = "1";
            if (horizontalSeamsText.Text.Equals("")) horizontalSeamsText.Text = "1";
            int numOfVerticalSeams = int.Parse(verticalSeamsText.Text);
            int numOfHorizontalSeams = int.Parse(horizontalSeamsText.Text);

            ImageAwareResize IAR = new ImageAwareResize(imagePath);
            ImageUtils.DisplayImage(IAR.imageMatrix, originalPictureBox);
            int Width = IAR.imageMatrix.GetLength(1);
            int Height = IAR.imageMatrix.GetLength(0);

            if (columnsWork)
            {
                Pixel[,] ResizedMatrix = ImageUtils.NormalResize(IAR.imageMatrix, Width - numOfVerticalSeams, Height);
                ImageUtils.DisplayImage(ResizedMatrix, resultedPictureBox);
                IAR.removeColumns(numOfVerticalSeams);
            } else
            {
                Pixel[,] ResizedMatrix = ImageUtils.NormalResize(IAR.imageMatrix, Width, Height - numOfHorizontalSeams);
                ImageUtils.DisplayImage(ResizedMatrix, resultedPictureBox);
                IAR.removeRows(numOfVerticalSeams);
            }
            resizeCurrentButton.Visible = true;
        }

        // ************************ Start Layout Design ********************************* //

        private void resizeCurrentButton_MouseEnter(object sender, EventArgs e)
        {
            resizeCurrentButton.BackColor = Color.DarkRed;
        }

        private void resizeCurrentButton_MouseLeave(object sender, EventArgs e)
        {
            resizeCurrentButton.BackColor = Color.Crimson;
        }

        private void browseDevelopersButton_MouseEnter(object sender, EventArgs e)
        {
            browseDevelopersButton.BackColor = Color.DarkSlateBlue;
        }

        private void browseDevelopersButton_MouseLeave(object sender, EventArgs e)
        {
            browseDevelopersButton.BackColor = Color.RoyalBlue;
        }

        private void browseUsersButton_MouseEnter(object sender, EventArgs e)
        {
            browseUsersButton.BackColor = Color.DarkSlateBlue;
        }

        private void browseUsersButton_MouseLeave(object sender, EventArgs e)
        {
            browseUsersButton.BackColor = Color.RoyalBlue;
        }

        private void columnsWorkButton_MouseEnter(object sender, EventArgs e)
        {
            if (!columnsWork)
                columnsWorkButton.BackColor = Color.Crimson;
        }

        private void columnsWorkButton_MouseLeave(object sender, EventArgs e)
        {
            if (!columnsWork)
                columnsWorkButton.BackColor = Color.DimGray;
        }

        private void rowsWorkButton_MouseEnter(object sender, EventArgs e)
        {
            if (columnsWork)
                rowsWorkButton.BackColor = Color.Crimson;
        }

        private void rowsWorkButton_MouseLeave(object sender, EventArgs e)
        {
            if (columnsWork)
                rowsWorkButton.BackColor = Color.DimGray;
        }

        private void clearButton_MouseEnter(object sender, EventArgs e)
        {
            clearButton.BackColor = Color.DarkRed;
        }

        private void clearButton_MouseLeave(object sender, EventArgs e)
        {
            clearButton.BackColor = Color.Crimson;
        }

        // ************************ End Layout Design ********************************* //
    }
}
