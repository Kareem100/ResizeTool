using System;
using System.Collections.Generic;

namespace ResizeTool
{ 
    class ImageAwareResize
    {
        public struct Coord
        {
            public int row;
            public int column;
        }

        public Pixel[,] imageMatrix;
        public int[,] energyMatrix;
        public int[,] vertIndexMat;
        public int[,] horzIndexMat;

        public ImageAwareResize(string ImagePath)
        {
            imageMatrix = ImageUtils.getImageMatrix(ImagePath);
            energyMatrix = ImageUtils.CalculateEnergy(imageMatrix);
            vertIndexMat = null;
            horzIndexMat = null;
        }

        #region VerticalSeamCode
            public void calculateVertIndexMat(int numberOfSeams)
            {
                int Width = imageMatrix.GetLength(1);
                int Height = imageMatrix.GetLength(0);

                List<ImageAwareResize.Coord> seamPathCoord = null;
                vertIndexMat = new int[Height, Width];

                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                        vertIndexMat[i, j] = int.MaxValue;

                for (int s = 1; s <= numberOfSeams; s++)
                {
                    calculateVertSeamsCost(energyMatrix, Width, Height, ref seamPathCoord);

                    // Mark all pixels of the current min Seam in the VerIndexMap
                    for (int i = Height - 1; i >= 0; i--)
                    {
                        if (vertIndexMat[seamPathCoord[i].row, seamPathCoord[i].column] != int.MaxValue)
                        {
                            string msg = "Overalpped seams between seam # " + s + " and seam # " + vertIndexMat[seamPathCoord[i].row, seamPathCoord[i].column];
                            throw new Exception(msg);
                        }
                        vertIndexMat[seamPathCoord[i].row, seamPathCoord[i].column] = s;
                        //remove this seam from energy matrix by setting it to max value
                        energyMatrix[seamPathCoord[i].row, seamPathCoord[i].column] = int.MaxValue;
                    }
                    //re-calculate Seams Cost in the next iteration again
                }
            }

            public void removeColumns(int numberOfCols)
            {
                int Width = imageMatrix.GetLength(1);
                int Height = imageMatrix.GetLength(0);
                energyMatrix = ImageUtils.CalculateEnergy(imageMatrix);

                List<Coord> seamPathCoord = null;
                calculateVertSeamsCost(energyMatrix,Width,Height, ref seamPathCoord);
                calculateVertIndexMat(numberOfCols);

                Pixel[,] OldImage = imageMatrix;
                imageMatrix = new Pixel[Height, Width - numberOfCols];
                for (int i = 0; i < Height; i++)
                {
                    int cnt = 0;
                    for (int j = 0; j < Width; j++)
                    {
                        if (vertIndexMat[i, j] == int.MaxValue)
                            imageMatrix[i, cnt++] = OldImage[i, j];
                    }
                }
            }

            public void calculateVertSeamsCost(int[,] energyMatrix, int Width, int Height, ref List<Coord> seamPathCoord)
            {
                int[,] dpStorage = new int[Height, Width];
                int start = 0;
                getMinVertSeamValue(energyMatrix, ref dpStorage, Width, Height, ref start);
                seamPathCoord = getVertSeamPath(energyMatrix, dpStorage, start);
            }

            private int getMinVertSeamValue(int[,] energyMatrix, ref int[,] dpStorage, int Width, int Height, ref int start)
            {
                int min = int.MaxValue;

                for (int i = 0; i < Height; ++i)
                    for (int j = 0; j < Width; ++j)
                    {
                        if (i == 0)
                            dpStorage[i, j] = energyMatrix[i, j];
                        else if (j == 0)
                            dpStorage[i, j] = energyMatrix[i, j] +
                                Math.Min(dpStorage[i - 1, j], dpStorage[i - 1, j + 1]);
                        else if (j == Width - 1)
                            dpStorage[i, j] = energyMatrix[i, j] +
                                Math.Min(dpStorage[i - 1, j], dpStorage[i - 1, j - 1]);
                        else
                            dpStorage[i, j] = energyMatrix[i, j] +
                                Math.Min(dpStorage[i - 1, j],
                                Math.Min(dpStorage[i - 1, j - 1], dpStorage[i - 1, j + 1]));
                        if (i == Height - 1)
                            if (dpStorage[i, j] < min) { min = dpStorage[i, j]; start = j; }
                    }
                return min;
            }

            private List<Coord> getVertSeamPath(int[,] energyMatrix, int[,] dpStorage, int start)
        {
            List<Coord> coords = new List<Coord>();
            Coord point = new Coord();
            int i = energyMatrix.GetLength(0) - 1;
            int j = start;
            while (true)
            {
                point.row = i; point.column = j;
                coords.Add(point);
                if (i == 0) break;

                else if (j == 0)
                    if (dpStorage[i - 1, j + 1] <= dpStorage[i - 1, j])
                        j++;

                    else if (j == energyMatrix.GetLength(1) - 1)
                        if (dpStorage[i - 1, j - 1] <= dpStorage[i - 1, j])
                            j--;

                        else
                        if (dpStorage[i - 1, j + 1] <= dpStorage[i - 1, j - 1] && dpStorage[i - 1, j + 1] <= dpStorage[i - 1, j])
                            j++;
                        else if (dpStorage[i - 1, j - 1] <= dpStorage[i - 1, j] && dpStorage[i - 1, j - 1] <= dpStorage[i - 1, j + 1])
                            j--;
                i--;
            }
            return coords;
        }
        #endregion

