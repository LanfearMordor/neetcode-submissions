public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        foreach (var a in asteroids){
            int curr = a;
            while(stack.Count > 0 && curr < 0 && stack.Peek() > 0){
                int diff = curr + stack.Peek();
                if (diff < 0)
                    stack.Pop();
                else if(diff > 0)
                    curr = 0;
                else{
                    curr = 0;
                    stack.Pop();
                }
            }

            if(curr != 0)
                stack.Push(curr);
        }

        return stack.Reverse().ToArray();
    }
}