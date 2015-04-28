import random


file = open('C:/Users/Megatron/Documents/GitHub/AdvancedReality/UnityCV/Assets/TestCoordinates.txt', 'w')
#text=file.read()
number = random.uniform(-10,10)
coords = str(number) + ',0,'+ str(number)
print coords
file.write(str(coords))
file.close()
print "Done"
exit()
