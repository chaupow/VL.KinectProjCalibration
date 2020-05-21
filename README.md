# VL.KinectProjCalibration
_Utilities to calibrate a Kinect V1 and a Projector in vvvv gamma_

Ultimately, this provides a mapping from 3D Kinect space to your 2D projector's space.

## Requirements

Couple of nodes to help calibrate a Kinect V1 and a projector with vvvv gamma. Requires
- [VL.OpenCV](https://github.com/vvvv/VL.OpenCV)
- [VL.Devices.Kinect](https://github.com/chaupow/VL.Devices.Kinect)
- [VL.Skia3D](https://github.com/vvvv/VL.Skia3d)

Pretty sure this might not work out of the box because I'm not sure how to properly set .dll references. If you want to use and it doesn't work, try setting the OpenCVSharp reference to the .dll that ships with VL.OpenCV in VS Studio with the OpenCVHelper solution and compile it yourself - or just leave an issue and/or DM me in the vvvv matrix.

## How to use

- Check the **HowTo Calibrate** patch on how to set calibration points and save the calibration.
- Check the **HowTo Use a Calibration** patch on how to read a calibration file and map Kinect 3D to your projector space

## Questions?

- Leave a GitHub issue or
- Find my on the [vvvv matrix](https://vvvv.org/chat)