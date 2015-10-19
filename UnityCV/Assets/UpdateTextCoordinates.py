import random
import os
import re

fileTestPath = 'C:/Users/Megatron/Documents/GitHub/AdvancedReality/UnityCV/Assets/TestCoordinates.txt'

fileName = 'TestCoordinates.txt'
file_absPath = os.path.abspath(fileName)
#print file_absPath

file_progPath = str.replace(file_absPath, '\\', '/')
print file_progPath

file = open(fileTestPath, 'w')
#print file
#text=file.read()
number = random.uniform(-4,4)
coords = str(number) + ',0,'+ str(number)
print coords
file.write(str(coords))
file.close()
print "Done"
