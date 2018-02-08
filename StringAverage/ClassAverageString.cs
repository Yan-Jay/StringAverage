namespace StringAverage
{
    public class ClassAverageString
    {
        public string convert(string input)
        {
            var inputArray = input.Split(' ');
            string[] numberArray = {"zero","one","two","three","four","five","six","seven","eight", "nine" };
            var sum = 0;
            var count = 0;
            var eorror = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                eorror = 0;
                for (int j = 0; j < numberArray.Length; j++)
                {
                    if (inputArray[i]==numberArray[j])
                    {
                        count++;
                        sum += j;
                        eorror = 1;
                    }
                    
                }

                if (eorror == 0)
                {
                    return "n/a";
                }
                
            }

            if (sum==0 && count>0)
            {
                return numberArray[0];
            }
            else
            {
                sum /= count;
                return numberArray[sum];
            }

        }
    }
}