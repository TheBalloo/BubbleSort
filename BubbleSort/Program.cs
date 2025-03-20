int[] nums = { 1, 5, 45, 8, 7, 45, 85, 44};

Random rand = new Random();
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