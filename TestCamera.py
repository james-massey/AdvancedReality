from SimpleCV import Camera
from SimpleCV import Display

cam = Camera()
disp = Display()

while disp.isNotDon():
    img=cam.getImage()
    
