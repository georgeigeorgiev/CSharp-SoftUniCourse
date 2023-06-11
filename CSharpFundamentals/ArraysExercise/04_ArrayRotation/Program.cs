namespace _04_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] output = new int[array.Length];

            int rotation = int.Parse(Console.ReadLine());
            int rotationInput = rotation;

            for (int i = 0; i < array.Length; i++)
            {
                if (rotationInput > array.Length)
                {
                    rotation = rotationInput - array.Length;
                    rotationInput = rotation;

                }

                if (rotation <= array.Length - 1)
                {
                    output[i] = array[rotation];

                    rotation++;

                }
                    
                else if (rotation >= array.Length)
                {
                        rotation = 0;
                        output[i] = array[rotation];
                        rotation++;

                        if (rotation >= rotationInput)
                        {
                            break;
                        }
                 }
            }

            foreach (var number in output)
            {
                Console.Write($"{number} ");
            }
        }
    }
}