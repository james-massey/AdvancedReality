import math
import SendKeys
import time

text_file = open("Coord.txt", "r")

for aline in text_file:
   datalist = aline.split()

text_file.close()

# separating text file
robot_x = datalist[0]
robot_y = datalist[1]
robot_angle = datalist[2]
ball_x = datalist[3]
ball_y = datalist[4]

# converting to float
robot_x = float(robot_x)
robot_y = float(robot_y)
robot_angle = float(robot_angle)
ball_x = float(ball_x)
ball_y = float(ball_y)

# math
x = abs(robot_x - ball_x)
y = abs(robot_y - ball_y)
dist = math.sqrt(x*x + y*y)
angle_rad = math.atan(y/x)
angle_deg = math.degrees(angle_rad)

# direction
a = 360 - (robot_angle - angle_deg)
float(a)

def turn_right(turn):
    sec = (2 * turn) / 360  #add time to turn 360
    sendMe = 'd'
    time.sleep(1)
    SendKeys.SendKeys(sendMe)
    sendMe = 'q'
    time.sleep(sec)
    SendKeys.SendKeys(sendMe)

def turn_left(turn):
    sec = (2 * turn) / 360  #add time to turn 360
    sendMe = 'a'
    time.sleep(1)
    SendKeys.SendKeys(sendMe)
    sendMe = 'q'
    time.sleep(sec)
    SendKeys.SendKeys(sendMe)

if a != 360:
    if a < 180:
        turn = a
        print "left turn" 
        turn_left(turn)
    
    else:
        turn = 360 - a
        print "right turn"
        turn_right(turn)

# distance
if a == 360:
   time.sleep(1)

distTime = (.5 * dist)  #add (units per second)/1
sendMe = 'w'
SendKeys.SendKeys(sendMe)
print "forward"
time.sleep(distTime)



    


    




 
        
        

