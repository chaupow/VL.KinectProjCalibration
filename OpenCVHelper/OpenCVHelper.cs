using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;



public static class OpenCVHelper
{
    public static double[,] TransformMatToMultiDimArray(Mat input)
    {
        double[,] arr = new double[input.Height, input.Width];
        for (int i = 0; i < input.Height; i++)
        {
            for (int j = 0; j < input.Width; j++)
            {
                arr[i, j] = input.At<double>(i, j);
            }
        }
        return arr;
    }



    public static Mat TransformMultiDimArrayToMat(double[,] input)
    {
        Mat A = new Mat(input.GetLength(0), input.GetLength(1), OpenCvSharp.MatType.CV_64FC1, input);
        return A;
    }

    public static void ProjectPoints(Point3f[] objectPoints, double[] rvec, double[] tvec, Mat cameraMatrix, double[] distCoeffs, double aspectRatio, out Point2f[] imagePoints, out double[,] jacobian) {
        double[,] cameraMatrixArray = TransformMatToMultiDimArray(cameraMatrix);
        Cv2.ProjectPoints(objectPoints, rvec, tvec, cameraMatrixArray, distCoeffs, out imagePoints, out jacobian, aspectRatio);
    }


}
