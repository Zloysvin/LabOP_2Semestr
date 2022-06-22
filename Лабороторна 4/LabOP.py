from abc import ABC, abstractmethod
import math


class TVector(ABC):

    def __init__(self, *coordinates):
        self.__coordinates = coordinates

    def GetCoordintaes(self):
        return self.__coordinates

    @abstractmethod
    def ISParalel(self, vector):
        pass

    @abstractmethod
    def IsPerpendicular(self, vector):
        pass

    @abstractmethod
    def GetLenght(self):
        pass


class Vector2D(TVector):

    def __init__(self, *coordinates):
        TVector.__init__(self, coordinates)
        self.__x = coordinates[0]
        self.__y = coordinates[1]
        pass

    def ISParalel(self, vector):
        if self.__x/vector.__x == self.__y/vector.__y:
            return 1
        return 0

    def IsPerpendicular(self, vector):
        if self.__x * vector.__x + self.__y * vector.__y == 0:
            return 1
        return 0

    def GetLenght(self):
        return math.sqrt(math.pow(self.__x, 2) + math.pow(self.__y, 2))


class Vector3D(TVector):

    def __init__(self, *coordinates):
        TVector.__init__(self, coordinates)
        self.__x = coordinates[0]
        self.__y = coordinates[1]
        self.__z = coordinates[2]
        pass

    def ISParalel(self, vector):
        if self.__x/vector.__x == self.__y/vector.__y and self.__x/vector.__x == self.__z/vector.__z:
            return 1
        return 0

    def IsPerpendicular(self, vector):
        if self.__x * vector.__x + self.__y * vector.__y + self.__z * vector.__z == 0:
            return 1
        return 0

    def GetLenght(self):
        return math.sqrt(math.pow(self.__x, 2) + math.pow(self.__y, 2) + math.pow(self.__y, 2))


class Functions(object):

    staticmethod
    def CreateVector(self, vector2Ds, v2count, vector3Ds, v3count):
        print("Enter 2D Vectors")
        for i in range(0, v2count):
            print("Enter Vector " + str(i+1) + " coordinates")
            print("Enter Coordinate X")
            x = int(input())
            print("Enter Coordinate Y")
            y = int(input())
            vector2Ds.append(Vector2D(x, y))
            print()
        print("Enter 3D Vectors")
        for i in range(0, v3count):
            print("Enter Vector " + str(i+1) + " coordinates")
            print("Enter Coordinate X")
            x = int(input())
            print("Enter Coordinate Y")
            y = int(input())
            print("Enter Coordinate Z")
            z = int(input())
            vector3Ds.append(Vector3D(x, y, z))
            print()

    staticmethod
    def Find2DParalelLenghtSum(self, vector2Ds):
        sum = 0
        for i in range(1, len(vector2Ds)):
            if vector2Ds[0].ISParalel(vector2Ds[i]):
                sum += vector2Ds[i].GetLenght()
        return sum

    staticmethod
    def FindPerpenVectorSum(self, vector3Ds):
        x = 0
        y = 0
        z = 0
        for i in range(1, len(vector3Ds)):
            if vector3Ds[0].IsPerpendicular(vector3Ds[i]):
                x += vector3Ds[i].GetCoordintaes()[0][0]
                y += vector3Ds[i].GetCoordintaes()[0][1]
                z += vector3Ds[i].GetCoordintaes()[0][2]
        print("Vector Sum Equals: " + str(x) + ", " + str(y) + ", " + str(z))
        return Vector3D(x, y, z)


v2 = []
v3 = []
v2count = int(input())
v3count = int(input())
Functions.CreateVector(Functions, v2, v2count, v3, v3count)
answer1 = Functions.Find2DParalelLenghtSum(Functions, v2)
print(answer1)
Functions.FindPerpenVectorSum(Functions, v3)