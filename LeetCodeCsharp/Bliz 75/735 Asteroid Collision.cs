using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _735_Asteroid_Collision
{
    //Failed to solve besauce description is not clear about inputs
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new();
        foreach (int asteroid in asteroids)
        {
            if(asteroid > 0) stack.Push(asteroid);
            else
            {
                while (stack.Count > 0 && stack.Peek() > 0 
                    && stack.Peek() < Math.Abs(asteroid)) stack.Pop();

                if (stack.Count == 0 || stack.Peek() < 0)
                {
                    stack.Push(asteroid);
                }
                else if (stack.Peek() == Math.Abs(asteroid)) stack.Pop();
            }
        }

        int[] result = new int[stack.Count];
        for(int i = result.Length -1; i >= 0; i--)
        {
            result[i] = stack.Pop();
        }
        return result;
    }

}
