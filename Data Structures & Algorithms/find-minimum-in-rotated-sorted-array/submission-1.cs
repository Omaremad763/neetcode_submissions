public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;

            // لو العنصر اللي في النص أكبر من اللي في الآخر، يبقى الصغير على اليمين
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            } 
            // خلاف ذلك، الصغير في الناحية الشمال أو هو الـ mid نفسه
            else {
                right = mid;
            }
        }

        // أول ما الـ left والـ right يقابلوا بعض، يبقى قفشنا أصغر عنصر
        return nums[left];
    }
}