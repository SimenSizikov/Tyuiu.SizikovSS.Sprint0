namespace Tyuiu.SizikovSS.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resulrArray = new int[5];
            for (var i = 0; i < resulrArray.Length; i++)
            {
                resulrArray[i] = numOne[i] + numTwo[i];
            }
            return resulrArray;
        }
    }
}
