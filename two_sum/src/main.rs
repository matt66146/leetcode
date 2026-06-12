use std::collections::HashMap;

fn main() {
    two_sum(vec![2, 7, 11, 15], 9);
}

pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
    let mut map: HashMap<i32, i32> = HashMap::new();

    for i in 0..nums.len() {
        if map.contains_key(&nums[i]) {
            println!("{},{}", i as i32, map[&nums[i]]);
            return vec![i as i32, map[&nums[i]]];
        } else {
            map.insert(target - nums[i], i as i32);
        }
    }
    return Vec::new();
}
