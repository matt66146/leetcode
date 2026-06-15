fn main() {
    let arr = [1, 3, 4, 7, 1, 2, 6];

    let mut head: Option<Box<ListNode>> = Some(Box::new(ListNode::new(arr[0])));

    let mut node = head.as_mut();
    for i in 1..arr.len() {
        if let Some(n) = node {
            n.next = Some(Box::new(ListNode::new(arr[i])));
            node = n.next.as_mut();
        }
    }

    print!("Before: ");
    print_list(head.clone());
    head = delete_middle(head);
    print!("After: ");
    print_list(head);
}
pub fn delete_middle(mut head: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
    let mut values = Vec::new();
    let mut curr = &head;

    while let Some(node) = curr {
        values.push(node.val);
        curr = &node.next;
    }

    if values.len() == 1 {
        return None;
    }

    let middle = values.len() / 2;
    values.remove(middle);

    let mut dummy = Box::new(ListNode::new(0));
    let mut tail = &mut dummy;

    for val in values {
        tail.next = Some(Box::new(ListNode::new(val)));
        tail = tail.next.as_mut().unwrap();
    }

    dummy.next
}

fn delete_middlev1(head: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
    let mut head = head;

    // base cases
    if head.as_ref()?.next.is_none() {
        return None;
    }

    if let Some(ref mut first) = head {
        if let Some(ref mut second) = first.next {
            if second.next.is_none() {
                // Delete the second node
                first.next = None;
            }
        }
    }

    let mut i = 0;
    let mut middle = 0;

    let mut current = head.as_mut();
    let mut prev: Option<&mut ListNode> = None;
    let mut next: Option<&mut ListNode> = None;

    while let Some(node) = current {
        if i / 2 > middle && node.next.is_some() {
            middle = i / 2;

            prev = Some(&mut **node);
            next = node.next.as_deref_mut();
        }

        current = node.next.as_mut();
        i += 1;
    }

    head
}

fn print_list(head: Option<Box<ListNode>>) {
    let mut node = head.as_ref();
    while let Some(n) = node {
        print!("{} ", n.val);
        node = n.next.as_ref();
    }
    println!();
}

#[derive(PartialEq, Eq, Clone, Debug)]
pub struct ListNode {
    pub val: i32,
    pub next: Option<Box<ListNode>>,
}

impl ListNode {
    #[inline]
    fn new(val: i32) -> Self {
        ListNode { next: None, val }
    }
}
