public class Solution {
    public IList < IList < int >> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var ret = new List < IList < int >> ();

        for (var i = 0; i < nums.Length - 2; i++) {
            for (var j = i + 1; j < nums.Length - 1; j++) {
                for (var k = j + 1; k < nums.Length; k++) {
                    var aux = new List < int > () {
                        nums[i],
                            nums[j],
                            nums[k]
                    }

                    ;

                    if (aux.Sum() == 0 && !ret.Any(x => x.SequenceEqual(aux))) {
                        ret.Add(aux);
                    }
                }
            }
        }

        return ret;
    }
}