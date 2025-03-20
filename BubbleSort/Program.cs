Random rand = new Random();
int[] nums = new int[rand.Next(0, 100)];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rand.Next(0, 100);
}

int temp;
for (int x = 0; x < nums.Length - 1; x++)
{
    for (int y = x + 1; y < nums.Length; y++)
    {
        if (nums[x] > nums[y])
        {
            temp = nums[x];
            nums[x] = nums[y];
            nums[y] = temp;
        }
    }
    Console.WriteLine(nums[x]);
}