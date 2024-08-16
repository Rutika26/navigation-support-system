In automated surveillance systems with multiple cameras, the system must be 
able to position the cameras accurately. Each camera must be able to pan-tilt such 
that an object detected in the scene is in a vantage position in the camera’s image 
plane and subsequently capture images of that object. Typically, camera calibration 
is required. We propose an approach that uses only image-based information. Each 
camera is assigned a pan-tilt zero-position. Position of an object detected in one 
camera is related to the other cameras by homographs between the zero-positions
while different pan-tilt positions of the same camera are related in the form of 
projective rotations. We then derive that the trajectories in the image plane 
corresponding to these projective rotations are approximately circular for pan and 
linear for tilt. The camera control technique is subsequently tested in a working 
prototype. 
This project aims to develop remote navigation support system using image 
processing for robotics system. This includes Pan-Tilt movements which can be 
controller by various commands through programming. Also there is one camera 
mounted on that pan-tilt unit which is to display the visuals and we can see in on 
laptop. This can capture some random picture from that visual and can be save at 
any location as we want. After that we also able to open that picture on application 
window and can be perform image processing on that like grayscale, flip, edge 
detection etc

 Problem Statement : 
 Remote navigation support system using image processing for robotics system.
 
 Scope : 
Image processing has wide range of application in robotics systems such as obstacle 
avoidance, stereo vision, target detection and tracking etc. Under this project various image 
processing algorithms will be explored and implemented using C# and OpenCV

Technologies involved :
Robotics, Image Processing, OpenCV, Computer vision

Requirements 
Development Interface : Microsoft Visual Studio 2019
Hardware : Pan Tilt, Camera, Analog to Digital Converter, OS-Windows 
API : EmguCV, OpenCV
Programming Language : C#

Conclusion :
In this project, we have presented an image-based pan-tilt camera control technique by 
deriving the underlying characteristics of the projective rotations corresponding to camera pan-tilt. 
This image-based model greatly simplifies the task of camera control. This contribution would 
facilitate future development of a multi-camera surveillance system. Effectiveness and reliability 
of the technique have also been tested rigorously in a real-time pro-to type system.
The current Pan Tilt system has been designed and developed with the theoretical and 
practical understanding obtained in the beginning along with an earlier familiarity of working
