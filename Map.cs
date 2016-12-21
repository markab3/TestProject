using System;

namespace ConsoleApplication
{
    public class Map {
        private char[,] map;

        public Map (int size) {
            int sizeX = size;
            int sizeY = size;
            map = new char[size, size];
            for (int i =0; i < sizeX;i++) {
                for (int j=0; j < sizeY;j++) {
                    map[ i, j] = 'G';
                }
            }
        }
    }
}