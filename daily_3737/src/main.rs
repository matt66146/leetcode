struct Solution;
fn main() {
    let answer = Solution::count_majority_subarrays(vec![1, 2, 3], 1);
    println!("{}", answer);
}

impl Solution {
    pub fn count_majority_subarrays(nums: Vec<i32>, target: i32) -> i32 {
        let mut answer: i32 = 0;

        for i in 0..nums.len() {
            for j in i..nums.len() {
                let slice = &nums[i..=j];
                let freq = slice.iter().filter(|&&v| v == target).count() as i32;
                let len = (j - i + 1) as i32;

                if 2 * freq > len {
                    answer += 1;
                }
            }
        }

        return answer;
    }
}
