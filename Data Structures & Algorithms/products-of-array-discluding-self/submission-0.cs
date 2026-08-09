// 자기 자신을 제외하고, 모두 곱했을때의 결과를 배열에 넣음.
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalProduct = 1, zeroCount = 0;

        for(int i = 0; i < nums.Length; i ++){
            totalProduct *= (nums[i] == 0 ? 1 : nums[i]);
            if(nums[i] == 0)
                zeroCount ++;
        }

        var nonProductNums = new int[nums.Length];

        for(int i = 0; i < nums.Length; i ++){
            if(zeroCount >= 2){
                nonProductNums[i] = 0;
                continue;
            }
            if(zeroCount > 0 && nums[i] != 0){
                nonProductNums[i] = 0;
                continue;
            }
            nonProductNums[i] = totalProduct / (nums[i] == 0 ? 1 : nums[i]);
        }

        return nonProductNums;
    }
}
