# Intuition
The task is to minimize the number of boats required to carry all people without exceeding the weight limit of each boat and while carrying up to two people per boat. The first thought is to try to pair the heaviest and lightest person together to fit within the weight limit and maximize the number of people carried by each boat. This way, we can minimize the total number of boats.

# Approach
The approach to solving the problem is a greedy two-pointer strategy:

1. Sorting: First, we sort the array of people's weights in non-decreasing order. This helps in easily determining who can pair up with whom.
2. Two-pointer technique: We use two pointers: one (left) starts from the beginning of the sorted array, pointing to the lightest person, while the other (right) starts from the end of the sorted array, pointing to the heaviest person.
3. Pairing: We attempt to pair the lightest (left) and heaviest (right) person together. If their combined weight does not exceed the limit, they can share a boat, and we move both pointers inward (i.e., increment left and decrement right).
4. Single allocation: If the heaviest person cannot be paired with the lightest person (because their combined weight exceeds the limit), then the heaviest person (right pointer) will go on a boat alone. In this case, we only move the right pointer inward (decrement right).
5. Count boats: We increment the boat count each time we use a boat (either for a single person or a pair).
6. Repeat: Repeat the process until all people have been allocated to boats.
This approach effectively minimizes the number of boats required by ensuring each boat is as full as possible (with one or two people) and moves toward the middle of the sorted list.

# Complexity
- Time complexity: Sorting the array takes O(nlogn) time. The two-pointer approach involves a single pass through the array, so that part is O(n). Therefore, the overall time complexity of the algorithm is O(nlogn) due to the sorting step.
- Space complexity: The approach uses a constant amount of additional space (e.g., for pointers and counters), so the space complexity is O(1).
