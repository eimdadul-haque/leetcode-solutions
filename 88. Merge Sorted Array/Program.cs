class Program
{
    public static void Main(string[] args)
    {
         Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int last = (m + n) - 1;
        while (m > 0 && n > 0)
        {
            if (nums1[m - 1] > nums2[n - 1])
            {
                nums1[last] = nums1[m - 1];
                m--;
            }
            else
            {
                nums1[last] = nums2[n - 1];
                n--;
            }

            last--;
        }

        while (n > 0)
        {
            nums1[last] = nums2[n - 1];
            n--; last--;
        }
    }
}
