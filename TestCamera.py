from SimpleCV import Camera
from SimpleCV import Display

cam = Camera()
disp = Display()

while disp.isNotDone():
    img=cam.getImage()
    
