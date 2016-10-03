/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;
            if(maze[xStart, yStart] == ',')
            {
                Console.WriteLine("Done");
                PrintMaze(maze);
            }
            else
            {
                mazeTraversal(xStart,yStart);
            }
            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }
        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(int CurrentX, int CurrentY)
        {   
            //---------------------------------------------------
            //Direction comments included for debugging and will be removed.
            //---------------------------------------------------
            
            //method used to iterate through the maze using recursion.
            int currentX = CurrentX;            //current location
            int currentY = CurrentY;
   
            //Implement maze traversal recursive call
            if (maze[currentX + 1, currentY] =='.')
            {   
                //place 'X' at current location.
                maze[currentX, currentY] = 'X';

                //move right
                currentX += 1;

                //print maze after step has been taken before recursion calls again.
                PrintMaze(maze);
                
                //Make a recursive call to traverse the maze.
                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX, currentY + 1]=='.')
            {   //place 'X' at current location.
                maze[currentX, currentY] = 'X';
                
                //move up
                currentY += 1;

                //print maze after step has been taken before recursion calls again.
                PrintMaze(maze);

                //Make a recursive call to traverse the maze.
                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX - 1, currentY] =='.')
            {   //place 'X' at current location.
                maze[currentX, currentY] = 'X';
                
                //move left
                currentX -= 1;

                //print maze after step has been taken before recursion calls again.
                PrintMaze(maze);

                //Make a recursive call to traverse the maze.
                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX, currentY - 1]=='.')
            {   //place 'X' at current location.
                maze[currentX, currentY] = 'X';
                
                //move down
                currentY -= 1;

                //print maze after step has been taken before recursion calls again.
                PrintMaze(maze);

                //Make a recursive call to traverse the maze.
                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX, currentY]=='#')
            {   //mark '0' when the maze must go back.
                maze[currentX, currentY] ='O';

                Console.WriteLine("Back");
                PrintMaze(maze);
            }
        }
        /// <summary>
        /// Method used to print the maze after each step so there is visible progress
        /// </summary>
        /// <param name="maze"></param>
        public void PrintMaze(char[,] maze)
        {   //declare a local level variable to dump the maze into.
            this.maze = maze;

            //counter variable.
            int index = 0;

            //loop to print the contents of the maze array to the terminal.
            foreach (char x in this.maze)
            {
                Console.Write(x);

                //variable used to keep track of iteration through the loop.
                index += 1;

                //if  index divided by 12 has a remainder of 0 the terminal prints a new line.
                if (index % 12 == 0)
                {
                    Console.WriteLine();
                }
                

            }
            //line added for readability between all the print commands.
            Console.WriteLine();
        }
    }
}          
