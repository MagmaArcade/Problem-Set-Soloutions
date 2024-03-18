// You are given an array of integers a and an integer k. Your task is to calculate the number of ways 
// to pick two different indices i < j, such that a[i] + a[j] is divisible by k.

// initial solutions

/*
long solution(int[] a, int k) {
    int count = 0;
    foreach (int i in a) {
        foreach (int j in a) {
            if (i != j && (i + j) % k == 0) {
                count += 1;
            } 
        }
    }
    return count / 2;
}
*/


// refactored code to reduce recursion 

long solution(int[] a, int k) {
    // Create a dictionary to store remainders and their counts
    Dictionary<int, int> remainders = new Dictionary<int, int>();
    long count = 0;
    
    // Calculate the remainders of each element in a and count their occurrences
    foreach (int num in a)
    {
        int remainder = num % k;
        int complement = (k - remainder) % k; // Find the complement remainder
        
        if (remainders.ContainsKey(complement)) {
            count += remainders[complement]; // Add the count of complements to the total
        }
        
        // Increment or add the current remainder to the dictionary
        if (remainders.ContainsKey(remainder)) {
            remainders[remainder]++;
        }        
        else {
            remainders[remainder] = 1;
        }
    }
        
    return count;
}