        #region HorizontalSeamCode
            public void calculateHorzIndexMat(int NumberOfSeams)
            {
                int Width = imageMatrix.GetLength(1);
                int Height = imageMatrix.GetLength(0);
                List<ImageAwareResize.Coord> seamPathCoord = null;
                horzIndexMat = new int[Height, Width];

                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                        horzIndexMat[i, j] = int.MaxValue;

                for (int s = 1; s <= NumberOfSeams; s++)
                {
                    calculateHorzSeamsCost(energyMatrix, Width, Height, ref seamPathCoord);

                    // Mark all pixels of the current min Seam in the horzIndexMap
                    for (int i = Width - 1; i >= 0; i--)
                    {
                        if (horzIndexMat[seamPathCoord[i].row, seamPathCoord[i].column] != int.MaxValue)
                        {
                            string msg = "Overalpped seams between seam # " + s + " and seam # " + horzIndexMat[seamPathCoord[i].row, seamPathCoord[i].column];
                            throw new Exception(msg);
                        }
                        horzIndexMat[seamPathCoord[i].row, seamPathCoord[i].column] = s;
                        //remove this seam from energy matrix by setting it to max value
                        energyMatrix[seamPathCoord[i].row, seamPathCoord[i].column] = int.MaxValue;
                    }
                    //re-calculate Seams Cost in the next iteration again
                }
            }

            public void removeRows(int numberOfRows)
            {
                int Width = imageMatrix.GetLength(1);
                int Height = imageMatrix.GetLength(0);
                energyMatrix = ImageUtils.CalculateEnergy(imageMatrix);

                List<Coord> seamPathCoord = null;
                calculateHorzSeamsCost(energyMatrix, Width, Height, ref seamPathCoord);
                calculateHorzIndexMat(numberOfRows);

                Pixel[,] OldImage = imageMatrix;
                imageMatrix = new Pixel[Height - numberOfRows, Width];
                
                for (int j = 0; j < Width; j++)
                {
                    int cnt = 0;
                    for (int i = 0; i < Height; i++)
                        if (horzIndexMat[i, j] == int.MaxValue)
                            imageMatrix[cnt++, j] = OldImage[i, j];
                }
            }

            public void calculateHorzSeamsCost(int[,] energyMatrix, int Width, int Height, ref List<Coord> seamPathCoord)
            {
                int[,] dpStorage = new int[Height, Width];
                int start = 0;
                getMinHorzSeamValue(energyMatrix, ref dpStorage, Width, Height, ref start);
                seamPathCoord = getHorzSeamPath(energyMatrix, dpStorage, start);
            }

            private int getMinHorzSeamValue(int[,] energyMatrix, ref int[,] dpStorage, int Width, int Height, ref int start)
            {
                int min = int.MaxValue;

                for (int j = 0; j < Width; ++j)
                    for (int i = 0; i < Height; ++i)
                    {
                        if (j == 0) 
                            dpStorage[i, j] = energyMatrix[i, j];
                        else if (i == 0) 
                            dpStorage[i, j] = energyMatrix[i, j] +
                                Math.Min(dpStorage[i, j - 1], dpStorage[i + 1, j - 1]);
                        else if (i == Height - 1) 
                            dpStorage[i, j] = energyMatrix[i, j] +
                                Math.Min(dpStorage[i, j - 1], dpStorage[i - 1, j - 1]);
                        else 
                            dpStorage[i, j] = energyMatrix[i, j] + Math.Min(dpStorage[i, j - 1],
                            Math.Min(dpStorage[i - 1, j - 1], dpStorage[i + 1, j - 1]));
                        if (j == Width - 1)
                            if (dpStorage[i, j] < min) { min = dpStorage[i, j]; start = i; }
                    }

            return min;
            }

            private List<Coord> getHorzSeamPath(int[,] energyMatrix, int[,] dpStorage, int start)
            {
            List<Coord> coords = new List<Coord>();
            Coord point = new Coord();
            int j = energyMatrix.GetLength(1) - 1;
            int i = start;
            while (true)
            {
                point.row = i; point.column = j;
                coords.Add(point);
                if (j == 0) break;

                else if (i == 0)
                    if (dpStorage[i + 1, j - 1] <= dpStorage[i, j - 1])
                        i++;

                    else if (i == energyMatrix.GetLength(0) - 1)
                        if (dpStorage[i - 1, j - 1] <= dpStorage[i, j])
                            i--;

                        else
                        if (dpStorage[i - 1, j - 1] <= dpStorage[i + 1, j - 1] && dpStorage[i - 1, j - 1] <= dpStorage[i, j - 1])
                            i--;
                        else if (dpStorage[i + 1, j - 1] <= dpStorage[i - 1, j - 1] && dpStorage[i + 1, j - 1] <= dpStorage[i, j - 1])
                            i++;
                j--;
            }
            return coords;
            }
        #endregion
    }
}
