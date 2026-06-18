struct Solution;
fn main() {
    let result = Solution::angle_clock(12, 30);
    println!("{}", result);
}
impl Solution {
    pub fn angle_clock(hour: i32, minutes: i32) -> f64 {
        let mut answer = ((30.0 * hour as f64) - (5.5 * minutes as f64)).abs();
        println!("{}", answer);
        if answer > 180.0 {
            answer = 360.0 - answer;
        }
        answer
    }
}
